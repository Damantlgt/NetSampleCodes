﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//       Changes to this template will not be lost.
//
//     Template: EditableRootList.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CFMData
{
    /// <summary>
    /// The GLAccountList class is a CSLA editable root list class collection of <see cref="GLAccount"/> objects.  See CSLA documentation for a more detailed description.
    /// </summary>
    /// <returns></returns>
    public partial class GLAccountList
    {
        public static GLAccountList ValidateAccountCode(string accountCode, int? accountID)
        {
            return new GLAccountList().DataPortal_Fetch(accountCode, accountID);
        }

        private GLAccountList DataPortal_Fetch(string accountCode, int? glAccountID)
        {
            bool cancel = false;

            if (cancel) return null;

            // Fetch Child objects.
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_GLAccountCode_Validate]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@p_AccountCodeName", accountCode);

                    if (glAccountID.HasValue)
                    {
                        command.Parameters.AddWithValue("@p_GLAccountID", glAccountID.Value);
                    }


                    using (var reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            var rowParser = reader.GetRowParser<GLAccount>();
                            do
                            {

                                this.Add(GLAccount.GetGLAccount(rowParser, reader));
                            } while (reader.Read());
                        }
                        return this;
                    }
                }
            }
        }

        public static GLAccountList ValidateGLAccountAndEntityType(int accountTypeID, int entityTypeID, int? glAccountID)
        {
            return new GLAccountList().DataPortal_Fetch(accountTypeID, entityTypeID, glAccountID);
        }

        private GLAccountList DataPortal_Fetch(int accountTypeID, int entityTypeID, int? glAccountID)
        {
            bool cancel = false;

            if (cancel) return null;

            // Fetch Child objects.
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[spCFM_GLAccountTypeAndEntityType_Validate]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@p_GLAccountTypeID", accountTypeID);
                    command.Parameters.AddWithValue("@p_GLEntityTypeID", entityTypeID);

                    if (glAccountID.HasValue)
                    {
                        command.Parameters.AddWithValue("@p_GLAccountID", glAccountID.Value);
                    }

                    using (var reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            var rowParser = reader.GetRowParser<GLAccount>();
                            do
                            {

                                this.Add(GLAccount.GetGLAccount(rowParser, reader));
                            } while (reader.Read());
                        }
                        return this;
                    }
                }
            }
        }
    }
}