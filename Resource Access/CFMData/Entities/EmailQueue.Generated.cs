//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'EmailQueue.cs'.
//
//     Template path: EditableRoot.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CFMData
{
    [Serializable]
    public partial class EmailQueue 
    {
        #region Contructor(s)

        public EmailQueue()
        { /* Require use of factory methods */ }

        #endregion

			public EmailQueue  Save()
      {
        if (this.IsNew)
        {
            DataPortal_Insert();
			this.IsNew=false;
        }
        else
        {
            DataPortal_Update();
        }

        return this;
      }
	  
			public bool IsDirty=false;
			public bool IsNew=true;
			#region Properties
		
			private EmailQueueDTO _currentDto = null;
			public EmailQueueDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _emailQueueIDProperty  ;
			public System.Int32 EmailQueueID
			{
				get { return _emailQueueIDProperty; }
				set
				{ 
                 
					if (_emailQueueIDProperty != value){
						IsDirty = true;
					}
					_emailQueueIDProperty=value; 
				}
			}

			private System.Int32? _mailingTemplateIDProperty  = null;
			public System.Int32? MailingTemplateID
			{
				get { return _mailingTemplateIDProperty; }
				set
				{ 
                 
					if (_mailingTemplateIDProperty != value){
						IsDirty = true;
					}
					_mailingTemplateIDProperty=value; 
				}
			}

			private System.String _sendToProperty  = null;
			public System.String SendTo
			{
				get { return _sendToProperty; }
				set
				{ 
                 
					if (_sendToProperty != value){
						IsDirty = true;
					}
					_sendToProperty=value; 
				}
			}

			private System.String _mailingTextProperty  = null;
			public System.String MailingText
			{
				get { return _mailingTextProperty; }
				set
				{ 
                 
					if (_mailingTextProperty != value){
						IsDirty = true;
					}
					_mailingTextProperty=value; 
				}
			}

			private System.String _mailingSubjectProperty  = null;
			public System.String MailingSubject
			{
				get { return _mailingSubjectProperty; }
				set
				{ 
                 
					if (_mailingSubjectProperty != value){
						IsDirty = true;
					}
					_mailingSubjectProperty=value; 
				}
			}

			private System.String _mailingFromProperty  = null;
			public System.String MailingFrom
			{
				get { return _mailingFromProperty; }
				set
				{ 
                 
					if (_mailingFromProperty != value){
						IsDirty = true;
					}
					_mailingFromProperty=value; 
				}
			}

			private System.DateTime _requestedDateProperty  ;
			public System.DateTime RequestedDate
			{
				get { return _requestedDateProperty; }
				set
				{ 
                 
					if (_requestedDateProperty != value){
						IsDirty = true;
					}
					_requestedDateProperty=value; 
				}
			}

			private System.DateTime? _processedDateProperty  = null;
			public System.DateTime? ProcessedDate
			{
				get { return _processedDateProperty; }
				set
				{ 
                 
					if (_processedDateProperty != value){
						IsDirty = true;
					}
					_processedDateProperty=value; 
				}
			}

			private System.String _processResultProperty  = null;
			public System.String ProcessResult
			{
				get { return _processResultProperty; }
				set
				{ 
                 
					if (_processResultProperty != value){
						IsDirty = true;
					}
					_processResultProperty=value; 
				}
			}

			// ManyToZeroOrOne
			private bool _mailingTemplatePropertyChecked = false;
			private MailingTemplate _mailingTemplateProperty = null;
			public MailingTemplate MailingTemplate
			{
				get
				{
                    if(!MailingTemplateID.HasValue) 
					return null;

					if(!_mailingTemplatePropertyChecked)
					{						
						var criteria = new CFMData.MailingTemplateCriteria {};
						if(MailingTemplateID.HasValue) criteria.MailingTemplateID = MailingTemplateID.Value;
						_mailingTemplatePropertyChecked=true;                       
						_mailingTemplateProperty= CFMData.MailingTemplate.GetByMailingTemplateID(MailingTemplateID.Value);
					}                
					return _mailingTemplateProperty;
				}
			}


        #endregion
		public bool IsChildDirty()
		{
		
		


			return false;
		}

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="EmailQueue"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="EmailQueue"/>.</returns>    
        public static EmailQueue NewEmailQueue()
        {
            EmailQueue obj=new EmailQueue();

            return obj;
        }

			public static EmailQueue GetEmailQueue(Func<IDataReader, EmailQueue> rowParser,SqlDataReader reader)
			{
				EmailQueue obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="EmailQueue"/> object of the specified criteria. 
        /// </summary>
        /// <param name="emailQueueID">No additional detail available.</param>
        /// <returns>A <see cref="EmailQueue"/> object of the specified criteria.</returns>
        public static EmailQueue GetByEmailQueueID(System.Int32 emailQueueID)
        {
            var criteria = new EmailQueueCriteria {EmailQueueID = emailQueueID};
            
            
          return  new EmailQueue().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="EmailQueue"/> object of the specified criteria. 
        /// </summary>
        /// <param name="mailingTemplateID">No additional detail available.</param>
        /// <returns>A <see cref="EmailQueue"/> object of the specified criteria.</returns>
        public static EmailQueue GetByMailingTemplateID(System.Int32? mailingTemplateID)
        {
            var criteria = new EmailQueueCriteria {};
                            if(mailingTemplateID.HasValue) criteria.MailingTemplateID = mailingTemplateID.Value;
            
          return  new EmailQueue().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteEmailQueue(System.Int32 emailQueueID)
        {
            var criteria = new EmailQueueCriteria {EmailQueueID = emailQueueID};
            
            
             new EmailQueue().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="EmailQueue"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="EmailQueueCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(EmailQueueCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="EmailQueue"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="EmailQueue"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="EmailQueue"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="EmailQueue"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="EmailQueue"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="EmailQueueCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(EmailQueueCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="EmailQueue"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="EmailQueue"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="EmailQueueCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(EmailQueueCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="EmailQueue"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="EmailQueue"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="EmailQueue"/> object. 
        /// </summary>
        partial void OnChildInserting(MailingTemplate mailingTemplate, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="EmailQueue"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="EmailQueue"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildUpdating(MailingTemplate mailingTemplate, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="EmailQueue"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="EmailQueue"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="EmailQueueCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(EmailQueueCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="EmailQueue"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="EmailQueueCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(EmailQueueCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="EmailQueue"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the EmailQueue table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="EmailQueue"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static EmailQueue Exists(EmailQueueCriteria criteria)
        {
			try
			{
					
				return new EmailQueue().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}