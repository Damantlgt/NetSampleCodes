﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BudgetLine.cs'.
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
    public partial class BudgetLine 
    {
        #region Contructor(s)

        public BudgetLine()
        { /* Require use of factory methods */ }

        #endregion

			public BudgetLine  Save()
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
		
			private BudgetLineDTO _currentDto = null;
			public BudgetLineDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _budgetLineIDProperty  ;
			public System.Int32 BudgetLineID
			{
				get { return _budgetLineIDProperty; }
				set
				{ 
                 
					if (_budgetLineIDProperty != value){
						IsDirty = true;
					}
					_budgetLineIDProperty=value; 
				}
			}

			private System.Int32 _budgetIDProperty  ;
			public System.Int32 BudgetID
			{
				get { return _budgetIDProperty; }
				set
				{ 
                 
					if (_budgetIDProperty != value){
						IsDirty = true;
					}
					_budgetIDProperty=value; 
				}
			}

			private System.Int32 _lineIDProperty  ;
			public System.Int32 LineID
			{
				get { return _lineIDProperty; }
				set
				{ 
                 
					if (_lineIDProperty != value){
						IsDirty = true;
					}
					_lineIDProperty=value; 
				}
			}

			private System.Int32 _orderNoProperty  ;
			public System.Int32 OrderNo
			{
				get { return _orderNoProperty; }
				set
				{ 
                 
					if (_orderNoProperty != value){
						IsDirty = true;
					}
					_orderNoProperty=value; 
				}
			}

			private System.Int32 _categoryIDProperty  ;
			public System.Int32 CategoryID
			{
				get { return _categoryIDProperty; }
				set
				{ 
                 
					if (_categoryIDProperty != value){
						IsDirty = true;
					}
					_categoryIDProperty=value; 
				}
			}

			private System.Decimal? _fortnightAmountProperty  = null;
			public System.Decimal? FortnightAmount
			{
				get { return _fortnightAmountProperty; }
				set
				{ 
                 
					if (_fortnightAmountProperty != value){
						IsDirty = true;
					}
					_fortnightAmountProperty=value; 
				}
			}

			private System.Boolean _requiresReceiptProperty  ;
			public System.Boolean RequiresReceipt
			{
				get { return _requiresReceiptProperty; }
				set
				{ 
                 
					if (_requiresReceiptProperty != value){
						IsDirty = true;
					}
					_requiresReceiptProperty=value; 
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
			private bool _budgetPropertyChecked = false;
			private Budget _budgetProperty = null;
			public Budget Budget
			{
				get
				{
					if(!_budgetPropertyChecked)
					{						
						var criteria = new CFMData.BudgetCriteria {BudgetID = BudgetID};
						
						_budgetPropertyChecked=true;                       
						_budgetProperty= CFMData.Budget.GetByBudgetID(BudgetID);
					}                
					return _budgetProperty;
				}
			}

			// ManyToOne
			private bool _budgetLineCategoryPropertyChecked = false;
			private BudgetLineCategory _budgetLineCategoryProperty = null;
			public BudgetLineCategory BudgetLineCategory
			{
				get
				{
					if(!_budgetLineCategoryPropertyChecked)
					{						
						var criteria = new CFMData.BudgetLineCategoryCriteria {BudgetLineCategoryID = CategoryID};
						
						_budgetLineCategoryPropertyChecked=true;                       
						_budgetLineCategoryProperty= CFMData.BudgetLineCategory.GetByBudgetLineCategoryID(CategoryID);
					}                
					return _budgetLineCategoryProperty;
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
        /// Creates a new object of type <see cref="BudgetLine"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="BudgetLine"/>.</returns>    
        public static BudgetLine NewBudgetLine()
        {
            BudgetLine obj=new BudgetLine();

            return obj;
        }

			public static BudgetLine GetBudgetLine(Func<IDataReader, BudgetLine> rowParser,SqlDataReader reader)
			{
				BudgetLine obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="BudgetLine"/> object of the specified criteria. 
        /// </summary>
        /// <param name="budgetLineID">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLine"/> object of the specified criteria.</returns>
        public static BudgetLine GetByBudgetLineID(System.Int32 budgetLineID)
        {
            var criteria = new BudgetLineCriteria {BudgetLineID = budgetLineID};
            
            
          return  new BudgetLine().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="BudgetLine"/> object of the specified criteria. 
        /// </summary>
        /// <param name="createdBy">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLine"/> object of the specified criteria.</returns>
        public static BudgetLine GetByCreatedBy(System.Int32 createdBy)
        {
            var criteria = new BudgetLineCriteria {CreatedBy = createdBy};
            
            
          return  new BudgetLine().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="BudgetLine"/> object of the specified criteria. 
        /// </summary>
        /// <param name="budgetID">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLine"/> object of the specified criteria.</returns>
        public static BudgetLine GetByBudgetID(System.Int32 budgetID)
        {
            var criteria = new BudgetLineCriteria {BudgetID = budgetID};
            
            
          return  new BudgetLine().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="BudgetLine"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryID">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLine"/> object of the specified criteria.</returns>
        public static BudgetLine GetByCategoryID(System.Int32 categoryID)
        {
            var criteria = new BudgetLineCriteria {CategoryID = categoryID};
            
            
          return  new BudgetLine().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="BudgetLine"/> object of the specified criteria. 
        /// </summary>
        /// <param name="updatedBy">No additional detail available.</param>
        /// <returns>A <see cref="BudgetLine"/> object of the specified criteria.</returns>
        public static BudgetLine GetByUpdatedBy(System.Int32? updatedBy)
        {
            var criteria = new BudgetLineCriteria {};
                            if(updatedBy.HasValue) criteria.UpdatedBy = updatedBy.Value;
            
          return  new BudgetLine().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteBudgetLine(System.Int32 budgetLineID)
        {
            var criteria = new BudgetLineCriteria {BudgetLineID = budgetLineID};
            
            
             new BudgetLine().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BudgetLine"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BudgetLineCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BudgetLineCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BudgetLine"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BudgetLine"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BudgetLine"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BudgetLine"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BudgetLine"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BudgetLineCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BudgetLineCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BudgetLine"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLine"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BudgetLineCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(BudgetLineCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLine"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLine"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BudgetLine"/> object. 
        /// </summary>
        partial void OnChildInserting(ApplicationUser applicationUser, Budget budget, BudgetLineCategory budgetLineCategory, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLine"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BudgetLine"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildUpdating(ApplicationUser applicationUser, Budget budget, BudgetLineCategory budgetLineCategory, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLine"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLine"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BudgetLineCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(BudgetLineCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="BudgetLine"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BudgetLineCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BudgetLineCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BudgetLine"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the BudgetLine table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BudgetLine"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static BudgetLine Exists(BudgetLineCriteria criteria)
        {
			try
			{
					
				return new BudgetLine().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}