﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsMetrics.Helpers;
using CommonModels;

namespace WindowsMetrics
{
    public class Collector : IDisposable
    {
        private Writer _writer;

        private IntPtr _foregroundWindowHook;
        private IntPtr _mouseClickHook;

        private GCHandle _foregroundWindowHandle;
        private GCHandle _mouseClickHandle;

        private event Action StateScan;

        private Guard _guardStateScanner;
        private Task _taskForGuardStateScanner; // where guard works in

        private const int StateScanIntervalSec = 5; // TODO to config



        #region Handlers for the events being tracked

        private static string MakeRegistry(CollectionEvent @event)
        {
            string foregroundWinTitle = WinAPI.GetTextOfForegroundWindow();
            string path = WinAPI.GetForegroundWindowExeModulePath();
            string user = WinAPI.GetSystemUserName();
            string process = WinAPI.GetForegroundWindowProcessName();
            string currTime = DateTime.Now.ToString();
            string ip, mac;
            WinAPI.GetAdapters(out ip, out mac);
            //string url = WinAPI.GetChormeURL("sdf"); // TODO url
            return $"{@event}\n{foregroundWinTitle}\n{path}\n{process}\n{user}\n{currTime}\n{ip}\n{mac}\n***\n";
        }

        private readonly Action<string> _onForegroundWindowChangeAddon = null;
        private void OnForegroundWindowChange()
        {
            string registry = MakeRegistry(CollectionEvent.WIN_CHANGE);
            _writer.Append(registry);
            _onForegroundWindowChangeAddon?.Invoke(registry);
            _guardStateScanner.Reset();
        }

        private readonly Action<string> _onLeftMouseClickAddon = null;
        private void OnLeftMouseClick()
        {
            string registry = MakeRegistry(CollectionEvent.LEFT_CLICK);
            _writer.Append(registry);
            _onLeftMouseClickAddon?.Invoke(registry);
            _guardStateScanner.Reset();
        }

        private readonly SynchronizationContext _sync;
        private readonly Action<string> _onGuardStateScanAddon = null;
        private void OnGuardStateScan()
        {
            string registry = MakeRegistry(CollectionEvent.STATE_SCAN);
            _writer.Append(registry);
            if (_onGuardStateScanAddon != null)
            {
                SendOrPostCallback c = (state) => { _onGuardStateScanAddon.Invoke((string) state); };
                _sync.Post(c, registry);
            }
        }

        #endregion Handlers for the events being tracked



        private void CommonConstructor(Writer writer)
        {
            _writer = writer;
            StateScan += OnGuardStateScan;

            _taskForGuardStateScanner = new Task(() =>
                {
                    _guardStateScanner = new Guard(
                        actionToDoEveryTick: () => StateScan?.Invoke(),
                        secondsToCountdown: StateScanIntervalSec
                    );
                }
            );

            _taskForGuardStateScanner.Start();
        }

        public Collector(Writer writer)
        {
            CommonConstructor(writer);
        }
        
        /// <param name="writer"></param>
        /// <param name="sync"></param>
        /// <param name="onForegroundWindowChangeAddon">Action with the string that is created when onForegroundWindowChange occurs</param>
        /// <param name="onLeftMouseClickAddon">Action with the string that is created when onLeftMouseClick occurs</param>
        /// <param name="onGuardStateScanAddon">Action with the string that is created when onGuardStateScan occurs</param>
        public Collector(Writer writer, SynchronizationContext sync,
            Action<string> onForegroundWindowChangeAddon, Action<string> onLeftMouseClickAddon, Action<string> onGuardStateScanAddon)
        {
            _onForegroundWindowChangeAddon = onForegroundWindowChangeAddon;
            _onLeftMouseClickAddon = onLeftMouseClickAddon;
            _onGuardStateScanAddon = onGuardStateScanAddon;
            _sync = sync;
            CommonConstructor(writer);
        }

        public void Start()
        {
            _foregroundWindowHook = WinAPI.StartTrackingForegroundWindowChange(OnForegroundWindowChange, out _foregroundWindowHandle);
            _mouseClickHook = WinAPI.StartTrackingLeftClickEvent(OnLeftMouseClick, out _mouseClickHandle);

            _guardStateScanner.Start();
        }

        public bool Stop()
        {
            bool success = WinAPI.StopTrackingForegroundWindowChange(_foregroundWindowHook);
            bool success2 = WinAPI.StopTrackingLeftClickEvent(_mouseClickHook);
            _guardStateScanner.Stop();
            return success && success2;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
