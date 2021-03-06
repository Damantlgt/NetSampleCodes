//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Address.cs'.
//
//     Template path: EditableRoot.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CFMData
{
    [Serializable]
    public partial class Address 
    {
        #region Contructor(s)

        public Address()
        { /* Require use of factory methods */ }

        #endregion

			public Address  Save()
      {
        if (this.IsNew)
        {
            DataPortal_Insert();
			this.IsNew=false;
        }
        else
        {
            DataPortal_Update();
        }

        return this;
      }
	  
			public bool IsDirty=false;
			public bool IsNew=true;
			#region Properties
		
			private AddressDTO _currentDto = null;
			public AddressDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _addressIDProperty  ;
			public System.Int32 AddressID
			{
				get { return _addressIDProperty; }
				set
				{ 
                 
					if (_addressIDProperty != value){
						IsDirty = true;
					}
					_addressIDProperty=value; 
				}
			}

			private System.String _streetProperty  = null;
			public System.String Street
			{
				get { return _streetProperty; }
				set
				{ 
                 
					if (_streetProperty != value){
						IsDirty = true;
					}
					_streetProperty=value; 
				}
			}

			private System.String _suburbProperty  = null;
			public System.String Suburb
			{
				get { return _suburbProperty; }
				set
				{ 
                 
					if (_suburbProperty != value){
						IsDirty = true;
					}
					_suburbProperty=value; 
				}
			}

			private System.Int32? _stateIDProperty  = null;
			public System.Int32? StateID
			{
				get { return _stateIDProperty; }
				set
				{ 
                 
					if (_stateIDProperty != value){
						IsDirty = true;
					}
					_stateIDProperty=value; 
				}
			}

			private System.Int32? _countryIDProperty  = null;
			public System.Int32? CountryID
			{
				get { return _countryIDProperty; }
				set
				{ 
                 
					if (_countryIDProperty != value){
						IsDirty = true;
					}
					_countryIDProperty=value; 
				}
			}

			private System.String _postCodeProperty  = null;
			public System.String PostCode
			{
				get { return _postCodeProperty; }
				set
				{ 
                 
					if (_postCodeProperty != value){
						IsDirty = true;
					}
					_postCodeProperty=value; 
				}
			}

			private System.Boolean _isActiveProperty  ;
			public System.Boolean IsActive
			{
				get { return _isActiveProperty; }
				set
				{ 
                 
					if (_isActiveProperty != value){
						IsDirty = true;
					}
					_isActiveProperty=value; 
				}
			}

			private System.Int32 _createdByProperty  ;
			public System.Int32 CreatedBy
			{
				get { return _createdByProperty; }
				set
				{ 
                 
					if (_createdByProperty != value){
						IsDirty = true;
					}
					_createdByProperty=value; 
				}
			}

			private System.DateTime _createdOnProperty  ;
			public System.DateTime CreatedOn
			{
				get { return _createdOnProperty; }
				set
				{ 
                 
					if (_createdOnProperty != value){
						IsDirty = true;
					}
					_createdOnProperty=value; 
				}
			}

			private System.Int32? _updatedByProperty  = null;
			public System.Int32? UpdatedBy
			{
				get { return _updatedByProperty; }
				set
				{ 
                 
					if (_updatedByProperty != value){
						IsDirty = true;
					}
					_updatedByProperty=value; 
				}
			}

			private System.DateTime? _updatedOnProperty  = null;
			public System.DateTime? UpdatedOn
			{
				get { return _updatedOnProperty; }
				set
				{ 
                 
					if (_updatedOnProperty != value){
						IsDirty = true;
					}
					_updatedOnProperty=value; 
				}
			}

			// ManyToOne
			private bool _createdByApplicationUserPropertyChecked = false;
			private ApplicationUser _createdByApplicationUserProperty = null;
			public ApplicationUser CreatedByApplicationUser
			{
				get
				{
					if(!_createdByApplicationUserPropertyChecked)
					{						
						var criteria = new CFMData.ApplicationUserCriteria {ApplicationUserID = CreatedBy};
						
						_createdByApplicationUserPropertyChecked=true;                       
						_createdByApplicationUserProperty= CFMData.ApplicationUser.GetByApplicationUserID(CreatedBy);
					}                
					return _createdByApplicationUserProperty;
				}
			}

			// ManyToZeroOrOne
			private bool _updatedByApplicationUserPropertyChecked = false;
			private ApplicationUser _updatedByApplicationUserProperty = null;
			public ApplicationUser UpdatedByApplicationUser
			{
				get
				{
                    if(!UpdatedBy.HasValue) 
					return null;

					if(!_updatedByApplicationUserPropertyChecked)
					{						
						var criteria = new CFMData.ApplicationUserCriteria {};
						if(UpdatedBy.HasValue) criteria.ApplicationUserID = UpdatedBy.Value;
						_updatedByApplicationUserPropertyChecked=true;                       
						_updatedByApplicationUserProperty= CFMData.ApplicationUser.GetByApplicationUserID(UpdatedBy.Value);
					}                
					return _updatedByApplicationUserProperty;
				}
			}

			// ManyToZeroOrOne
			private bool _stateDataOptionPropertyChecked = false;
			private DataOption _stateDataOptionProperty = null;
			public DataOption StateDataOption
			{
				get
				{
                    if(!StateID.HasValue) 
					return null;

					if(!_stateDataOptionPropertyChecked)
					{						
						var criteria = new CFMData.DataOptionCriteria {};
						if(StateID.HasValue) criteria.DataOptionID = StateID.Value;
						_stateDataOptionPropertyChecked=true;                       
						_stateDataOptionProperty= CFMData.DataOption.GetByDataOptionID(StateID.Value);
					}                
					return _stateDataOptionProperty;
				}
			}

			// ManyToZeroOrOne
			private bool _countryDataOptionPropertyChecked = false;
			private DataOption _countryDataOptionProperty = null;
			public DataOption CountryDataOption
			{
				get
				{
                    if(!CountryID.HasValue) 
					return null;

					if(!_countryDataOptionPropertyChecked)
					{						
						var criteria = new CFMData.DataOptionCriteria {};
						if(CountryID.HasValue) criteria.DataOptionID = CountryID.Value;
						_countryDataOptionPropertyChecked=true;                       
						_countryDataOptionProperty= CFMData.DataOption.GetByDataOptionID(CountryID.Value);
					}                
					return _countryDataOptionProperty;
				}
			}

			// ZeroOrOneToMany
			//PropertyInfo<ApplicationUserList>
			private bool _physicalAddressApplicationUsersPropertyChecked = false;
			private ApplicationUserList _physicalAddressApplicationUsersProperty = null;
			public ApplicationUserList PhysicalAddressApplicationUsers
			{
				get
				{
					if(!_physicalAddressApplicationUsersPropertyChecked )
					{
						_physicalAddressApplicationUsersPropertyChecked =true; 
						var criteria = new CFMData.ApplicationUserCriteria {PhysicalAddressID = AddressID};
						                        
						_physicalAddressApplicationUsersProperty= CFMData.ApplicationUserList.GetByPhysicalAddressID(AddressID);
 
					}
					return _physicalAddressApplicationUsersProperty;
				}
			}

			// ZeroOrOneToMany
			//PropertyInfo<ApplicationUserList>
			private bool _postalAddressApplicationUsersPropertyChecked = false;
			private ApplicationUserList _postalAddressApplicationUsersProperty = null;
			public ApplicationUserList PostalAddressApplicationUsers
			{
				get
				{
					if(!_postalAddressApplicationUsersPropertyChecked )
					{
						_postalAddressApplicationUsersPropertyChecked =true; 
						var criteria = new CFMData.ApplicationUserCriteria {PostalAddressID = AddressID};
						                        
						_postalAddressApplicationUsersProperty= CFMData.ApplicationUserList.GetByPostalAddressID(AddressID);
 
					}
					return _postalAddressApplicationUsersProperty;
				}
			}

			// ZeroOrOneToMany
			//PropertyInfo<ClientList>
			private bool _clientsPropertyChecked = false;
			private ClientList _clientsProperty = null;
			public ClientList Clients
			{
				get
				{
					if(!_clientsPropertyChecked )
					{
						_clientsPropertyChecked =true; 
						var criteria = new CFMData.ClientCriteria {AddressID = AddressID};
						                        
						_clientsProperty= CFMData.ClientList.GetByAddressID(AddressID);
 
					}
					return _clientsProperty;
				}
			}

			// ZeroOrOneToMany
			//PropertyInfo<FinAdministratorList>
			private bool _finAdministratorsPropertyChecked = false;
			private FinAdministratorList _finAdministratorsProperty = null;
			public FinAdministratorList FinAdministrators
			{
				get
				{
					if(!_finAdministratorsPropertyChecked )
					{
						_finAdministratorsPropertyChecked =true; 
						var criteria = new CFMData.FinAdministratorCriteria {AddressID = AddressID};
						                        
						_finAdministratorsProperty= CFMData.FinAdministratorList.GetByAddressID(AddressID);
 
					}
					return _finAdministratorsProperty;
				}
			}


        #endregion
		public bool IsChildDirty()
		{
		
		
			 
			if(_physicalAddressApplicationUsersPropertyChecked)
			{
					if(_physicalAddressApplicationUsersProperty != null)
					{
						foreach (ApplicationUser childObj in _physicalAddressApplicationUsersProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 

			 
			if(_postalAddressApplicationUsersPropertyChecked)
			{
					if(_postalAddressApplicationUsersProperty != null)
					{
						foreach (ApplicationUser childObj in _postalAddressApplicationUsersProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 

			 
			if(_clientsPropertyChecked)
			{
					if(_clientsProperty != null)
					{
						foreach (Client childObj in _clientsProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 

			 
			if(_finAdministratorsPropertyChecked)
			{
					if(_finAdministratorsProperty != null)
					{
						foreach (FinAdministrator childObj in _finAdministratorsProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 



			return false;
		}

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="Address"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="Address"/>.</returns>    
        public static Address NewAddress()
        {
            Address obj=new Address();

            return obj;
        }

			public static Address GetAddress(Func<IDataReader, Address> rowParser,SqlDataReader reader)
			{
				Address obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="Address"/> object of the specified criteria. 
        /// </summary>
        /// <param name="addressID">No additional detail available.</param>
        /// <returns>A <see cref="Address"/> object of the specified criteria.</returns>
        public static Address GetByAddressID(System.Int32 addressID)
        {
            var criteria = new AddressCriteria {AddressID = addressID};
            
            
          return  new Address().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="Address"/> object of the specified criteria. 
        /// </summary>
        /// <param name="createdBy">No additional detail available.</param>
        /// <returns>A <see cref="Address"/> object of the specified criteria.</returns>
        public static Address GetByCreatedBy(System.Int32 createdBy)
        {
            var criteria = new AddressCriteria {CreatedBy = createdBy};
            
            
          return  new Address().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="Address"/> object of the specified criteria. 
        /// </summary>
        /// <param name="updatedBy">No additional detail available.</param>
        /// <returns>A <see cref="Address"/> object of the specified criteria.</returns>
        public static Address GetByUpdatedBy(System.Int32? updatedBy)
        {
            var criteria = new AddressCriteria {};
                            if(updatedBy.HasValue) criteria.UpdatedBy = updatedBy.Value;
            
          return  new Address().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="Address"/> object of the specified criteria. 
        /// </summary>
        /// <param name="stateID">No additional detail available.</param>
        /// <returns>A <see cref="Address"/> object of the specified criteria.</returns>
        public static Address GetByStateID(System.Int32? stateID)
        {
            var criteria = new AddressCriteria {};
                            if(stateID.HasValue) criteria.StateID = stateID.Value;
            
          return  new Address().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="Address"/> object of the specified criteria. 
        /// </summary>
        /// <param name="countryID">No additional detail available.</param>
        /// <returns>A <see cref="Address"/> object of the specified criteria.</returns>
        public static Address GetByCountryID(System.Int32? countryID)
        {
            var criteria = new AddressCriteria {};
                            if(countryID.HasValue) criteria.CountryID = countryID.Value;
            
          return  new Address().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteAddress(System.Int32 addressID)
        {
            var criteria = new AddressCriteria {AddressID = addressID};
            
            
             new Address().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Address"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="Address"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="AddressCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(AddressCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Address"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="Address"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Address"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Address"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Address"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Address"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="Address"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="AddressCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(AddressCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Address"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Address"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="AddressCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(AddressCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Address"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Address"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="Address"/> object. 
        /// </summary>
        partial void OnChildInserting(ApplicationUser applicationUser, DataOption dataOption, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Address"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="Address"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildUpdating(ApplicationUser applicationUser, DataOption dataOption, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Address"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Address"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="AddressCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(AddressCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="Address"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="AddressCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(AddressCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Address"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the Address table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="Address"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static Address Exists(AddressCriteria criteria)
        {
			try
			{
					
				return new Address().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}