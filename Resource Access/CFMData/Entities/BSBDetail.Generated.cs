//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BSBDetail.cs'.
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
    public partial class BSBDetail 
    {
        #region Contructor(s)

        public BSBDetail()
        { /* Require use of factory methods */ }

        #endregion

			public BSBDetail  Save()
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
		
			private BSBDetailDTO _currentDto = null;
			public BSBDetailDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _bSBDetailIDProperty  ;
			public System.Int32 BSBDetailID
			{
				get { return _bSBDetailIDProperty; }
				set
				{ 
                 
					if (_bSBDetailIDProperty != value){
						IsDirty = true;
					}
					_bSBDetailIDProperty=value; 
				}
			}

			private System.String _bsbProperty  = null;
			public System.String Bsb
			{
				get { return _bsbProperty; }
				set
				{ 
                 
					if (_bsbProperty != value){
						IsDirty = true;
					}
					_bsbProperty=value; 
				}
			}
			public System.String BSB
			{
				get { return _bsbProperty; }
				set
				{ 
                 
					if (_bsbProperty != value){
						IsDirty = true;
					}
					_bsbProperty=value; 
				}
			}

			private System.String _bankCodeProperty  = null;
			public System.String BankCode
			{
				get { return _bankCodeProperty; }
				set
				{ 
                 
					if (_bankCodeProperty != value){
						IsDirty = true;
					}
					_bankCodeProperty=value; 
				}
			}

			private System.String _bSBNameProperty  = null;
			public System.String BSBName
			{
				get { return _bSBNameProperty; }
				set
				{ 
                 
					if (_bSBNameProperty != value){
						IsDirty = true;
					}
					_bSBNameProperty=value; 
				}
			}

			private System.String _addressProperty  = null;
			public System.String Address
			{
				get { return _addressProperty; }
				set
				{ 
                 
					if (_addressProperty != value){
						IsDirty = true;
					}
					_addressProperty=value; 
				}
			}

			private System.String _suburbProperty  = null;
			public System.String Suburb
			{
				get { return _suburbProperty; }
				set
				{ 
                 
					if (_suburbProperty != value){
						IsDirty = true;
					}
					_suburbProperty=value; 
				}
			}

			private System.String _stateProperty  = null;
			public System.String State
			{
				get { return _stateProperty; }
				set
				{ 
                 
					if (_stateProperty != value){
						IsDirty = true;
					}
					_stateProperty=value; 
				}
			}

			private System.String _postCodeProperty  = null;
			public System.String PostCode
			{
				get { return _postCodeProperty; }
				set
				{ 
                 
					if (_postCodeProperty != value){
						IsDirty = true;
					}
					_postCodeProperty=value; 
				}
			}

			private System.String _paymentSystemsProperty  = null;
			public System.String PaymentSystems
			{
				get { return _paymentSystemsProperty; }
				set
				{ 
                 
					if (_paymentSystemsProperty != value){
						IsDirty = true;
					}
					_paymentSystemsProperty=value; 
				}
			}

			// ZeroOrOneToMany
			//PropertyInfo<BankAccountList>
			private bool _bankAccountsPropertyChecked = false;
			private BankAccountList _bankAccountsProperty = null;
			public BankAccountList BankAccounts
			{
				get
				{
					if(!_bankAccountsPropertyChecked )
					{
						_bankAccountsPropertyChecked =true; 
						var criteria = new CFMData.BankAccountCriteria {BSBDetailID = BSBDetailID};
						                        
						_bankAccountsProperty= CFMData.BankAccountList.GetByBSBDetailID(BSBDetailID);
 
					}
					return _bankAccountsProperty;
				}
			}


        #endregion
		public bool IsChildDirty()
		{
		
		
			 
			if(_bankAccountsPropertyChecked)
			{
					if(_bankAccountsProperty != null)
					{
						foreach (BankAccount childObj in _bankAccountsProperty)
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
        /// Creates a new object of type <see cref="BSBDetail"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="BSBDetail"/>.</returns>    
        public static BSBDetail NewBSBDetail()
        {
            BSBDetail obj=new BSBDetail();

            return obj;
        }

			public static BSBDetail GetBSBDetail(Func<IDataReader, BSBDetail> rowParser,SqlDataReader reader)
			{
				BSBDetail obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="BSBDetail"/> object of the specified criteria. 
        /// </summary>
        /// <param name="bSBDetailID">No additional detail available.</param>
        /// <returns>A <see cref="BSBDetail"/> object of the specified criteria.</returns>
        public static BSBDetail GetByBSBDetailID(System.Int32 bSBDetailID)
        {
            var criteria = new BSBDetailCriteria {BSBDetailID = bSBDetailID};
            
            
          return  new BSBDetail().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteBSBDetail(System.Int32 bSBDetailID)
        {
            var criteria = new BSBDetailCriteria {BSBDetailID = bSBDetailID};
            
            
             new BSBDetail().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BSBDetail"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BSBDetailCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BSBDetailCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BSBDetail"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BSBDetail"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BSBDetail"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BSBDetail"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BSBDetail"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BSBDetailCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BSBDetailCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BSBDetail"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BSBDetail"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BSBDetailCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(BSBDetailCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BSBDetail"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BSBDetail"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BSBDetail"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BSBDetail"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BSBDetail"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BSBDetail"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BSBDetailCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(BSBDetailCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="BSBDetail"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BSBDetailCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BSBDetailCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BSBDetail"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the BSBDetail table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BSBDetail"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static BSBDetail Exists(BSBDetailCriteria criteria)
        {
			try
			{
					
				return new BSBDetail().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}