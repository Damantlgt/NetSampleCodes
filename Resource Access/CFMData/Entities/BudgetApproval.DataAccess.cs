﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BudgetApproval.cs'.
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
	public partial class BudgetApproval
	{
    
		private BudgetApproval DataPortal_Fetch(BudgetApprovalCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_BudgetApproval_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_AdministratorUserIDHasValue", criteria.AdministratorUserIDHasValue);
                command.Parameters.AddWithValue("@p_OperationsUserIDHasValue", criteria.OperationsUserIDHasValue);
                command.Parameters.AddWithValue("@p_ApprovalDateHasValue", criteria.ApprovalDateHasValue);
                command.Parameters.AddWithValue("@p_ReminderDateHasValue", criteria.ReminderDateHasValue);
                command.Parameters.AddWithValue("@p_ApprovalFileIDHasValue", criteria.ApprovalFileIDHasValue);
                command.Parameters.AddWithValue("@p_UpdatedByHasValue", criteria.UpdatedByHasValue);
                command.Parameters.AddWithValue("@p_UpdatedOnHasValue", criteria.UpdatedOnHasValue);
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<BudgetApproval>();                       
						if(reader.Read())
						{
							return GetBudgetApproval(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.BudgetApproval' using the following criteria: {0}.", criteria));
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
				
				using(var command = new SqlCommand("[dbo].[spCFM_BudgetApproval_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
          command.Parameters.AddWithValue("@p_BudgetApprovalID", this.BudgetApprovalID);
                command.Parameters["@p_BudgetApprovalID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_BudgetID", this.BudgetID);
                command.Parameters.AddWithValue("@p_AdministratorUserID", ADOHelper.NullCheck(this.AdministratorUserID));
                command.Parameters.AddWithValue("@p_OperationsUserID", ADOHelper.NullCheck(this.OperationsUserID));
                command.Parameters.AddWithValue("@p_ApprovalDate", ADOHelper.NullCheck(this.ApprovalDate));
                command.Parameters.AddWithValue("@p_Status", this.Status);
                command.Parameters.AddWithValue("@p_ReminderDate", ADOHelper.NullCheck(this.ReminderDate));
                command.Parameters.AddWithValue("@p_ApprovalFileID", ADOHelper.NullCheck(this.ApprovalFileID));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));
					command.ExecuteNonQuery();                  
					_budgetApprovalIDProperty=(System.Int32)command.Parameters["@p_BudgetApprovalID"].Value;
                    
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
				using(var command = new SqlCommand("[dbo].[spCFM_BudgetApproval_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_BudgetApprovalID", this.BudgetApprovalID);
                command.Parameters.AddWithValue("@p_BudgetID", this.BudgetID);
                command.Parameters.AddWithValue("@p_AdministratorUserID", ADOHelper.NullCheck(this.AdministratorUserID));
                command.Parameters.AddWithValue("@p_OperationsUserID", ADOHelper.NullCheck(this.OperationsUserID));
                command.Parameters.AddWithValue("@p_ApprovalDate", ADOHelper.NullCheck(this.ApprovalDate));
                command.Parameters.AddWithValue("@p_Status", this.Status);
                command.Parameters.AddWithValue("@p_ReminderDate", ADOHelper.NullCheck(this.ReminderDate));
                command.Parameters.AddWithValue("@p_ApprovalFileID", ADOHelper.NullCheck(this.ApprovalFileID));
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
		protected   void UpdateChildren(BudgetApproval parent,SqlConnection connection,SqlTransaction trans)
		{
		
		

		}

		protected   void DataPortal_DeleteSelf()
		{
			bool cancel = false;
			OnSelfDeleting(ref cancel);
			if (cancel) return;            
			DataPortal_Delete(new BudgetApprovalCriteria (BudgetApprovalID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(BudgetApprovalCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_BudgetApproval_Delete]", connection))
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
        ///    CSLA editable child business object of type <see cref="BudgetApproval"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BudgetApproval_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BudgetApprovalID", this.BudgetApprovalID);
                command.Parameters["@p_BudgetApprovalID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_BudgetID", this.BudgetID);
                command.Parameters.AddWithValue("@p_AdministratorUserID", ADOHelper.NullCheck(this.AdministratorUserID));
                command.Parameters.AddWithValue("@p_OperationsUserID", ADOHelper.NullCheck(this.OperationsUserID));
                command.Parameters.AddWithValue("@p_ApprovalDate", ADOHelper.NullCheck(this.ApprovalDate));
                command.Parameters.AddWithValue("@p_Status", this.Status);
                command.Parameters.AddWithValue("@p_ReminderDate", ADOHelper.NullCheck(this.ReminderDate));
                command.Parameters.AddWithValue("@p_ApprovalFileID", ADOHelper.NullCheck(this.ApprovalFileID));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _budgetApprovalIDProperty=(System.Int32)command.Parameters["@p_BudgetApprovalID"].Value;
            }

            UpdateChildren(this, connection,trans);

            OnChildInserted();
        }

        public void Child_Insert(ApplicationUser applicationUser, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(applicationUser, null, connection,trans);
        }


        public void Child_Insert(Budget budget, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, budget, connection,trans);
        }


        public void Child_Insert(ApplicationUser applicationUser, Budget budget, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(applicationUser, budget, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BudgetApproval_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BudgetApprovalID", this.BudgetApprovalID);
                command.Parameters["@p_BudgetApprovalID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_BudgetID", budget != null ? budget.BudgetID : this.BudgetID);
                command.Parameters.AddWithValue("@p_AdministratorUserID", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.AdministratorUserID));
                command.Parameters.AddWithValue("@p_OperationsUserID", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.OperationsUserID));
                command.Parameters.AddWithValue("@p_ApprovalDate", ADOHelper.NullCheck(this.ApprovalDate));
                command.Parameters.AddWithValue("@p_Status", this.Status);
                command.Parameters.AddWithValue("@p_ReminderDate", ADOHelper.NullCheck(this.ReminderDate));
                command.Parameters.AddWithValue("@p_ApprovalFileID", ADOHelper.NullCheck(this.ApprovalFileID));
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", applicationUser != null ? applicationUser.ApplicationUserID : this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _budgetApprovalIDProperty=(System.Int32)command.Parameters["@p_BudgetApprovalID"].Value;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(budget != null && budget.BudgetID != this.BudgetID)
                _budgetIDProperty= budget.BudgetID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(applicationUser != null && applicationUser.ApplicationUserID != this.AdministratorUserID)
                _administratorUserIDProperty= applicationUser.ApplicationUserID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(applicationUser != null && applicationUser.ApplicationUserID != this.OperationsUserID)
                _operationsUserIDProperty= applicationUser.ApplicationUserID;

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
        ///    CSLA editable child business object of type <see cref="BudgetApproval"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BudgetApproval_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BudgetApprovalID", this.BudgetApprovalID);
                command.Parameters.AddWithValue("@p_BudgetID", this.BudgetID);
                command.Parameters.AddWithValue("@p_AdministratorUserID", ADOHelper.NullCheck(this.AdministratorUserID));
                command.Parameters.AddWithValue("@p_OperationsUserID", ADOHelper.NullCheck(this.OperationsUserID));
                command.Parameters.AddWithValue("@p_ApprovalDate", ADOHelper.NullCheck(this.ApprovalDate));
                command.Parameters.AddWithValue("@p_Status", this.Status);
                command.Parameters.AddWithValue("@p_ReminderDate", ADOHelper.NullCheck(this.ReminderDate));
                command.Parameters.AddWithValue("@p_ApprovalFileID", ADOHelper.NullCheck(this.ApprovalFileID));
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


        public void Child_Update(Budget budget, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, budget, connection,trans);
        }

 
        public void Child_Update(ApplicationUser applicationUser, Budget budget, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(applicationUser, budget, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BudgetApproval_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BudgetApprovalID", this.BudgetApprovalID);
                command.Parameters.AddWithValue("@p_BudgetID", budget != null ? budget.BudgetID : this.BudgetID);
                command.Parameters.AddWithValue("@p_AdministratorUserID", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.AdministratorUserID));
                command.Parameters.AddWithValue("@p_OperationsUserID", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.OperationsUserID));
                command.Parameters.AddWithValue("@p_ApprovalDate", ADOHelper.NullCheck(this.ApprovalDate));
                command.Parameters.AddWithValue("@p_Status", this.Status);
                command.Parameters.AddWithValue("@p_ReminderDate", ADOHelper.NullCheck(this.ReminderDate));
                command.Parameters.AddWithValue("@p_ApprovalFileID", ADOHelper.NullCheck(this.ApprovalFileID));
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
                if(budget != null && budget.BudgetID != this.BudgetID)
                    _budgetIDProperty= budget.BudgetID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(applicationUser != null && applicationUser.ApplicationUserID != this.AdministratorUserID)
                    _administratorUserIDProperty= applicationUser.ApplicationUserID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(applicationUser != null && applicationUser.ApplicationUserID != this.OperationsUserID)
                    _operationsUserIDProperty= applicationUser.ApplicationUserID;

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
        ///    CSLA editable child business object of type <see cref="BudgetApproval"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new BudgetApprovalCriteria (BudgetApprovalID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  BudgetApprovalDTO dt=new BudgetApprovalDTO();
			dt.BudgetApprovalID =this.BudgetApprovalID ;
			dt.BudgetID =this.BudgetID ;
			dt.AdministratorUserID =this.AdministratorUserID ;
			dt.OperationsUserID =this.OperationsUserID ;
			dt.ApprovalDate =this.ApprovalDate ;
			dt.Status =this.Status ;
			dt.ReminderDate =this.ReminderDate ;
			dt.ApprovalFileID =this.ApprovalFileID ;
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
                LoadProperty(_budgetApprovalIDProperty, reader["BudgetApprovalID"]);
                LoadProperty(_budgetIDProperty, reader["BudgetID"]);
                LoadProperty(_administratorUserIDProperty, reader["AdministratorUserID"]);
                LoadProperty(_operationsUserIDProperty, reader["OperationsUserID"]);
                LoadProperty(_approvalDateProperty, reader["ApprovalDate"]);
                LoadProperty(_statusProperty, reader["Status"]);
                LoadProperty(_reminderDateProperty, reader["ReminderDate"]);
                LoadProperty(_approvalFileIDProperty, reader["ApprovalFileID"]);
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
 