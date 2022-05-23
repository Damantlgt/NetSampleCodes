﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BusinessArea.cs'.
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
    public partial class BusinessAreaCriteria 
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public BusinessAreaCriteria(){}

        public BusinessAreaCriteria(System.Int32 businessAreaID)
        {
            BusinessAreaID = businessAreaID;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.Int32 BusinessAreaID
        {
            get { return GetValue<System.Int32>("BusinessAreaID"); }
            set { _bag["BusinessAreaID"] = value; }
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

        public System.Int32 BusinessDivisionID
        {
            get { return GetValue<System.Int32>("BusinessDivisionID"); }
            set { _bag["BusinessDivisionID"] = value; }
        }

        #endregion
        
        #region Read-Only

        public bool NameHasValue
        {
            get { return _bag.ContainsKey("Name"); }
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
                return "[dbo].[BusinessArea]";
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