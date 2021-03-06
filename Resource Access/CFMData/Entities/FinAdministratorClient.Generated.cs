//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'FinAdministratorClient.cs'.
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
    public partial class FinAdministratorClient 
    {
        #region Contructor(s)

        public FinAdministratorClient()
        { /* Require use of factory methods */ }

        #endregion

			public FinAdministratorClient  Save()
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
		
			private FinAdministratorClientDTO _currentDto = null;
			public FinAdministratorClientDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _finAdministratorClientIDProperty  ;
			public System.Int32 FinAdministratorClientID
			{
				get { return _finAdministratorClientIDProperty; }
				set
				{ 
                 
					if (_finAdministratorClientIDProperty != value){
						IsDirty = true;
					}
					_finAdministratorClientIDProperty=value; 
				}
			}

			private System.Int32 _finAdministratorIDProperty  ;
			public System.Int32 FinAdministratorID
			{
				get { return _finAdministratorIDProperty; }
				set
				{ 
                 
					if (_finAdministratorIDProperty != value){
						IsDirty = true;
					}
					_finAdministratorIDProperty=value; 
				}
			}

			private System.Int32 _originalFinAdministratorIDProperty ;
			/// <summary>
			/// Holds the original value for FinAdministratorID. This is used for non identity primary keys.
			/// </summary>
			internal System.Int32 OriginalFinAdministratorID
			{
				get { return _originalFinAdministratorIDProperty; }
				set{ _originalFinAdministratorIDProperty= value; }
			}

			private System.Int32 _clientIdProperty  ;
			public System.Int32 ClientId
			{
				get { return _clientIdProperty; }
				set
				{ 
                 
					if (_clientIdProperty != value){
						IsDirty = true;
					}
					_clientIdProperty=value; 
				}
			}

			private System.DateTime _startDateProperty  ;
			public System.DateTime StartDate
			{
				get { return _startDateProperty; }
				set
				{ 
                 
					if (_startDateProperty != value){
						IsDirty = true;
					}
					_startDateProperty=value; 
				}
			}

			private System.DateTime? _endDateProperty  = null;
			public System.DateTime? EndDate
			{
				get { return _endDateProperty; }
				set
				{ 
                 
					if (_endDateProperty != value){
						IsDirty = true;
					}
					_endDateProperty=value; 
				}
			}

			private System.Boolean _isActiveProperty  ;
			public System.Boolean IsActive
			{
				get { return _isActiveProperty; }
				set
				{ 
                 
					if (_isActiveProperty != value){
						IsDirty = true;
					}
					_isActiveProperty=value; 
				}
			}

			private System.Int32 _createdByProperty  ;
			public System.Int32 CreatedBy
			{
				get { return _createdByProperty; }
				set
				{ 
                 
					if (_createdByProperty != value){
						IsDirty = true;
					}
					_createdByProperty=value; 
				}
			}

			private System.DateTime _createdOnProperty  ;
			public System.DateTime CreatedOn
			{
				get { return _createdOnProperty; }
				set
				{ 
                 
					if (_createdOnProperty != value){
						IsDirty = true;
					}
					_createdOnProperty=value; 
				}
			}

			private System.Int32? _updatedByProperty  = null;
			public System.Int32? UpdatedBy
			{
				get { return _updatedByProperty; }
				set
				{ 
                 
					if (_updatedByProperty != value){
						IsDirty = true;
					}
					_updatedByProperty=value; 
				}
			}

			private System.DateTime? _updatedOnProperty  = null;
			public System.DateTime? UpdatedOn
			{
				get { return _updatedOnProperty; }
				set
				{ 
                 
					if (_updatedOnProperty != value){
						IsDirty = true;
					}
					_updatedOnProperty=value; 
				}
			}

			// OneToZeroOrOne
			private bool _finAdministratorPropertyChecked = false;
			private FinAdministrator _finAdministratorProperty = null;
			public FinAdministrator FinAdministrator
			{
				get
				{
               
					//if (!cancel)
					{
                    if(_finAdministratorProperty==null)
                    {
                        var criteria = new CFMData.FinAdministratorCriteria {FinAdministratorID = FinAdministratorID};
                        						var obj=CFMData.FinAdministrator.Exists(criteria);
                        if(obj==null)
                            _finAdministratorProperty= CFMData.FinAdministrator.NewFinAdministrator();
                        else
                            _finAdministratorProperty=obj;
                    }
                }

                return _finAdministratorProperty; 
            }
        }

			// ManyToOne
			private bool _createdByApplicationUserPropertyChecked = false;
			private ApplicationUser _createdByApplicationUserProperty = null;
			public ApplicationUser CreatedByApplicationUser
			{
				get
				{
					if(!_createdByApplicationUserPropertyChecked)
					{						
						var criteria = new CFMData.ApplicationUserCriteria {ApplicationUserID = CreatedBy};
						
						_createdByApplicationUserPropertyChecked=true;                       
						_createdByApplicationUserProperty= CFMData.ApplicationUser.GetByApplicationUserID(CreatedBy);
					}                
					return _createdByApplicationUserProperty;
				}
			}

			// ManyToOne
			private bool _clientPropertyChecked = false;
			private Client _clientProperty = null;
			public Client Client
			{
				get
				{
					if(!_clientPropertyChecked)
					{						
						var criteria = new CFMData.ClientCriteria {ClientID = ClientId};
						
						_clientPropertyChecked=true;                       
						_clientProperty= CFMData.Client.GetByClientID(ClientId);
					}                
					return _clientProperty;
				}
			}

			// ManyToZeroOrOne
			private bool _updatedByApplicationUserPropertyChecked = false;
			private ApplicationUser _updatedByApplicationUserProperty = null;
			public ApplicationUser UpdatedByApplicationUser
			{
				get
				{
                    if(!UpdatedBy.HasValue) 
					return null;

					if(!_updatedByApplicationUserPropertyChecked)
					{						
						var criteria = new CFMData.ApplicationUserCriteria {};
						if(UpdatedBy.HasValue) criteria.ApplicationUserID = UpdatedBy.Value;
						_updatedByApplicationUserPropertyChecked=true;                       
						_updatedByApplicationUserProperty= CFMData.ApplicationUser.GetByApplicationUserID(UpdatedBy.Value);
					}                
					return _updatedByApplicationUserProperty;
				}
			}


        #endregion
		public bool IsChildDirty()
		{
		
		


			return false;
		}

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="FinAdministratorClient"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="FinAdministratorClient"/>.</returns>    
        public static FinAdministratorClient NewFinAdministratorClient()
        {
            FinAdministratorClient obj=new FinAdministratorClient();

            return obj;
        }

			public static FinAdministratorClient GetFinAdministratorClient(Func<IDataReader, FinAdministratorClient> rowParser,SqlDataReader reader)
			{
				FinAdministratorClient obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="FinAdministratorClient"/> object of the specified criteria. 
        /// </summary>
        /// <param name="finAdministratorID">No additional detail available.</param>
        /// <returns>A <see cref="FinAdministratorClient"/> object of the specified criteria.</returns>
        public static FinAdministratorClient GetByFinAdministratorID(System.Int32 finAdministratorID)
        {
            var criteria = new FinAdministratorClientCriteria {FinAdministratorID = finAdministratorID};
            
            
          return  new FinAdministratorClient().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="FinAdministratorClient"/> object of the specified criteria. 
        /// </summary>
        /// <param name="createdBy">No additional detail available.</param>
        /// <returns>A <see cref="FinAdministratorClient"/> object of the specified criteria.</returns>
        public static FinAdministratorClient GetByCreatedBy(System.Int32 createdBy)
        {
            var criteria = new FinAdministratorClientCriteria {CreatedBy = createdBy};
            
            
          return  new FinAdministratorClient().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="FinAdministratorClient"/> object of the specified criteria. 
        /// </summary>
        /// <param name="clientId">No additional detail available.</param>
        /// <returns>A <see cref="FinAdministratorClient"/> object of the specified criteria.</returns>
        public static FinAdministratorClient GetByClientId(System.Int32 clientId)
        {
            var criteria = new FinAdministratorClientCriteria {ClientId = clientId};
            
            
          return  new FinAdministratorClient().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="FinAdministratorClient"/> object of the specified criteria. 
        /// </summary>
        /// <param name="updatedBy">No additional detail available.</param>
        /// <returns>A <see cref="FinAdministratorClient"/> object of the specified criteria.</returns>
        public static FinAdministratorClient GetByUpdatedBy(System.Int32? updatedBy)
        {
            var criteria = new FinAdministratorClientCriteria {};
                            if(updatedBy.HasValue) criteria.UpdatedBy = updatedBy.Value;
            
          return  new FinAdministratorClient().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteFinAdministratorClient(System.Int32 finAdministratorID)
        {
            var criteria = new FinAdministratorClientCriteria {FinAdministratorID = finAdministratorID};
            
            
             new FinAdministratorClient().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="FinAdministratorClient"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="FinAdministratorClientCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(FinAdministratorClientCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="FinAdministratorClient"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="FinAdministratorClient"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="FinAdministratorClient"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="FinAdministratorClient"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="FinAdministratorClient"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="FinAdministratorClientCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(FinAdministratorClientCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="FinAdministratorClient"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="FinAdministratorClient"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="FinAdministratorClientCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(FinAdministratorClientCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="FinAdministratorClient"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="FinAdministratorClient"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        partial void OnChildInserting(ApplicationUser applicationUser, Client client, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="FinAdministratorClient"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildUpdating(ApplicationUser applicationUser, Client client, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="FinAdministratorClient"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="FinAdministratorClient"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="FinAdministratorClientCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(FinAdministratorClientCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="FinAdministratorClient"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="FinAdministratorClientCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(FinAdministratorClientCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="FinAdministratorClient"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the FinAdministratorClient table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="FinAdministratorClient"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static FinAdministratorClient Exists(FinAdministratorClientCriteria criteria)
        {
			try
			{
					
				return new FinAdministratorClient().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}