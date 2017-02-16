﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonModels;
using MetricsProcessing.Exceptions;

namespace MetricsProcessing
{
    public class RegistriesProcessor
    {
        private readonly DbHelper _dbHelper;

        public RegistriesProcessor(string connectionString)
        {
            _dbHelper = new DbHelper(connectionString);
        }

        /// <returns>
        /// NULL if there's no processible registries obtained or there's no more registries, so there's no more
        /// activities can be obtained.
        /// </returns>
        public List<Activity> Process(int quantity)
        {
            List<Activity> activities = new List<Activity>();
            RegistriesList registries;
            try
            {
                registries = GetRegistries(quantity);
            }
            catch (OnlyOneNonProcessedRegistryTakenException e)
            {
                MarkAsCannotBeProcessed(e.TheOnlyRemainingRegistry);
                return null;
            }
            catch (NoNonProcessedRegistriesException)
            {
                return null;
            }
            while (!registries.IsEmpty)
            {
                int numOfRegistriesInActivity = DetectActivity(registries);
                RegistriesList activityRegistries = ExtractActivity(registries, numOfRegistriesInActivity);
                Activity activity = CreateActivity(activityRegistries);
                activities.Add(activity);
                MarkAsProcessed(activityRegistries);
            }
            return activities;
        }

        /// <exception cref="OnlyOneNonProcessedRegistryTakenException">
        /// Too few registries obtained, processing is impossible (there's no possibility of determining
        /// end time of the activity represented by the only registry)
        /// </exception>
        /// <exception cref="NoNonProcessedRegistriesException">
        /// Such a situation should not happen in a usual case - the last registry in DB cannot be processed
        /// because end time for the activity it can be involved in is unknown
        /// </exception>
        private RegistriesList GetRegistries(int registriesToProcessAtOnce)
        {
            try
            {
                var registries = _dbHelper.GetRegistries(registriesToProcessAtOnce);
                return registries;
            }
            catch (AllTakenRegistiesBeginActivityException e)
            {
                if (_dbHelper.AnyMoreRegistriesExist(e.TakenRegistries.Last().Time))
                    return GetRegistries(registriesToProcessAtOnce*2);

                return e.TakenRegistries;
            }
        }

        /// <returns>
        /// Number of registries from the first (activityRegistries[0]) that form an activity
        /// </returns>
        private static int DetectActivity(RegistriesList registries)
        {
            int count = 1;
            var activityWinId = registries[0].WindowId;
            while (count < registries.Count && registries[count].WindowId == activityWinId)
                count++;
            return count;
        }

        /// <summary>
        /// Counts the given in 'count' number of registries from the beginning (they form an activity),
        /// removes them from given registries list, returns this sublist (it contains end time of the activity)
        /// </summary>
        private static RegistriesList ExtractActivity(RegistriesList fromRegistries, int count)
        {
            var activity = fromRegistries.Take(count).ToList();
            fromRegistries.RemoveRange(0, count);
            var endTime = fromRegistries.IsEmpty ? fromRegistries.EndTime : fromRegistries[0].Time;
            return new RegistriesList(activity, endTime);
        }

        private static Activity CreateActivity(RegistriesList activityRegistries)
        {
            Activity activity = new Activity()
            {
                Name = activityRegistries.First.WindowTitle,
            };
            activity.Measurements.Add(new Measurement()
            {
                Name = "Duration",
                Type = "TimeSpan",
                Value = activityRegistries.Duration
            });
            activity.Measurements.Add(new Measurement()
            {
                Name = "Executable Path",
                Type = "String",
                Value = activityRegistries.First.ExeModulePath
            });
            activity.Measurements.Add(new Measurement()
            {
                Name = "IP address",
                Type = "String",
                Value = activityRegistries.First.IpAddress.Value
            });
            activity.Measurements.Add(new Measurement()
            {
                Name = "MAC address",
                Type = "String",
                Value = activityRegistries.First.MacAddress.Value
            });
            activity.Measurements.Add(new Measurement()
            {
                Name = "User",
                Type = "String",
                Value = activityRegistries.First.Username1.Value
            });
            return activity;
        }

        private void MarkAsProcessed(RegistriesList registries)
        {
            _dbHelper.MarkAsProcessed(registries);
        }

        private void MarkAsCannotBeProcessed(Registry registry)
        {
            _dbHelper.SetProcessedToNull(registry);
        }
    }
}
