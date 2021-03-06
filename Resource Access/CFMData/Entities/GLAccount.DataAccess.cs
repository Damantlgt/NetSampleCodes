//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'GLAccount.cs'.
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
	public partial class GLAccount
	{
    
		private GLAccount DataPortal_Fetch(GLAccountCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_GLAccount_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_BankAccountIDHasValue", criteria.BankAccountIDHasValue);
                command.Parameters.AddWithValue("@p_UpdatedByHasValue", criteria.UpdatedByHasValue);
                command.Parameters.AddWithValue("@p_UpdatedOnHasValue", criteria.UpdatedOnHasValue);
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<GLAccount>();                       
						if(reader.Read())
						{
							return GetGLAccount(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.GLAccount' using the following criteria: {0}.", criteria));
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
				
				using(var command = new SqlCommand("[dbo].[spCFM_GLAccount_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
          command.Parameters.AddWithValue("@p_GLAccountID", this.GLAccountID);
                command.Parameters["@p_GLAccountID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_AccountCode", this.AccountCode);
                command.Parameters.AddWithValue("@p_AccountName", this.AccountName);
                command.Parameters.AddWithValue("@p_GLEntityID", this.GLEntityID);
                command.Parameters.AddWithValue("@p_BankAccountID", ADOHelper.NullCheck(this.BankAccountID));
                command.Parameters.AddWithValue("@p_GLAccountTypeID", this.GLAccountTypeID);
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));
					command.ExecuteNonQuery();                  
					_gLAccountIDProperty=(System.Int32)command.Parameters["@p_GLAccountID"].Value;
                    
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
				using(var command = new SqlCommand("[dbo].[spCFM_GLAccount_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_GLAccountID", this.GLAccountID);
                command.Parameters.AddWithValue("@p_AccountCode", this.AccountCode);
                command.Parameters.AddWithValue("@p_AccountName", this.AccountName);
                command.Parameters.AddWithValue("@p_GLEntityID", this.GLEntityID);
                command.Parameters.AddWithValue("@p_BankAccountID", ADOHelper.NullCheck(this.BankAccountID));
                command.Parameters.AddWithValue("@p_GLAccountTypeID", this.GLAccountTypeID);
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
		protected   void UpdateChildren(GLAccount parent,SqlConnection connection,SqlTransaction trans)
		{
		
		

		}

		protected   void DataPortal_DeleteSelf()
		{
			bool cancel = false;
			OnSelfDeleting(ref cancel);
			if (cancel) return;            
			DataPortal_Delete(new GLAccountCriteria (GLAccountID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(GLAccountCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_GLAccount_Delete]", connection))
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
        ///    CSLA editable child business object of type <see cref="GLAccount"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_GLAccount_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_GLAccountID", this.GLAccountID);
                command.Parameters["@p_GLAccountID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_AccountCode", this.AccountCode);
                command.Parameters.AddWithValue("@p_AccountName", this.AccountName);
                command.Parameters.AddWithValue("@p_GLEntityID", this.GLEntityID);
                command.Parameters.AddWithValue("@p_BankAccountID", ADOHelper.NullCheck(this.BankAccountID));
                command.Parameters.AddWithValue("@p_GLAccountTypeID", this.GLAccountTypeID);
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _gLAccountIDProperty=(System.Int32)command.Parameters["@p_GLAccountID"].Value;
            }

            UpdateChildren(this, connection,trans);

            OnChildInserted();
        }

        public void Child_Insert(ApplicationUser applicationUser, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(applicationUser, null, null, null, connection,trans);
        }


        public void Child_Insert(BankAccount bankAccount, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, bankAccount, null, null, connection,trans);
        }


        public void Child_Insert(GLAccountType gLAccountType, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, null, gLAccountType, null, connection,trans);
        }


        public void Child_Insert(GLEntity gLEntity, SqlConnection connection,SqlTransaction trans)
        {
            Child_Insert(null, null, null, gLEntity, connection,trans);
        }


        public void Child_Insert(ApplicationUser applicationUser, BankAccount bankAccount, GLAccountType gLAccountType, GLEntity gLEntity, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(applicationUser, bankAccount, gLAccountType, gLEntity, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_GLAccount_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_GLAccountID", this.GLAccountID);
                command.Parameters["@p_GLAccountID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_AccountCode", this.AccountCode);
                command.Parameters.AddWithValue("@p_AccountName", this.AccountName);
                command.Parameters.AddWithValue("@p_GLEntityID", gLEntity != null ? gLEntity.GLEntityID : this.GLEntityID);
                command.Parameters.AddWithValue("@p_BankAccountID", ADOHelper.NullCheck(bankAccount != null ? bankAccount.BankAccountID : this.BankAccountID));
                command.Parameters.AddWithValue("@p_GLAccountTypeID", gLAccountType != null ? gLAccountType.GLAccountTypeID : this.GLAccountTypeID);
                command.Parameters.AddWithValue("@p_IsActive", this.IsActive);
                command.Parameters.AddWithValue("@p_CreatedBy", applicationUser != null ? applicationUser.ApplicationUserID : this.CreatedBy);
                command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
                command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(applicationUser != null ? applicationUser.ApplicationUserID : this.UpdatedBy));
                command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _gLAccountIDProperty=(System.Int32)command.Parameters["@p_GLAccountID"].Value;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(gLEntity != null && gLEntity.GLEntityID != this.GLEntityID)
                _gLEntityIDProperty= gLEntity.GLEntityID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(bankAccount != null && bankAccount.BankAccountID != this.BankAccountID)
                _bankAccountIDProperty= bankAccount.BankAccountID;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(gLAccountType != null && gLAccountType.GLAccountTypeID != this.GLAccountTypeID)
                _gLAccountTypeIDProperty= gLAccountType.GLAccountTypeID;

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
        ///    CSLA editable child business object of type <see cref="GLAccount"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_GLAccount_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_GLAccountID", this.GLAccountID);
                command.Parameters.AddWithValue("@p_AccountCode", this.AccountCode);
                command.Parameters.AddWithValue("@p_AccountName", this.AccountName);
                command.Parameters.AddWithValue("@p_GLEntityID", this.GLEntityID);
                command.Parameters.AddWithValue("@p_BankAccountID", ADOHelper.NullCheck(this.BankAccountID));
                command.Parameters.AddWithValue("@p_GLAccountTypeID", this.GLAccountTypeID);
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


        public void Child_Update(BankAccount bankAccount, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, bankAccount, null, null, connection,trans);
        }


        public void Child_Update(GLAccountType gLAccountType, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, null, gLAccountType, null, connection,trans);
        }


        public void Child_Update(GLEntity gLEntity, SqlConnection connection,SqlTransaction trans)
        {
            Child_Update(null, null, null, gLEntity, connection,trans);
        }

 
        public void Child_Update(ApplicationUser applicationUser, BankAccount bankAccount, GLAccountType gLAccountType, GLEntity gLEntity, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(applicationUser, bankAccount, gLAccountType, gLEntity, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_GLAccount_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_GLAccountID", this.GLAccountID);
                command.Parameters.AddWithValue("@p_AccountCode", this.AccountCode);
                command.Parameters.AddWithValue("@p_AccountName", this.AccountName);
                command.Parameters.AddWithValue("@p_GLEntityID", gLEntity != null ? gLEntity.GLEntityID : this.GLEntityID);
                command.Parameters.AddWithValue("@p_BankAccountID", ADOHelper.NullCheck(bankAccount != null ? bankAccount.BankAccountID : this.BankAccountID));
                command.Parameters.AddWithValue("@p_GLAccountTypeID", gLAccountType != null ? gLAccountType.GLAccountTypeID : this.GLAccountTypeID);
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
                if(bankAccount != null && bankAccount.BankAccountID != this.BankAccountID)
                    _bankAccountIDProperty= bankAccount.BankAccountID;

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(gLAccountType != null && gLAccountType.GLAccountTypeID != this.GLAccountTypeID)
                    _gLAccountTypeIDProperty= gLAccountType.GLAccountTypeID;

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
        ///    CSLA editable child business object of type <see cref="GLAccount"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new GLAccountCriteria (GLAccountID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  GLAccountDTO dt=new GLAccountDTO();
			dt.GLAccountID =this.GLAccountID ;
			dt.AccountCode =this.AccountCode ;
			dt.AccountName =this.AccountName ;
			dt.GLEntityID =this.GLEntityID ;
			dt.BankAccountID =this.BankAccountID ;
			dt.GLAccountTypeID =this.GLAccountTypeID ;
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
                LoadProperty(_gLAccountIDProperty, reader["GLAccountID"]);
                LoadProperty(_accountCodeProperty, reader["AccountCode"]);
                LoadProperty(_accountNameProperty, reader["AccountName"]);
                LoadProperty(_gLEntityIDProperty, reader["GLEntityID"]);
                LoadProperty(_bankAccountIDProperty, reader["BankAccountID"]);
                LoadProperty(_gLAccountTypeIDProperty, reader["GLAccountTypeID"]);
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
 