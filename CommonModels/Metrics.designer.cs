﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonModels
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	public partial class MetricsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIpAddress(IpAddress instance);
    partial void UpdateIpAddress(IpAddress instance);
    partial void DeleteIpAddress(IpAddress instance);
    partial void InsertMacAddress(MacAddress instance);
    partial void UpdateMacAddress(MacAddress instance);
    partial void DeleteMacAddress(MacAddress instance);
    partial void InsertUsername(Username instance);
    partial void UpdateUsername(Username instance);
    partial void DeleteUsername(Username instance);
    partial void InsertRegistry(Registry instance);
    partial void UpdateRegistry(Registry instance);
    partial void DeleteRegistry(Registry instance);
    partial void InsertActivitiesRegistry(ActivitiesRegistry instance);
    partial void UpdateActivitiesRegistry(ActivitiesRegistry instance);
    partial void DeleteActivitiesRegistry(ActivitiesRegistry instance);
    #endregion
		
		public MetricsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MetricsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MetricsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MetricsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<IpAddress> IpAddresses
		{
			get
			{
				return this.GetTable<IpAddress>();
			}
		}
		
		public System.Data.Linq.Table<MacAddress> MacAddresses
		{
			get
			{
				return this.GetTable<MacAddress>();
			}
		}
		
		public System.Data.Linq.Table<Username> Usernames
		{
			get
			{
				return this.GetTable<Username>();
			}
		}
		
		public System.Data.Linq.Table<Registry> Registries
		{
			get
			{
				return this.GetTable<Registry>();
			}
		}
		
		public System.Data.Linq.Table<ActivitiesRegistry> ActivitiesRegistries
		{
			get
			{
				return this.GetTable<ActivitiesRegistry>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class IpAddress : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Value;
		
		private EntitySet<Registry> _Registries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    #endregion
		
		public IpAddress()
		{
			this._Registries = new EntitySet<Registry>(new Action<Registry>(this.attach_Registries), new Action<Registry>(this.detach_Registries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IpAddress_Registry", Storage="_Registries", ThisKey="Id", OtherKey="Ip")]
		public EntitySet<Registry> Registries
		{
			get
			{
				return this._Registries;
			}
			set
			{
				this._Registries.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Registries(Registry entity)
		{
			this.SendPropertyChanging();
			entity.IpAddress = this;
		}
		
		private void detach_Registries(Registry entity)
		{
			this.SendPropertyChanging();
			entity.IpAddress = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class MacAddress : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Value;
		
		private EntitySet<Registry> _Registries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    #endregion
		
		public MacAddress()
		{
			this._Registries = new EntitySet<Registry>(new Action<Registry>(this.attach_Registries), new Action<Registry>(this.detach_Registries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MacAddress_Registry", Storage="_Registries", ThisKey="Id", OtherKey="Mac")]
		public EntitySet<Registry> Registries
		{
			get
			{
				return this._Registries;
			}
			set
			{
				this._Registries.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Registries(Registry entity)
		{
			this.SendPropertyChanging();
			entity.MacAddress = this;
		}
		
		private void detach_Registries(Registry entity)
		{
			this.SendPropertyChanging();
			entity.MacAddress = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Username : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Value;
		
		private EntitySet<Registry> _Registries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    #endregion
		
		public Username()
		{
			this._Registries = new EntitySet<Registry>(new Action<Registry>(this.attach_Registries), new Action<Registry>(this.detach_Registries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Username_Registry", Storage="_Registries", ThisKey="Id", OtherKey="Username")]
		public EntitySet<Registry> Registries
		{
			get
			{
				return this._Registries;
			}
			set
			{
				this._Registries.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Registries(Registry entity)
		{
			this.SendPropertyChanging();
			entity.Username1 = this;
		}
		
		private void detach_Registries(Registry entity)
		{
			this.SendPropertyChanging();
			entity.Username1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Registry : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private ushort _Event;
		
		private string _WindowTitle;
		
		private string _ExeModulePath;
		
		private string _ProcessName;
		
		private System.DateTime _Time;
		
		private System.Nullable<long> _Ip;
		
		private System.Nullable<long> _Mac;
		
		private System.Nullable<long> _Username;
		
		private string _WindowId;
		
		private System.Nullable<bool> _Processed;
		
		private string _Url;
		
		private EntityRef<IpAddress> _IpAddress;
		
		private EntityRef<MacAddress> _MacAddress;
		
		private EntityRef<Username> _Username1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnEventChanging(ushort value);
    partial void OnEventChanged();
    partial void OnWindowTitleChanging(string value);
    partial void OnWindowTitleChanged();
    partial void OnExeModulePathChanging(string value);
    partial void OnExeModulePathChanged();
    partial void OnProcessNameChanging(string value);
    partial void OnProcessNameChanged();
    partial void OnTimeChanging(System.DateTime value);
    partial void OnTimeChanged();
    partial void OnIpChanging(System.Nullable<long> value);
    partial void OnIpChanged();
    partial void OnMacChanging(System.Nullable<long> value);
    partial void OnMacChanged();
    partial void OnUsernameChanging(System.Nullable<long> value);
    partial void OnUsernameChanged();
    partial void OnWindowIdChanging(string value);
    partial void OnWindowIdChanged();
    partial void OnProcessedChanging(System.Nullable<bool> value);
    partial void OnProcessedChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    #endregion
		
		public Registry()
		{
			this._IpAddress = default(EntityRef<IpAddress>);
			this._MacAddress = default(EntityRef<MacAddress>);
			this._Username1 = default(EntityRef<Username>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Event")]
		public ushort Event
		{
			get
			{
				return this._Event;
			}
			set
			{
				if ((this._Event != value))
				{
					this.OnEventChanging(value);
					this.SendPropertyChanging();
					this._Event = value;
					this.SendPropertyChanged("Event");
					this.OnEventChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WindowTitle")]
		public string WindowTitle
		{
			get
			{
				return this._WindowTitle;
			}
			set
			{
				if ((this._WindowTitle != value))
				{
					this.OnWindowTitleChanging(value);
					this.SendPropertyChanging();
					this._WindowTitle = value;
					this.SendPropertyChanged("WindowTitle");
					this.OnWindowTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExeModulePath")]
		public string ExeModulePath
		{
			get
			{
				return this._ExeModulePath;
			}
			set
			{
				if ((this._ExeModulePath != value))
				{
					this.OnExeModulePathChanging(value);
					this.SendPropertyChanging();
					this._ExeModulePath = value;
					this.SendPropertyChanged("ExeModulePath");
					this.OnExeModulePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProcessName")]
		public string ProcessName
		{
			get
			{
				return this._ProcessName;
			}
			set
			{
				if ((this._ProcessName != value))
				{
					this.OnProcessNameChanging(value);
					this.SendPropertyChanging();
					this._ProcessName = value;
					this.SendPropertyChanged("ProcessName");
					this.OnProcessNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time")]
		public System.DateTime Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ip")]
		public System.Nullable<long> Ip
		{
			get
			{
				return this._Ip;
			}
			set
			{
				if ((this._Ip != value))
				{
					if (this._IpAddress.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIpChanging(value);
					this.SendPropertyChanging();
					this._Ip = value;
					this.SendPropertyChanged("Ip");
					this.OnIpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mac")]
		public System.Nullable<long> Mac
		{
			get
			{
				return this._Mac;
			}
			set
			{
				if ((this._Mac != value))
				{
					if (this._MacAddress.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMacChanging(value);
					this.SendPropertyChanging();
					this._Mac = value;
					this.SendPropertyChanged("Mac");
					this.OnMacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username")]
		public System.Nullable<long> Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					if (this._Username1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WindowId")]
		public string WindowId
		{
			get
			{
				return this._WindowId;
			}
			set
			{
				if ((this._WindowId != value))
				{
					this.OnWindowIdChanging(value);
					this.SendPropertyChanging();
					this._WindowId = value;
					this.SendPropertyChanged("WindowId");
					this.OnWindowIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Processed")]
		public System.Nullable<bool> Processed
		{
			get
			{
				return this._Processed;
			}
			set
			{
				if ((this._Processed != value))
				{
					this.OnProcessedChanging(value);
					this.SendPropertyChanging();
					this._Processed = value;
					this.SendPropertyChanged("Processed");
					this.OnProcessedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url")]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IpAddress_Registry", Storage="_IpAddress", ThisKey="Ip", OtherKey="Id", IsForeignKey=true)]
		public IpAddress IpAddress
		{
			get
			{
				return this._IpAddress.Entity;
			}
			set
			{
				IpAddress previousValue = this._IpAddress.Entity;
				if (((previousValue != value) 
							|| (this._IpAddress.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._IpAddress.Entity = null;
						previousValue.Registries.Remove(this);
					}
					this._IpAddress.Entity = value;
					if ((value != null))
					{
						value.Registries.Add(this);
						this._Ip = value.Id;
					}
					else
					{
						this._Ip = default(Nullable<long>);
					}
					this.SendPropertyChanged("IpAddress");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MacAddress_Registry", Storage="_MacAddress", ThisKey="Mac", OtherKey="Id", IsForeignKey=true)]
		public MacAddress MacAddress
		{
			get
			{
				return this._MacAddress.Entity;
			}
			set
			{
				MacAddress previousValue = this._MacAddress.Entity;
				if (((previousValue != value) 
							|| (this._MacAddress.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MacAddress.Entity = null;
						previousValue.Registries.Remove(this);
					}
					this._MacAddress.Entity = value;
					if ((value != null))
					{
						value.Registries.Add(this);
						this._Mac = value.Id;
					}
					else
					{
						this._Mac = default(Nullable<long>);
					}
					this.SendPropertyChanged("MacAddress");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Username_Registry", Storage="_Username1", ThisKey="Username", OtherKey="Id", IsForeignKey=true)]
		public Username Username1
		{
			get
			{
				return this._Username1.Entity;
			}
			set
			{
				Username previousValue = this._Username1.Entity;
				if (((previousValue != value) 
							|| (this._Username1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Username1.Entity = null;
						previousValue.Registries.Remove(this);
					}
					this._Username1.Entity = value;
					if ((value != null))
					{
						value.Registries.Add(this);
						this._Username = value.Id;
					}
					else
					{
						this._Username = default(Nullable<long>);
					}
					this.SendPropertyChanged("Username1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class ActivitiesRegistry : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Json;
		
		private System.Nullable<bool> _Transmitted;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnJsonChanging(string value);
    partial void OnJsonChanged();
    partial void OnTransmittedChanging(System.Nullable<bool> value);
    partial void OnTransmittedChanged();
    #endregion
		
		public ActivitiesRegistry()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Json")]
		public string Json
		{
			get
			{
				return this._Json;
			}
			set
			{
				if ((this._Json != value))
				{
					this.OnJsonChanging(value);
					this.SendPropertyChanging();
					this._Json = value;
					this.SendPropertyChanged("Json");
					this.OnJsonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transmitted")]
		public System.Nullable<bool> Transmitted
		{
			get
			{
				return this._Transmitted;
			}
			set
			{
				if ((this._Transmitted != value))
				{
					this.OnTransmittedChanging(value);
					this.SendPropertyChanging();
					this._Transmitted = value;
					this.SendPropertyChanged("Transmitted");
					this.OnTransmittedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
