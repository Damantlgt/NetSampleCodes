//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Home.cs'.
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
	public partial class Home
	{
    
		private Home DataPortal_Fetch(HomeCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_Home_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_AddressIDHasValue", criteria.AddressIDHasValue);
                command.Parameters.AddWithValue("@p_UpdatedByHasValue", criteria.UpdatedByHasValue);
                command.Parameters.AddWithValue("@p_UpdatedOnHasValue", criteria.UpdatedOnHasValue);
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<Home>();                       
						if(reader.Read())
						{
							return GetHome(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.Home' using the following criteria: {0}.", criteria));
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
				
				using(var command = new SqlCommand("[dbo].[spCFM_Home_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
          command.Parameters.AddWithValue("@p_HomeID", this.HomeID);
                command.Parameters["@p_HomeID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_GLEntityID", this.GLEntityID);
                command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_HomeCostCentreCode", this.HomeCostCentreCode);
                command.Parameters.AddWithValue("@p_HomeName", this.HomeName);
                command.Parameters.AddWithValue("@p_Parcel", this.Parcel);
                command.Parameters.AddWithValue("@p_SILTarget", this.SILTarget);
                command.Parameters.AddWithValue("@p_NoofBeds", this.NoofBeds);
                command.Parameters.AddWithValue("@p_AccommodationTypeId", this.AccommodationTypeId);
                command.Parameters.AddWithValue("@p_isGST", this.IsGST);
                command.Parameters.AddWithValue("@p_AddressID", ADOHelper.NullCheck(this.AddressID));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));
					command.ExecuteNonQuery();                  
					_homeIDProperty=(System.Int32)command.Parameters["@p_HomeID"].Value;
                    
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
				using(var command = new SqlCommand("[dbo].[spCFM_Home_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_HomeID", this.HomeID);
                command.Parameters.AddWithValue("@p_GLEntityID", this.GLEntityID);
                command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_HomeCostCentreCode", this.HomeCostCentreCode);
                command.Parameters.AddWithValue("@p_HomeName", this.HomeName);
                command.Parameters.AddWithValue("@p_Parcel", this.Parcel);
                command.Parameters.AddWithValue("@p_SILTarget", this.SILTarget);
                command.Parameters.AddWithValue("@p_NoofBeds", this.NoofBeds);
                command.Parameters.AddWithValue("@p_AccommodationTypeId", this.AccommodationTypeId);
                command.Parameters.AddWithValue("@p_isGST", this.IsGST);
                command.Parameters.AddWithValue("@p_AddressID", ADOHelper.NullCheck(this.AddressID));
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
		protected   void UpdateChildren(Home parent,SqlConnection connection,SqlTransaction trans)
		{
		
		
			
			if(_applicationPermissionsPropertyChecked )
			{
				if(_applicationPermissionsProperty!=null)
				{
				
					foreach (ApplicationPermission obj in _applicationPermissionsProperty)
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

			
			if(_budgetsPropertyChecked )
			{
				if(_budgetsProperty!=null)
				{
				
					foreach (Budget obj in _budgetsProperty)
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

			
			if(_homeClientsPropertyChecked )
			{
				if(_homeClientsProperty!=null)
				{
				
					foreach (HomeClient obj in _homeClientsProperty)
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
			DataPortal_Delete(new HomeCriteria (HomeID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(HomeCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_Home_Delete]", connection))
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
        ///    CSLA editable child business object of type <see cref="Home"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_Home_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_HomeID", this.HomeID);
                command.Parameters["@p_HomeID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_GLEntityID", this.GLEntityID);
                command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_HomeCostCentreCode", this.HomeCostCentreCode);
                command.Parameters.AddWithValue("@p_HomeName", this.HomeName);
                command.Parameters.AddWithValue("@p_Parcel", this.Parcel);
                command.Parameters.AddWithValue("@p_SILTarget", this.SILTarget);
                command.Parameters.AddWithValue("@p_NoofBeds", this.NoofBeds);
                command.Parameters.AddWithValue("@p_AccommodationTypeId", this.AccommodationTypeId);
                command.Parameters.AddWithValue("@p_isGST", this.IsGST);
                command.Parameters.AddWithValue("@p_AddressID", ADOHelper.NullCheck(this.AddressID));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _homeIDProperty=(System.Int32)command.Parameters["@p_HomeID"].Value;
            }

            UpdateChildren(this, connection,trans);

            OnChildInserted();
        }

        public void Child_Insert(ApplicationUser applicationUser, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(applicationUser, null, null, null, connection,trans);
        }


        public void Child_Insert(BusinessArea businessArea, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, businessArea, null, null, connection,trans);
        }


        public void Child_Insert(DataOption dataOption, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, null, dataOption, null, connection,trans);
        }


        public void Child_Insert(GLEntity gLEntity, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, null, null, gLEntity, connection,trans);
        }


        public void Child_Insert(ApplicationUser applicationUser, BusinessArea businessArea, DataOption dataOption, GLEntity gLEntity, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(applicationUser, businessArea, dataOption, gLEntity, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_Home_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_HomeID", this.HomeID);
                command.Parameters["@p_HomeID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_GLEntityID", gLEntity != null ? gLEntity.GLEntityID : this.GLEntityID);
                command.Parameters.AddWithValue("@p_BusinessAreaID", businessArea != null ? businessArea.BusinessAreaID : this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_HomeCostCentreCode", this.HomeCostCentreCode);
                command.Parameters.AddWithValue("@p_HomeName", this.HomeName);
                command.Parameters.AddWithValue("@p_Parcel", this.Parcel);
                command.Parameters.AddWithValue("@p_SILTarget", this.SILTarget);
                command.Parameters.AddWithValue("@p_NoofBeds", this.NoofBeds);
                command.Parameters.AddWithValue("@p_AccommodationTypeId", dataOption != null ? dataOption.DataOptionID : this.AccommodationTypeId);
                command.Parameters.AddWithValue("@p_isGST", this.IsGST);
                command.Parameters.AddWithValue("@p_AddressID", ADOHelper.NullCheck(this.AddressID));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", applicationUser != null ? applicationUser.ApplicationUserID : this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _homeIDProperty=(System.Int32)command.Parameters["@p_HomeID"].Value;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(gLEntity != null && gLEntity.GLEntityID != this.GLEntityID)
                _gLEntityIDProperty= gLEntity.GLEntityID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(businessArea != null && businessArea.BusinessAreaID != this.BusinessAreaID)
                _businessAreaIDProperty= businessArea.BusinessAreaID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(dataOption != null && dataOption.DataOptionID != this.AccommodationTypeId)
                _accommodationTypeIdProperty= dataOption.DataOptionID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(applicationUser != null && applicationUser.ApplicationUserID != this.CreatedBy)
                _createdByProperty= applicationUser.ApplicationUserID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(applicationUser != null && applicationUser.ApplicationUserID != this.UpdatedBy)
                _updatedByProperty= applicationUser.ApplicationUserID;
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildInserted() and insert this child manually.
            // UpdateChildren(this, null, connection);

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        /// <summary>
        /// Updates the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="Home"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_Home_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_HomeID", this.HomeID);
                command.Parameters.AddWithValue("@p_GLEntityID", this.GLEntityID);
                command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_HomeCostCentreCode", this.HomeCostCentreCode);
                command.Parameters.AddWithValue("@p_HomeName", this.HomeName);
                command.Parameters.AddWithValue("@p_Parcel", this.Parcel);
                command.Parameters.AddWithValue("@p_SILTarget", this.SILTarget);
                command.Parameters.AddWithValue("@p_NoofBeds", this.NoofBeds);
                command.Parameters.AddWithValue("@p_AccommodationTypeId", this.AccommodationTypeId);
                command.Parameters.AddWithValue("@p_isGST", this.IsGST);
                command.Parameters.AddWithValue("@p_AddressID", ADOHelper.NullCheck(this.AddressID));
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
            Child_Update(applicationUser, null, null, null, connection,trans);
        }


        public void Child_Update(BusinessArea businessArea, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, businessArea, null, null, connection,trans);
        }


        public void Child_Update(DataOption dataOption, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, null, dataOption, null, connection,trans);
        }


        public void Child_Update(GLEntity gLEntity, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, null, null, gLEntity, connection,trans);
        }

 
        public void Child_Update(ApplicationUser applicationUser, BusinessArea businessArea, DataOption dataOption, GLEntity gLEntity, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(applicationUser, businessArea, dataOption, gLEntity, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_Home_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_HomeID", this.HomeID);
                command.Parameters.AddWithValue("@p_GLEntityID", gLEntity != null ? gLEntity.GLEntityID : this.GLEntityID);
                command.Parameters.AddWithValue("@p_BusinessAreaID", businessArea != null ? businessArea.BusinessAreaID : this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_HomeCostCentreCode", this.HomeCostCentreCode);
                command.Parameters.AddWithValue("@p_HomeName", this.HomeName);
                command.Parameters.AddWithValue("@p_Parcel", this.Parcel);
                command.Parameters.AddWithValue("@p_SILTarget", this.SILTarget);
                command.Parameters.AddWithValue("@p_NoofBeds", this.NoofBeds);
                command.Parameters.AddWithValue("@p_AccommodationTypeId", dataOption != null ? dataOption.DataOptionID : this.AccommodationTypeId);
                command.Parameters.AddWithValue("@p_isGST", this.IsGST);
                command.Parameters.AddWithValue("@p_AddressID", ADOHelper.NullCheck(this.AddressID));
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
                if(gLEntity != null && gLEntity.GLEntityID != this.GLEntityID)
                    _gLEntityIDProperty= gLEntity.GLEntityID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(businessArea != null && businessArea.BusinessAreaID != this.BusinessAreaID)
                    _businessAreaIDProperty= businessArea.BusinessAreaID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(dataOption != null && dataOption.DataOptionID != this.AccommodationTypeId)
                    _accommodationTypeIdProperty= dataOption.DataOptionID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(applicationUser != null && applicationUser.ApplicationUserID != this.CreatedBy)
                    _createdByProperty= applicationUser.ApplicationUserID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(applicationUser != null && applicationUser.ApplicationUserID != this.UpdatedBy)
                    _updatedByProperty= applicationUser.ApplicationUserID;
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildUpdated() and update this child manually.
            // UpdateChildren(this, null, connection);

            OnChildUpdated();
        }
        #endregion

        /// <summary>
        /// Deletes the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="Home"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new HomeCriteria (HomeID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  HomeDTO dt=new HomeDTO();
			dt.HomeID =this.HomeID ;
			dt.GLEntityID =this.GLEntityID ;
			dt.BusinessAreaID =this.BusinessAreaID ;
			dt.HomeCostCentreCode =this.HomeCostCentreCode ;
			dt.HomeName =this.HomeName ;
			dt.Parcel =this.Parcel ;
			dt.SILTarget =this.SILTarget ;
			dt.NoofBeds =this.NoofBeds ;
			dt.AccommodationTypeId =this.AccommodationTypeId ;
			dt.IsGST =this.IsGST ;
			dt.AddressID =this.AddressID ;
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
                LoadProperty(_homeIDProperty, reader["HomeID"]);
                LoadProperty(_gLEntityIDProperty, reader["GLEntityID"]);
                LoadProperty(_businessAreaIDProperty, reader["BusinessAreaID"]);
                LoadProperty(_homeCostCentreCodeProperty, reader["HomeCostCentreCode"]);
                LoadProperty(_homeNameProperty, reader["HomeName"]);
                LoadProperty(_parcelProperty, reader["Parcel"]);
                LoadProperty(_sILTargetProperty, reader["SILTarget"]);
                LoadProperty(_noofBedsProperty, reader["NoofBeds"]);
                LoadProperty(_accommodationTypeIdProperty, reader["AccommodationTypeId"]);
                LoadProperty(_isGSTProperty, reader["isGST"]);
                LoadProperty(_addressIDProperty, reader["AddressID"]);
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
 