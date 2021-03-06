//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BusinessDivision.cs'.
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
    public partial class BusinessDivision 
    {
        #region Contructor(s)

        public BusinessDivision()
        { /* Require use of factory methods */ }

        #endregion

			public BusinessDivision  Save()
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
		
			private BusinessDivisionDTO _currentDto = null;
			public BusinessDivisionDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _businessDivisionIDProperty  ;
			public System.Int32 BusinessDivisionID
			{
				get { return _businessDivisionIDProperty; }
				set
				{ 
                 
					if (_businessDivisionIDProperty != value){
						IsDirty = true;
					}
					_businessDivisionIDProperty=value; 
				}
			}

			private System.String _codeProperty  ;
			public System.String Code
			{
				get { return _codeProperty; }
				set
				{ 
                 
					if (_codeProperty != value){
						IsDirty = true;
					}
					_codeProperty=value; 
				}
			}

			private System.String _nameProperty  = null;
			public System.String Name
			{
				get { return _nameProperty; }
				set
				{ 
                 
					if (_nameProperty != value){
						IsDirty = true;
					}
					_nameProperty=value; 
				}
			}

			private System.Int32 _businessEntityIDProperty  ;
			public System.Int32 BusinessEntityID
			{
				get { return _businessEntityIDProperty; }
				set
				{ 
                 
					if (_businessEntityIDProperty != value){
						IsDirty = true;
					}
					_businessEntityIDProperty=value; 
				}
			}

			// ManyToOne
			private bool _businessEntityPropertyChecked = false;
			private BusinessEntity _businessEntityProperty = null;
			public BusinessEntity BusinessEntity
			{
				get
				{
					if(!_businessEntityPropertyChecked)
					{						
						var criteria = new CFMData.BusinessEntityCriteria {BusinessEntityID = BusinessEntityID};
						
						_businessEntityPropertyChecked=true;                       
						_businessEntityProperty= CFMData.BusinessEntity.GetByBusinessEntityID(BusinessEntityID);
					}                
					return _businessEntityProperty;
				}
			}

			// ZeroOrOneToMany
			//PropertyInfo<ApplicationPermissionList>
			private bool _applicationPermissionsPropertyChecked = false;
			private ApplicationPermissionList _applicationPermissionsProperty = null;
			public ApplicationPermissionList ApplicationPermissions
			{
				get
				{
					if(!_applicationPermissionsPropertyChecked )
					{
						_applicationPermissionsPropertyChecked =true; 
						var criteria = new CFMData.ApplicationPermissionCriteria {BusinessDivisionID = BusinessDivisionID};
						                        
						_applicationPermissionsProperty= CFMData.ApplicationPermissionList.GetByBusinessDivisionID(BusinessDivisionID);
 
					}
					return _applicationPermissionsProperty;
				}
			}

			// OneToMany
			//PropertyInfo<BusinessAreaList>
			private bool _businessAreasPropertyChecked = false;
			private BusinessAreaList _businessAreasProperty = null;
			public BusinessAreaList BusinessAreas
			{
				get
				{
					if(!_businessAreasPropertyChecked )
					{
						_businessAreasPropertyChecked =true; 
						var criteria = new CFMData.BusinessAreaCriteria {BusinessDivisionID = BusinessDivisionID};
						                        
						_businessAreasProperty= CFMData.BusinessAreaList.GetByBusinessDivisionID(BusinessDivisionID);
 
					}
					return _businessAreasProperty;
				}
			}


        #endregion
		public bool IsChildDirty()
		{
		
		
			 
			if(_applicationPermissionsPropertyChecked)
			{
					if(_applicationPermissionsProperty != null)
					{
						foreach (ApplicationPermission childObj in _applicationPermissionsProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 

			 
			if(_businessAreasPropertyChecked)
			{
					if(_businessAreasProperty != null)
					{
						foreach (BusinessArea childObj in _businessAreasProperty)
                        {
                            if (childObj.IsDirty || childObj.IsChildDirty())
                            {
                                return true;
                            }
                        }
					}
			}
			 
 



			return false;
		}

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="BusinessDivision"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="BusinessDivision"/>.</returns>    
        public static BusinessDivision NewBusinessDivision()
        {
            BusinessDivision obj=new BusinessDivision();

            return obj;
        }

			public static BusinessDivision GetBusinessDivision(Func<IDataReader, BusinessDivision> rowParser,SqlDataReader reader)
			{
				BusinessDivision obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="BusinessDivision"/> object of the specified criteria. 
        /// </summary>
        /// <param name="businessDivisionID">No additional detail available.</param>
        /// <returns>A <see cref="BusinessDivision"/> object of the specified criteria.</returns>
        public static BusinessDivision GetByBusinessDivisionID(System.Int32 businessDivisionID)
        {
            var criteria = new BusinessDivisionCriteria {BusinessDivisionID = businessDivisionID};
            
            
          return  new BusinessDivision().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="BusinessDivision"/> object of the specified criteria. 
        /// </summary>
        /// <param name="businessEntityID">No additional detail available.</param>
        /// <returns>A <see cref="BusinessDivision"/> object of the specified criteria.</returns>
        public static BusinessDivision GetByBusinessEntityID(System.Int32 businessEntityID)
        {
            var criteria = new BusinessDivisionCriteria {BusinessEntityID = businessEntityID};
            
            
          return  new BusinessDivision().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteBusinessDivision(System.Int32 businessDivisionID)
        {
            var criteria = new BusinessDivisionCriteria {BusinessDivisionID = businessDivisionID};
            
            
             new BusinessDivision().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessDivision"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BusinessDivisionCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BusinessDivisionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessDivision"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessDivision"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessDivision"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessDivision"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessDivision"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BusinessDivisionCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BusinessDivisionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BusinessDivision"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BusinessDivisionCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(BusinessDivisionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        partial void OnChildInserting(BusinessEntity businessEntity, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildUpdating(BusinessEntity businessEntity, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BusinessDivisionCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(BusinessDivisionCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="BusinessDivision"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BusinessDivisionCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BusinessDivisionCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BusinessDivision"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the BusinessDivision table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BusinessDivision"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static BusinessDivision Exists(BusinessDivisionCriteria criteria)
        {
			try
			{
					
				return new BusinessDivision().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}