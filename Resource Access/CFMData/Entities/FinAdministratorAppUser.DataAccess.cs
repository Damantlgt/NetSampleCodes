//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'FinAdministratorAppUser.cs'.
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
	public partial class FinAdministratorAppUser
	{
    
		private FinAdministratorAppUser DataPortal_Fetch(FinAdministratorAppUserCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_FinAdministratorAppUser_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_UpdatedByHasValue", criteria.UpdatedByHasValue);
                command.Parameters.AddWithValue("@p_UpdatedOnHasValue", criteria.UpdatedOnHasValue);
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<FinAdministratorAppUser>();                       
						if(reader.Read())
						{
							return GetFinAdministratorAppUser(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.FinAdministratorAppUser' using the following criteria: {0}.", criteria));
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
				
				using(var command = new SqlCommand("[dbo].[spCFM_FinAdministratorAppUser_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
                command.Parameters.AddWithValue("@p_FinAdministratorAppUserID", this.FinAdministratorAppUserID);
                command.Parameters["@p_FinAdministratorAppUserID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_FinAdministratorID", this.FinAdministratorID);
                command.Parameters.AddWithValue("@p_ApplicationUserId", this.ApplicationUserId);
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));
					command.ExecuteNonQuery();                  
					_finAdministratorAppUserIDProperty=(System.Int32)command.Parameters["@p_FinAdministratorAppUserID"].Value;
                    
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
				using(var command = new SqlCommand("[dbo].[spCFM_FinAdministratorAppUser_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_FinAdministratorAppUserID", this.FinAdministratorAppUserID);
                command.Parameters.AddWithValue("@p_FinAdministratorID", this.FinAdministratorID);
                command.Parameters.AddWithValue("@p_ApplicationUserId", this.ApplicationUserId);
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
		protected   void UpdateChildren(FinAdministratorAppUser parent,SqlConnection connection,SqlTransaction trans)
		{
		
		

		}

		protected   void DataPortal_DeleteSelf()
		{
			bool cancel = false;
			OnSelfDeleting(ref cancel);
			if (cancel) return;            
			DataPortal_Delete(new FinAdministratorAppUserCriteria (FinAdministratorAppUserID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(FinAdministratorAppUserCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_FinAdministratorAppUser_Delete]", connection))
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
        ///    CSLA editable child business object of type <see cref="FinAdministratorAppUser"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_FinAdministratorAppUser_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_FinAdministratorAppUserID", this.FinAdministratorAppUserID);
                command.Parameters["@p_FinAdministratorAppUserID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_FinAdministratorID", this.FinAdministratorID);
                command.Parameters.AddWithValue("@p_ApplicationUserId", this.ApplicationUserId);
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _finAdministratorAppUserIDProperty=(System.Int32)command.Parameters["@p_FinAdministratorAppUserID"].Value;
            }

            UpdateChildren(this, connection,trans);

            OnChildInserted();
        }

        public void Child_Insert(ApplicationUser applicationUser, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(applicationUser, null, connection,trans);
        }


        public void Child_Insert(FinAdministrator finAdministrator, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, finAdministrator, connection,trans);
        }


        public void Child_Insert(ApplicationUser applicationUser, FinAdministrator finAdministrator, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(applicationUser, finAdministrator, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_FinAdministratorAppUser_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_FinAdministratorAppUserID", this.FinAdministratorAppUserID);
                command.Parameters["@p_FinAdministratorAppUserID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_FinAdministratorID", finAdministrator != null ? finAdministrator.FinAdministratorID : this.FinAdministratorID);
                command.Parameters.AddWithValue("@p_ApplicationUserId", applicationUser != null ? applicationUser.ApplicationUserID : this.ApplicationUserId);
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", applicationUser != null ? applicationUser.ApplicationUserID : this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _finAdministratorAppUserIDProperty=(System.Int32)command.Parameters["@p_FinAdministratorAppUserID"].Value;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(finAdministrator != null && finAdministrator.FinAdministratorID != this.FinAdministratorID)
                _finAdministratorIDProperty= finAdministrator.FinAdministratorID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(applicationUser != null && applicationUser.ApplicationUserID != this.ApplicationUserId)
                _applicationUserIdProperty= applicationUser.ApplicationUserID;

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
        ///    CSLA editable child business object of type <see cref="FinAdministratorAppUser"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_FinAdministratorAppUser_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_FinAdministratorAppUserID", this.FinAdministratorAppUserID);
                command.Parameters.AddWithValue("@p_FinAdministratorID", this.FinAdministratorID);
                command.Parameters.AddWithValue("@p_ApplicationUserId", this.ApplicationUserId);
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


        public void Child_Update(FinAdministrator finAdministrator, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, finAdministrator, connection,trans);
        }

 
        public void Child_Update(ApplicationUser applicationUser, FinAdministrator finAdministrator, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(applicationUser, finAdministrator, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_FinAdministratorAppUser_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_FinAdministratorAppUserID", this.FinAdministratorAppUserID);
                command.Parameters.AddWithValue("@p_FinAdministratorID", finAdministrator != null ? finAdministrator.FinAdministratorID : this.FinAdministratorID);
                command.Parameters.AddWithValue("@p_ApplicationUserId", applicationUser != null ? applicationUser.ApplicationUserID : this.ApplicationUserId);
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
                if(finAdministrator != null && finAdministrator.FinAdministratorID != this.FinAdministratorID)
                    _finAdministratorIDProperty= finAdministrator.FinAdministratorID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(applicationUser != null && applicationUser.ApplicationUserID != this.ApplicationUserId)
                    _applicationUserIdProperty= applicationUser.ApplicationUserID;

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
        ///    CSLA editable child business object of type <see cref="FinAdministratorAppUser"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new FinAdministratorAppUserCriteria (FinAdministratorAppUserID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  FinAdministratorAppUserDTO dt=new FinAdministratorAppUserDTO();
			dt.FinAdministratorAppUserID =this.FinAdministratorAppUserID ;
			dt.FinAdministratorID =this.FinAdministratorID ;
			dt.ApplicationUserId =this.ApplicationUserId ;
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
                LoadProperty(_finAdministratorAppUserIDProperty, reader["FinAdministratorAppUserID"]);
                LoadProperty(_finAdministratorIDProperty, reader["FinAdministratorID"]);
                LoadProperty(_applicationUserIdProperty, reader["ApplicationUserId"]);
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
 