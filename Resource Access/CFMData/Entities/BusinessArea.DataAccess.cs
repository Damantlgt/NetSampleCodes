//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BusinessArea.cs'.
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
	public partial class BusinessArea
	{
    
		private BusinessArea DataPortal_Fetch(BusinessAreaCriteria criteria)
		{
 
			bool cancel = false;
			OnFetching(criteria, ref cancel);
			if (cancel) return null;
			using (var connection = new SqlConnection(ADOHelper.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("[dbo].[spCFM_BusinessArea_Select]", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue);
					using(var reader = command.ExecuteReader())
					{
						var rowParser = reader.GetRowParser<BusinessArea>();                       
						if(reader.Read())
						{
							return GetBusinessArea(rowParser, reader);							
						}                            
						else
							throw new Exception(String.Format("The record was not found in 'dbo.BusinessArea' using the following criteria: {0}.", criteria));
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
				
				using(var command = new SqlCommand("[dbo].[spCFM_BusinessArea_Insert]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					
          command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters["@p_BusinessAreaID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_BusinessDivisionID", this.BusinessDivisionID);
					command.ExecuteNonQuery();                  
					_businessAreaIDProperty=(System.Int32)command.Parameters["@p_BusinessAreaID"].Value;
                    
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
				using(var command = new SqlCommand("[dbo].[spCFM_BusinessArea_Update]", connection,trans))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_BusinessDivisionID", this.BusinessDivisionID);
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
		protected   void UpdateChildren(BusinessArea parent,SqlConnection connection,SqlTransaction trans)
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

			
			if(_homesPropertyChecked )
			{
				if(_homesProperty!=null)
				{
				
					foreach (Home obj in _homesProperty)
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
			DataPortal_Delete(new BusinessAreaCriteria (BusinessAreaID));        
			OnSelfDeleted();
		}
        
		//[Transactional(TransactionalTypes.TransactionScope)]
		protected void DataPortal_Delete(BusinessAreaCriteria criteria)
		{
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_BusinessArea_Delete]", connection))
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
        ///    CSLA editable child business object of type <see cref="BusinessArea"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Insert(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BusinessArea_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters["@p_BusinessAreaID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_BusinessDivisionID", this.BusinessDivisionID);

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _businessAreaIDProperty=(System.Int32)command.Parameters["@p_BusinessAreaID"].Value;
            }

            UpdateChildren(this, connection,trans);

            OnChildInserted();
        }

        public void Child_Insert(BusinessDivision businessDivision, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildInserting(businessDivision, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BusinessArea_Insert]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters["@p_BusinessAreaID"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_BusinessDivisionID", businessDivision != null ? businessDivision.BusinessDivisionID : this.BusinessDivisionID);

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                _businessAreaIDProperty=(System.Int32)command.Parameters["@p_BusinessAreaID"].Value;

            // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
            if(businessDivision != null && businessDivision.BusinessDivisionID != this.BusinessDivisionID)
                _businessDivisionIDProperty= businessDivision.BusinessDivisionID;
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
        ///    CSLA editable child business object of type <see cref="BusinessArea"/> 
        /// </summary>
        /// <returns></returns>
        public void Child_Update(SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BusinessArea_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_BusinessDivisionID", this.BusinessDivisionID);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            UpdateChildren(this, connection,trans);

            OnChildUpdated();
        }
 
        public void Child_Update(BusinessDivision businessDivision, SqlConnection connection,SqlTransaction trans)
        {
            bool cancel = false;
            OnChildUpdating(businessDivision, connection, ref cancel,trans);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[spCFM_BusinessArea_Update]", connection,trans))
            {
                command.CommandType = CommandType.StoredProcedure;
		
                command.Parameters.AddWithValue("@p_BusinessAreaID", this.BusinessAreaID);
                command.Parameters.AddWithValue("@p_Code", this.Code);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_BusinessDivisionID", businessDivision != null ? businessDivision.BusinessDivisionID : this.BusinessDivisionID);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(businessDivision != null && businessDivision.BusinessDivisionID != this.BusinessDivisionID)
                    _businessDivisionIDProperty= businessDivision.BusinessDivisionID;
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildUpdated() and update this child manually.
            // UpdateChildren(this, null, connection);

            OnChildUpdated();
        }
        #endregion

        /// <summary>
        /// Deletes the corresponding record in the data base with the information in the current 
        ///    CSLA editable child business object of type <see cref="BusinessArea"/> 
        /// </summary>
        /// <returns></returns>
        private void Child_DeleteSelf(SqlConnection connection)
        {
            bool cancel = false;
            OnChildSelfDeleting(connection, ref cancel);
            if (cancel) return;
            
            //DataPortal_Delete(new BusinessAreaCriteria (BusinessAreaID), connection);
        
            OnChildSelfDeleted();
        }

        #region Map
		public void InitDTO()
		{
			  BusinessAreaDTO dt=new BusinessAreaDTO();
			dt.BusinessAreaID =this.BusinessAreaID ;
			dt.Code =this.Code ;
			dt.Name =this.Name ;
			dt.BusinessDivisionID =this.BusinessDivisionID ;
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
                LoadProperty(_businessAreaIDProperty, reader["BusinessAreaID"]);
                LoadProperty(_codeProperty, reader["Code"]);
                LoadProperty(_nameProperty, reader["Name"]);
                LoadProperty(_businessDivisionIDProperty, reader["BusinessDivisionID"]);
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
 