//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'MailingTemplate.cs'.
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
    public partial class MailingTemplateCriteria 
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public MailingTemplateCriteria(){}

        public MailingTemplateCriteria(System.Int32 mailingTemplateID)
        {
            MailingTemplateID = mailingTemplateID;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.Int32 MailingTemplateID
        {
            get { return GetValue<System.Int32>("MailingTemplateID"); }
            set { _bag["MailingTemplateID"] = value; }
        }

        public System.String Description
        {
            get { return GetValue<System.String>("Description"); }
            set { _bag["Description"] = value; }
        }

        public System.String MailingText
        {
            get { return GetValue<System.String>("MailingText"); }
            set { _bag["MailingText"] = value; }
        }

        public System.String MailingSubject
        {
            get { return GetValue<System.String>("MailingSubject"); }
            set { _bag["MailingSubject"] = value; }
        }

        public System.String MailingFrom
        {
            get { return GetValue<System.String>("MailingFrom"); }
            set { _bag["MailingFrom"] = value; }
        }

        public System.Int32 CreatedBy
        {
            get { return GetValue<System.Int32>("CreatedBy"); }
            set { _bag["CreatedBy"] = value; }
        }

        public System.DateTime CreatedOn
        {
            get { return GetValue<System.DateTime>("CreatedOn"); }
            set { _bag["CreatedOn"] = value; }
        }

        public System.Int32? UpdatedBy
        {
            get { return GetValue<System.Int32?>("UpdatedBy"); }
            set { _bag["UpdatedBy"] = value; }
        }

        public System.DateTime? UpdatedOn
        {
            get { return GetValue<System.DateTime?>("UpdatedOn"); }
            set { _bag["UpdatedOn"] = value; }
        }

        #endregion
        
        #region Read-Only

        public bool DescriptionHasValue
        {
            get { return _bag.ContainsKey("Description"); }
        }

        public bool MailingTextHasValue
        {
            get { return _bag.ContainsKey("MailingText"); }
        }

        public bool MailingSubjectHasValue
        {
            get { return _bag.ContainsKey("MailingSubject"); }
        }

        public bool MailingFromHasValue
        {
            get { return _bag.ContainsKey("MailingFrom"); }
        }

        public bool UpdatedByHasValue
        {
            get { return _bag.ContainsKey("UpdatedBy"); }
        }

        public bool UpdatedOnHasValue
        {
            get { return _bag.ContainsKey("UpdatedOn"); }
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
                return "[dbo].[MailingTemplate]";
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