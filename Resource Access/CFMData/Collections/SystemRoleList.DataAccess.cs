//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'SystemRoleList.cs'.
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
    public partial class SystemRoleList
    {
        
        private SystemRoleList DataPortal_Fetch(SystemRoleCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return null;

            //RaiseListChangedEvents = false;

            // Fetch Child objects.
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_SystemRole_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
		
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    
                    using(var reader = command.ExecuteReader())
                    {
						
                        if(reader.Read())
                        {
                           var rowParser = reader.GetRowParser<CFMData.SystemRole>();
                           do
                           {
								
                              this.Add(CFMData.SystemRole.GetSystemRole(rowParser, reader));
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
