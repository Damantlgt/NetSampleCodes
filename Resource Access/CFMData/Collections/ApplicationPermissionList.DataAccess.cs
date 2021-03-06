//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ApplicationPermissionList.cs'.
//
//     Template: EditableRootList.DataAccess.StoredProcedures.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace CFMData
{
    public partial class ApplicationPermissionList
    {
        
        private ApplicationPermissionList DataPortal_Fetch(ApplicationPermissionCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return null;

            //RaiseListChangedEvents = false;

            // Fetch Child objects.
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_ApplicationPermission_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
		
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_ApplicationRoleIDHasValue", criteria.ApplicationRoleIDHasValue);
                command.Parameters.AddWithValue("@p_ApplicationUserIDHasValue", criteria.ApplicationUserIDHasValue);
                command.Parameters.AddWithValue("@p_BusinessAreaIDHasValue", criteria.BusinessAreaIDHasValue);
                command.Parameters.AddWithValue("@p_BusinessDivisionIDHasValue", criteria.BusinessDivisionIDHasValue);
                command.Parameters.AddWithValue("@p_BusinessEntityIDHasValue", criteria.BusinessEntityIDHasValue);
                command.Parameters.AddWithValue("@p_HomeIDHasValue", criteria.HomeIDHasValue);
                command.Parameters.AddWithValue("@p_ClientIDHasValue", criteria.ClientIDHasValue);
                command.Parameters.AddWithValue("@p_UpdatedByHasValue", criteria.UpdatedByHasValue);
                command.Parameters.AddWithValue("@p_UpdatedOnHasValue", criteria.UpdatedOnHasValue);
                    using(var reader = command.ExecuteReader())
                    {
						
                        if(reader.Read())
                        {
                           var rowParser = reader.GetRowParser<CFMData.ApplicationPermission>();
                           do
                           {
								
                              this.Add(CFMData.ApplicationPermission.GetApplicationPermission(rowParser, reader));
                           }while(reader.Read());
                        }
						OnFetched();
                        return this;
                    }
                }
            }

            //RaiseListChangedEvents = true;

            
        }

        //[Transactional(TransactionalTypes.TransactionScope)]
        protected   void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

          

           

            for (int index = 0; index < this.Count; index++)
            {
                this[index] = this[index].Save();
            }

           

            OnUpdated();
         }
    }
}
