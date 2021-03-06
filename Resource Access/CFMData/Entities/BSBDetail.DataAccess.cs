//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BSBDetail.cs'.
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
	public partial class BSBDetail
	{
    
		private BSBDetail DataPortal_Fetch(BSBDetailCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_BSBDetail_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_BSBHasValue", criteria.BsbHasValue);
                command.Parameters.AddWithValue("@p_BankCodeHasValue", criteria.BankCodeHasValue);
                command.Parameters.AddWithValue("@p_BSBNameHasValue", criteria.BSBNameHasValue);
                command.Parameters.AddWithValue("@p_AddressHasValue", criteria.AddressHasValue);
                command.Parameters.AddWithValue("@p_SuburbHasValue", criteria.SuburbHasValue);
                command.Parameters.AddWithValue("@p_StateHasValue", criteria.StateHasValue);
                command.Parameters.AddWithValue("@p_PostCodeHasValue", criteria.PostCodeHasValue);
                command.Parameters.AddWithValue("@p_PaymentSystemsHasValue", criteria.PaymentSystemsHasValue);
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<BSBDetail>();                       
						if(reader.Read())
						{
							return GetBSBDetail(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.BSBDetail' using the following criteria: {0}.", criteria));
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
				
				using(var command = new SqlCommand("[dbo].[spCFM_BSBDetail_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
          command.Parameters.AddWithValue("@p_BSBDetailID", this.BSBDetailID);
                command.Parameters["@p_BSBDetailID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_BSB", ADOHelper.NullCheck(this.Bsb));
                command.Parameters.AddWithValue("@p_BankCode", ADOHelper.NullCheck(this.BankCode));
                command.Parameters.AddWithValue("@p_BSBName", ADOHelper.NullCheck(this.BSBName));
                command.Parameters.AddWithValue("@p_Address", ADOHelper.NullCheck(this.Address));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_State", ADOHelper.NullCheck(this.State));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_PaymentSystems", ADOHelper.NullCheck(this.PaymentSystems));
					command.ExecuteNonQuery();                  
					_bSBDetailIDProperty=(System.Int32)command.Parameters["@p_BSBDetailID"].Value;
                    
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
				using(var command = new SqlCommand("[dbo].[spCFM_BSBDetail_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_BSBDetailID", this.BSBDetailID);
                command.Parameters.AddWithValue("@p_BSB", ADOHelper.NullCheck(this.Bsb));
                command.Parameters.AddWithValue("@p_BankCode", ADOHelper.NullCheck(this.BankCode));
                command.Parameters.AddWithValue("@p_BSBName", ADOHelper.NullCheck(this.BSBName));
                command.Parameters.AddWithValue("@p_Address", ADOHelper.NullCheck(this.Address));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_State", ADOHelper.NullCheck(this.State));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_PaymentSystems", ADOHelper.NullCheck(this.PaymentSystems));
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
		protected   void UpdateChildren(BSBDetail parent,SqlConnection connection,SqlTransaction trans)
		{
		
		
			
			if(_bankAccountsPropertyChecked )
			{
				if(_bankAccountsProperty!=null)
				{
				
					foreach (BankAccount obj in _bankAccountsProperty)
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
			DataPortal_Delete(new BSBDetailCriteria (BSBDetailID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(BSBDetailCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_BSBDetail_Delete]", connection))
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
        ///    CSLA editable child business object of type <see cref="BSBDetail"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BSBDetail_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BSBDetailID", this.BSBDetailID);
                command.Parameters["@p_BSBDetailID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_BSB", ADOHelper.NullCheck(this.Bsb));
                command.Parameters.AddWithValue("@p_BankCode", ADOHelper.NullCheck(this.BankCode));
                command.Parameters.AddWithValue("@p_BSBName", ADOHelper.NullCheck(this.BSBName));
                command.Parameters.AddWithValue("@p_Address", ADOHelper.NullCheck(this.Address));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_State", ADOHelper.NullCheck(this.State));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_PaymentSystems", ADOHelper.NullCheck(this.PaymentSystems));

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _bSBDetailIDProperty=(System.Int32)command.Parameters["@p_BSBDetailID"].Value;
            }

            UpdateChildren(this, connection,trans);

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        /// <summary>
        /// Updates the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="BSBDetail"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BSBDetail_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BSBDetailID", this.BSBDetailID);
                command.Parameters.AddWithValue("@p_BSB", ADOHelper.NullCheck(this.Bsb));
                command.Parameters.AddWithValue("@p_BankCode", ADOHelper.NullCheck(this.BankCode));
                command.Parameters.AddWithValue("@p_BSBName", ADOHelper.NullCheck(this.BSBName));
                command.Parameters.AddWithValue("@p_Address", ADOHelper.NullCheck(this.Address));
                command.Parameters.AddWithValue("@p_Suburb", ADOHelper.NullCheck(this.Suburb));
                command.Parameters.AddWithValue("@p_State", ADOHelper.NullCheck(this.State));
                command.Parameters.AddWithValue("@p_PostCode", ADOHelper.NullCheck(this.PostCode));
                command.Parameters.AddWithValue("@p_PaymentSystems", ADOHelper.NullCheck(this.PaymentSystems));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            UpdateChildren(this, connection,trans);

            OnChildUpdated();
        }
        #endregion

        /// <summary>
        /// Deletes the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="BSBDetail"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new BSBDetailCriteria (BSBDetailID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  BSBDetailDTO dt=new BSBDetailDTO();
			dt.BSBDetailID =this.BSBDetailID ;
			dt.Bsb =this.Bsb ;
			dt.BankCode =this.BankCode ;
			dt.BSBName =this.BSBName ;
			dt.Address =this.Address ;
			dt.Suburb =this.Suburb ;
			dt.State =this.State ;
			dt.PostCode =this.PostCode ;
			dt.PaymentSystems =this.PaymentSystems ;
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
                LoadProperty(_bSBDetailIDProperty, reader["BSBDetailID"]);
                LoadProperty(_bsbProperty, reader["BSB"]);
                LoadProperty(_bankCodeProperty, reader["BankCode"]);
                LoadProperty(_bSBNameProperty, reader["BSBName"]);
                LoadProperty(_addressProperty, reader["Address"]);
                LoadProperty(_suburbProperty, reader["Suburb"]);
                LoadProperty(_stateProperty, reader["State"]);
                LoadProperty(_postCodeProperty, reader["PostCode"]);
                LoadProperty(_paymentSystemsProperty, reader["PaymentSystems"]);
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
 