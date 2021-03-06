//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Address.cs'.
//
//     Template: EditableRoot.DataAccess.StoredProcedures.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
 using Dapper;

namespace CFMData
{
	public partial class Address
	{
    
		private Address DataPortal_Fetch(AddressCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_Address_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_StreetHasValue", criteria.StreetHasValue);
                command.Parameters.AddWithValue("@p_SuburbHasValue", criteria.SuburbHasValue);
                command.Parameters.AddWithValue("@p_StateIDHasValue", criteria.StateIDHasValue);
                command.Parameters.AddWithValue("@p_CountryIDHasValue", criteria.CountryIDHasValue);
                command.Parameters.AddWithValue("@p_PostCodeHasValue", criteria.PostCodeHasValue);
                command.Parameters.AddWithValue("@p_UpdatedByHasValue", criteria.UpdatedByHasValue);
                command.Parameters.AddWithValue("@p_UpdatedOnHasValue", criteria.UpdatedOnHasValue);
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<Address>();                       
						if(reader.Read())
						{
							return GetAddress(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.Address' using the following criteria: {0}.", criteria));
					}
				}
			}
			OnFetched();
		}

       // [Transactional(TransactionalTypes.TransactionScope)]
		protected   void DataPortal_Insert()
		{
			bool cancel = false;
			OnInserting(ref cancel);
			if (cancel) return;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				SqlTransaction trans = connection.BeginTransaction();
				try
				{
				
				using(var command = new SqlCommand("[dbo].[spCFM_Address_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
          command.Parameters.AddWithValue("@p_AddressID", this.AddressID);
                command.Parameters["@p_AddressID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_Street", ADOHelper.NullCheck(this.Street));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_StateID", ADOHelper.NullCheck(this.StateID));
                command.Parameters.AddWithValue("@p_CountryID", ADOHelper.NullCheck(this.CountryID));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));
					command.ExecuteNonQuery();                  
					_addressIDProperty=(System.Int32)command.Parameters["@p_AddressID"].Value;
                    
				}
                
				UpdateChildren(this, connection,trans);
				
				trans.Commit();
			}
			catch(Exception ex)
			{
				trans.Rollback();
				throw;
			}
			
		}
			

			OnInserted();

		}

       // [Transactional(TransactionalTypes.TransactionScope)]
		protected   void DataPortal_Update()
		{
			bool cancel = false;
			OnUpdating(ref cancel);
			if (cancel) return;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				SqlTransaction trans = connection.BeginTransaction();
				try
				{
				using(var command = new SqlCommand("[dbo].[spCFM_Address_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_AddressID", this.AddressID);
                command.Parameters.AddWithValue("@p_Street", ADOHelper.NullCheck(this.Street));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_StateID", ADOHelper.NullCheck(this.StateID));
                command.Parameters.AddWithValue("@p_CountryID", ADOHelper.NullCheck(this.CountryID));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));
					//result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
					int result = command.ExecuteNonQuery();
					if (result == 0)
						throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

				}
				UpdateChildren(this, connection,trans);
				//FieldManager.UpdateChildren(this, connection);
				trans.Commit();
			}
			catch(Exception ex)
			{
				trans.Rollback();
				throw;
			}
			
		}

			OnUpdated();
		}
		protected   void UpdateChildren(Address parent,SqlConnection connection,SqlTransaction trans)
		{
		
		
			
			if(_physicalAddressApplicationUsersPropertyChecked )
			{
				if(_physicalAddressApplicationUsersProperty!=null)
				{
				
					foreach (ApplicationUser obj in _physicalAddressApplicationUsersProperty)
					{
						if (obj.IsNew)
						{
							obj.Child_Insert(parent, connection,trans);
						}
						else
						{
							if (obj.IsDirty ||  obj.IsChildDirty())
							{							
								obj.Child_Update(parent, connection,trans);
							}
						}
					}
				}
					
 
			}

			
			if(_postalAddressApplicationUsersPropertyChecked )
			{
				if(_postalAddressApplicationUsersProperty!=null)
				{
				
					foreach (ApplicationUser obj in _postalAddressApplicationUsersProperty)
					{
						if (obj.IsNew)
						{
							obj.Child_Insert(parent, connection,trans);
						}
						else
						{
							if (obj.IsDirty ||  obj.IsChildDirty())
							{							
								obj.Child_Update(parent, connection,trans);
							}
						}
					}
				}
					
 
			}

			
			if(_clientsPropertyChecked )
			{
				if(_clientsProperty!=null)
				{
				
					foreach (Client obj in _clientsProperty)
					{
						if (obj.IsNew)
						{
							obj.Child_Insert(parent, connection,trans);
						}
						else
						{
							if (obj.IsDirty ||  obj.IsChildDirty())
							{							
								obj.Child_Update(parent, connection,trans);
							}
						}
					}
				}
					
 
			}

			
			if(_finAdministratorsPropertyChecked )
			{
				if(_finAdministratorsProperty!=null)
				{
				
					foreach (FinAdministrator obj in _finAdministratorsProperty)
					{
						if (obj.IsNew)
						{
							obj.Child_Insert(parent, connection,trans);
						}
						else
						{
							if (obj.IsDirty ||  obj.IsChildDirty())
							{							
								obj.Child_Update(parent, connection,trans);
							}
						}
					}
				}
					
 
			}


		}

		protected   void DataPortal_DeleteSelf()
		{
			bool cancel = false;
			OnSelfDeleting(ref cancel);
			if (cancel) return;            
			DataPortal_Delete(new AddressCriteria (AddressID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(AddressCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_Address_Delete]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
		
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
		}
		
		 #region Child_Insert
        /// <summary>
        /// Inserts data into the data base using the information in the current 
        ///    CSLA editable child business object of type <see cref="Address"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_Address_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_AddressID", this.AddressID);
                command.Parameters["@p_AddressID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_Street", ADOHelper.NullCheck(this.Street));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_StateID", ADOHelper.NullCheck(this.StateID));
                command.Parameters.AddWithValue("@p_CountryID", ADOHelper.NullCheck(this.CountryID));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _addressIDProperty=(System.Int32)command.Parameters["@p_AddressID"].Value;
            }

            UpdateChildren(this, connection,trans);

            OnChildInserted();
        }

        public void Child_Insert(ApplicationUser applicationUser, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(applicationUser, null, connection,trans);
        }


        public void Child_Insert(DataOption dataOption, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, dataOption, connection,trans);
        }


        public void Child_Insert(ApplicationUser applicationUser, DataOption dataOption, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(applicationUser, dataOption, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_Address_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_AddressID", this.AddressID);
                command.Parameters["@p_AddressID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_Street", ADOHelper.NullCheck(this.Street));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_StateID", ADOHelper.NullCheck(dataOption != null ? dataOption.DataOptionID : this.StateID));
                command.Parameters.AddWithValue("@p_CountryID", ADOHelper.NullCheck(dataOption != null ? dataOption.DataOptionID : this.CountryID));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", applicationUser != null ? applicationUser.ApplicationUserID : this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _addressIDProperty=(System.Int32)command.Parameters["@p_AddressID"].Value;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(dataOption != null && dataOption.DataOptionID != this.StateID)
                _stateIDProperty= dataOption.DataOptionID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(dataOption != null && dataOption.DataOptionID != this.CountryID)
                _countryIDProperty= dataOption.DataOptionID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(applicationUser != null && applicationUser.ApplicationUserID != this.CreatedBy)
                _createdByProperty= applicationUser.ApplicationUserID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(applicationUser != null && applicationUser.ApplicationUserID != this.UpdatedBy)
                _updatedByProperty= applicationUser.ApplicationUserID;
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildInserted() and insert this child manually.
            // UpdateChildren(this, connection);

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        /// <summary>
        /// Updates the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="Address"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_Address_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_AddressID", this.AddressID);
                command.Parameters.AddWithValue("@p_Street", ADOHelper.NullCheck(this.Street));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_StateID", ADOHelper.NullCheck(this.StateID));
                command.Parameters.AddWithValue("@p_CountryID", ADOHelper.NullCheck(this.CountryID));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            UpdateChildren(this, connection,trans);

            OnChildUpdated();
        }

        public void Child_Update(ApplicationUser applicationUser, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(applicationUser, null, connection,trans);
        }


        public void Child_Update(DataOption dataOption, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, dataOption, connection,trans);
        }

 
        public void Child_Update(ApplicationUser applicationUser, DataOption dataOption, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(applicationUser, dataOption, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_Address_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_AddressID", this.AddressID);
                command.Parameters.AddWithValue("@p_Street", ADOHelper.NullCheck(this.Street));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_StateID", ADOHelper.NullCheck(dataOption != null ? dataOption.DataOptionID : this.StateID));
                command.Parameters.AddWithValue("@p_CountryID", ADOHelper.NullCheck(dataOption != null ? dataOption.DataOptionID : this.CountryID));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", applicationUser != null ? applicationUser.ApplicationUserID : this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(dataOption != null && dataOption.DataOptionID != this.StateID)
                    _stateIDProperty= dataOption.DataOptionID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(dataOption != null && dataOption.DataOptionID != this.CountryID)
                    _countryIDProperty= dataOption.DataOptionID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(applicationUser != null && applicationUser.ApplicationUserID != this.CreatedBy)
                    _createdByProperty= applicationUser.ApplicationUserID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(applicationUser != null && applicationUser.ApplicationUserID != this.UpdatedBy)
                    _updatedByProperty= applicationUser.ApplicationUserID;
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildUpdated() and update this child manually.
            // UpdateChildren(this, connection);

            OnChildUpdated();
        }
        #endregion

        /// <summary>
        /// Deletes the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="Address"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new AddressCriteria (AddressID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  AddressDTO dt=new AddressDTO();
			dt.AddressID =this.AddressID ;
			dt.Street =this.Street ;
			dt.Suburb =this.Suburb ;
			dt.StateID =this.StateID ;
			dt.CountryID =this.CountryID ;
			dt.PostCode =this.PostCode ;
			dt.IsActive =this.IsActive ;
			dt.CreatedBy =this.CreatedBy ;
			dt.CreatedOn =this.CreatedOn ;
			dt.UpdatedBy =this.UpdatedBy ;
			dt.UpdatedOn =this.UpdatedOn ;
   //LoadProperty(_currentDto, dt);
  this.CurrentDTO = dt;

		}
		/*
        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_addressIDProperty, reader["AddressID"]);
                LoadProperty(_streetProperty, reader["Street"]);
                LoadProperty(_suburbProperty, reader["Suburb"]);
                LoadProperty(_stateIDProperty, reader["StateID"]);
                LoadProperty(_countryIDProperty, reader["CountryID"]);
                LoadProperty(_postCodeProperty, reader["PostCode"]);
                LoadProperty(_isActiveProperty, reader["IsActive"]);
                LoadProperty(_createdByProperty, reader["CreatedBy"]);
                LoadProperty(_createdOnProperty, reader["CreatedOn"]);
                LoadProperty(_updatedByProperty, reader["UpdatedBy"]);
                LoadProperty(_updatedOnProperty, reader["UpdatedOn"]);
            }	
			InitDTO();
            OnMapped();
        }
        
        private void Child_Fetch(SafeDataReader reader)
        {
            Map(reader);
        }
		*/

        #endregion
	}
}
 