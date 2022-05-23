﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'DataOptionType.cs'.
//
//     Template: Criteria.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


 

namespace CFMData
{
    [Serializable]
    public partial class DataOptionTypeCriteria 
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public DataOptionTypeCriteria(){}

        public DataOptionTypeCriteria(System.Int32 dataOptionTypeID)
        {
            DataOptionTypeID = dataOptionTypeID;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.Int32 DataOptionTypeID
        {
            get { return GetValue<System.Int32>("DataOptionTypeID"); }
            set { _bag["DataOptionTypeID"] = value; }
        }

        public System.Int32? DataOptionTypeSortID
        {
            get { return GetValue<System.Int32?>("DataOptionTypeSortID"); }
            set { _bag["DataOptionTypeSortID"] = value; }
        }

        public System.String Code
        {
            get { return GetValue<System.String>("Code"); }
            set { _bag["Code"] = value; }
        }

        public System.String Name
        {
            get { return GetValue<System.String>("Name"); }
            set { _bag["Name"] = value; }
        }

        public System.Boolean AllowChildNodes
        {
            get { return GetValue<System.Boolean>("AllowChildNodes"); }
            set { _bag["AllowChildNodes"] = value; }
        }

        public System.Int32 MaxChildLevels
        {
            get { return GetValue<System.Int32>("MaxChildLevels"); }
            set { _bag["MaxChildLevels"] = value; }
        }

        public System.Boolean IsSystem
        {
            get { return GetValue<System.Boolean>("IsSystem"); }
            set { _bag["IsSystem"] = value; }
        }

        public System.Int32? DefaultValue
        {
            get { return GetValue<System.Int32?>("DefaultValue"); }
            set { _bag["DefaultValue"] = value; }
        }

        public System.DateTime CreatedOn
        {
            get { return GetValue<System.DateTime>("CreatedOn"); }
            set { _bag["CreatedOn"] = value; }
        }

        public System.Int32 CreatedBy
        {
            get { return GetValue<System.Int32>("CreatedBy"); }
            set { _bag["CreatedBy"] = value; }
        }

        public System.DateTime? UpdatedOn
        {
            get { return GetValue<System.DateTime?>("UpdatedOn"); }
            set { _bag["UpdatedOn"] = value; }
        }

        public System.Int32? UpdatedBy
        {
            get { return GetValue<System.Int32?>("UpdatedBy"); }
            set { _bag["UpdatedBy"] = value; }
        }

        #endregion
        
        #region Read-Only

        public bool DataOptionTypeSortIDHasValue
        {
            get { return _bag.ContainsKey("DataOptionTypeSortID"); }
        }

        public bool DefaultValueHasValue
        {
            get { return _bag.ContainsKey("DefaultValue"); }
        }

        public bool UpdatedOnHasValue
        {
            get { return _bag.ContainsKey("UpdatedOn"); }
        }

        public bool UpdatedByHasValue
        {
            get { return _bag.ContainsKey("UpdatedBy"); }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].[DataOptionType]";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public  string ToString()
        {
            var result = String.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !String.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
    }
}