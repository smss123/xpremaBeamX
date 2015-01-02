﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XBeamDataLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="xpremaBeam")]
	public partial class dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCountry(Country instance);
    partial void UpdateCountry(Country instance);
    partial void DeleteCountry(Country instance);
    partial void InsertWhatsAppNumber(WhatsAppNumber instance);
    partial void UpdateWhatsAppNumber(WhatsAppNumber instance);
    partial void DeleteWhatsAppNumber(WhatsAppNumber instance);
    #endregion
		
		public dbDataContext() : 
				base(global::XBeamDataLayer.Properties.Settings.Default.xpremaBeamConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Country> Countries
		{
			get
			{
				return this.GetTable<Country>();
			}
		}
		
		public System.Data.Linq.Table<WhatsAppNumber> WhatsAppNumbers
		{
			get
			{
				return this.GetTable<WhatsAppNumber>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="WhatsPhone.Country")]
	public partial class Country : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CountryName;
		
		private int _ID;
		
		private EntitySet<WhatsAppNumber> _WhatsAppNumbers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCountryNameChanging(string value);
    partial void OnCountryNameChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public Country()
		{
			this._WhatsAppNumbers = new EntitySet<WhatsAppNumber>(new Action<WhatsAppNumber>(this.attach_WhatsAppNumbers), new Action<WhatsAppNumber>(this.detach_WhatsAppNumbers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryName", DbType="NVarChar(50)")]
		public string CountryName
		{
			get
			{
				return this._CountryName;
			}
			set
			{
				if ((this._CountryName != value))
				{
					this.OnCountryNameChanging(value);
					this.SendPropertyChanging();
					this._CountryName = value;
					this.SendPropertyChanged("CountryName");
					this.OnCountryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Country_WhatsAppNumber", Storage="_WhatsAppNumbers", ThisKey="ID", OtherKey="CountryID")]
		public EntitySet<WhatsAppNumber> WhatsAppNumbers
		{
			get
			{
				return this._WhatsAppNumbers;
			}
			set
			{
				this._WhatsAppNumbers.Assign(value);
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
		
		private void attach_WhatsAppNumbers(WhatsAppNumber entity)
		{
			this.SendPropertyChanging();
			entity.Country = this;
		}
		
		private void detach_WhatsAppNumbers(WhatsAppNumber entity)
		{
			this.SendPropertyChanging();
			entity.Country = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="WhatsPhone.WhatsAppNumber")]
	public partial class WhatsAppNumber : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<System.Guid> _SerialNumber;
		
		private string _PhoneNumber;
		
		private string _ContactName;
		
		private string _WhatsAppStatus;
		
		private string _CurrentStatus;
		
		private System.Nullable<int> _CountryID;
		
		private EntityRef<Country> _Country;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSerialNumberChanging(System.Nullable<System.Guid> value);
    partial void OnSerialNumberChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnContactNameChanging(string value);
    partial void OnContactNameChanged();
    partial void OnWhatsAppStatusChanging(string value);
    partial void OnWhatsAppStatusChanged();
    partial void OnCurrentStatusChanging(string value);
    partial void OnCurrentStatusChanged();
    partial void OnCountryIDChanging(System.Nullable<int> value);
    partial void OnCountryIDChanged();
    #endregion
		
		public WhatsAppNumber()
		{
			this._Country = default(EntityRef<Country>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumber", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				if ((this._SerialNumber != value))
				{
					this.OnSerialNumberChanging(value);
					this.SendPropertyChanging();
					this._SerialNumber = value;
					this.SendPropertyChanged("SerialNumber");
					this.OnSerialNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactName", DbType="NVarChar(50)")]
		public string ContactName
		{
			get
			{
				return this._ContactName;
			}
			set
			{
				if ((this._ContactName != value))
				{
					this.OnContactNameChanging(value);
					this.SendPropertyChanging();
					this._ContactName = value;
					this.SendPropertyChanged("ContactName");
					this.OnContactNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WhatsAppStatus", DbType="NVarChar(500)")]
		public string WhatsAppStatus
		{
			get
			{
				return this._WhatsAppStatus;
			}
			set
			{
				if ((this._WhatsAppStatus != value))
				{
					this.OnWhatsAppStatusChanging(value);
					this.SendPropertyChanging();
					this._WhatsAppStatus = value;
					this.SendPropertyChanged("WhatsAppStatus");
					this.OnWhatsAppStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentStatus", DbType="NVarChar(50)")]
		public string CurrentStatus
		{
			get
			{
				return this._CurrentStatus;
			}
			set
			{
				if ((this._CurrentStatus != value))
				{
					this.OnCurrentStatusChanging(value);
					this.SendPropertyChanging();
					this._CurrentStatus = value;
					this.SendPropertyChanged("CurrentStatus");
					this.OnCurrentStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryID", DbType="Int")]
		public System.Nullable<int> CountryID
		{
			get
			{
				return this._CountryID;
			}
			set
			{
				if ((this._CountryID != value))
				{
					if (this._Country.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCountryIDChanging(value);
					this.SendPropertyChanging();
					this._CountryID = value;
					this.SendPropertyChanged("CountryID");
					this.OnCountryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Country_WhatsAppNumber", Storage="_Country", ThisKey="CountryID", OtherKey="ID", IsForeignKey=true, DeleteRule="CASCADE")]
		public Country Country
		{
			get
			{
				return this._Country.Entity;
			}
			set
			{
				Country previousValue = this._Country.Entity;
				if (((previousValue != value) 
							|| (this._Country.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Country.Entity = null;
						previousValue.WhatsAppNumbers.Remove(this);
					}
					this._Country.Entity = value;
					if ((value != null))
					{
						value.WhatsAppNumbers.Add(this);
						this._CountryID = value.ID;
					}
					else
					{
						this._CountryID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Country");
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
