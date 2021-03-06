//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BankTransaction.cs'.
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
    public partial class BankTransaction 
    {
        #region Contructor(s)

        public BankTransaction()
        { /* Require use of factory methods */ }

        #endregion

			public BankTransaction  Save()
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
		
			private BankTransactionDTO _currentDto = null;
			public BankTransactionDTO CurrentDTO
			{
				get { return _currentDto; }
				set { _currentDto = value; }
			}

			private System.Int32 _bankTransactionIDProperty  ;
			public System.Int32 BankTransactionID
			{
				get { return _bankTransactionIDProperty; }
				set
				{ 
                 
					if (_bankTransactionIDProperty != value){
						IsDirty = true;
					}
					_bankTransactionIDProperty=value; 
				}
			}

			private System.Int32? _bankAccountIDProperty  = null;
			public System.Int32? BankAccountID
			{
				get { return _bankAccountIDProperty; }
				set
				{ 
                 
					if (_bankAccountIDProperty != value){
						IsDirty = true;
					}
					_bankAccountIDProperty=value; 
				}
			}

			private System.Int32 _transactionDateProperty  ;
			public System.Int32 TransactionDate
			{
				get { return _transactionDateProperty; }
				set
				{ 
                 
					if (_transactionDateProperty != value){
						IsDirty = true;
					}
					_transactionDateProperty=value; 
				}
			}

			private System.String _accountNumberProperty  ;
			public System.String AccountNumber
			{
				get { return _accountNumberProperty; }
				set
				{ 
                 
					if (_accountNumberProperty != value){
						IsDirty = true;
					}
					_accountNumberProperty=value; 
				}
			}

			private System.DateTime _accountNameProperty  ;
			public System.DateTime AccountName
			{
				get { return _accountNameProperty; }
				set
				{ 
                 
					if (_accountNameProperty != value){
						IsDirty = true;
					}
					_accountNameProperty=value; 
				}
			}

			private System.String _currencyCodeProperty  ;
			public System.String CurrencyCode
			{
				get { return _currencyCodeProperty; }
				set
				{ 
                 
					if (_currencyCodeProperty != value){
						IsDirty = true;
					}
					_currencyCodeProperty=value; 
				}
			}

			private System.Decimal _closingBalanaceProperty  ;
			public System.Decimal ClosingBalanace
			{
				get { return _closingBalanaceProperty; }
				set
				{ 
                 
					if (_closingBalanaceProperty != value){
						IsDirty = true;
					}
					_closingBalanaceProperty=value; 
				}
			}

			private System.Decimal _transactionAmountProperty  ;
			public System.Decimal TransactionAmount
			{
				get { return _transactionAmountProperty; }
				set
				{ 
                 
					if (_transactionAmountProperty != value){
						IsDirty = true;
					}
					_transactionAmountProperty=value; 
				}
			}

			private System.String _transactionCodeProperty  ;
			public System.String TransactionCode
			{
				get { return _transactionCodeProperty; }
				set
				{ 
                 
					if (_transactionCodeProperty != value){
						IsDirty = true;
					}
					_transactionCodeProperty=value; 
				}
			}

			private System.String _narrativeProperty  = null;
			public System.String Narrative
			{
				get { return _narrativeProperty; }
				set
				{ 
                 
					if (_narrativeProperty != value){
						IsDirty = true;
					}
					_narrativeProperty=value; 
				}
			}

			private System.Int32? _serialNumberProperty  = null;
			public System.Int32? SerialNumber
			{
				get { return _serialNumberProperty; }
				set
				{ 
                 
					if (_serialNumberProperty != value){
						IsDirty = true;
					}
					_serialNumberProperty=value; 
				}
			}

			private System.String _segmentAccountNumberProperty  = null;
			public System.String SegmentAccountNumber
			{
				get { return _segmentAccountNumberProperty; }
				set
				{ 
                 
					if (_segmentAccountNumberProperty != value){
						IsDirty = true;
					}
					_segmentAccountNumberProperty=value; 
				}
			}

			private System.String _paymentTransactionIDProperty  = null;
			public System.String PaymentTransactionID
			{
				get { return _paymentTransactionIDProperty; }
				set
				{ 
                 
					if (_paymentTransactionIDProperty != value){
						IsDirty = true;
					}
					_paymentTransactionIDProperty=value; 
				}
			}

			private System.String _instructionIDProperty  = null;
			public System.String InstructionID
			{
				get { return _instructionIDProperty; }
				set
				{ 
                 
					if (_instructionIDProperty != value){
						IsDirty = true;
					}
					_instructionIDProperty=value; 
				}
			}

			private System.Int32? _valueDateProperty  = null;
			public System.Int32? ValueDate
			{
				get { return _valueDateProperty; }
				set
				{ 
                 
					if (_valueDateProperty != value){
						IsDirty = true;
					}
					_valueDateProperty=value; 
				}
			}

			private System.DateTime? _transactionDateTimeUTCProperty  = null;
			public System.DateTime? TransactionDateTimeUTC
			{
				get { return _transactionDateTimeUTCProperty; }
				set
				{ 
                 
					if (_transactionDateTimeUTCProperty != value){
						IsDirty = true;
					}
					_transactionDateTimeUTCProperty=value; 
				}
			}

			private System.String _debtorNameProperty  = null;
			public System.String DebtorName
			{
				get { return _debtorNameProperty; }
				set
				{ 
                 
					if (_debtorNameProperty != value){
						IsDirty = true;
					}
					_debtorNameProperty=value; 
				}
			}

			private System.String _creditorNameProperty  = null;
			public System.String CreditorName
			{
				get { return _creditorNameProperty; }
				set
				{ 
                 
					if (_creditorNameProperty != value){
						IsDirty = true;
					}
					_creditorNameProperty=value; 
				}
			}

			private System.String _endToEndIDProperty  = null;
			public System.String EndToEndID
			{
				get { return _endToEndIDProperty; }
				set
				{ 
                 
					if (_endToEndIDProperty != value){
						IsDirty = true;
					}
					_endToEndIDProperty=value; 
				}
			}

			private System.String _remittanceInformation1Property  = null;
			public System.String RemittanceInformation1
			{
				get { return _remittanceInformation1Property; }
				set
				{ 
                 
					if (_remittanceInformation1Property != value){
						IsDirty = true;
					}
					_remittanceInformation1Property=value; 
				}
			}

			private System.String _remittanceInfoformation2Property  = null;
			public System.String RemittanceInfoformation2
			{
				get { return _remittanceInfoformation2Property; }
				set
				{ 
                 
					if (_remittanceInfoformation2Property != value){
						IsDirty = true;
					}
					_remittanceInfoformation2Property=value; 
				}
			}

			private System.String _payiDTypeProperty  = null;
			public System.String PayiDType
			{
				get { return _payiDTypeProperty; }
				set
				{ 
                 
					if (_payiDTypeProperty != value){
						IsDirty = true;
					}
					_payiDTypeProperty=value; 
				}
			}

			private System.String _payIDProperty  = null;
			public System.String PayID
			{
				get { return _payIDProperty; }
				set
				{ 
                 
					if (_payIDProperty != value){
						IsDirty = true;
					}
					_payIDProperty=value; 
				}
			}

			private System.String _reversalreasonCodeProperty  = null;
			public System.String ReversalreasonCode
			{
				get { return _reversalreasonCodeProperty; }
				set
				{ 
                 
					if (_reversalreasonCodeProperty != value){
						IsDirty = true;
					}
					_reversalreasonCodeProperty=value; 
				}
			}

			private System.String _originalTransactionIDProperty  = null;
			public System.String OriginalTransactionID
			{
				get { return _originalTransactionIDProperty; }
				set
				{ 
                 
					if (_originalTransactionIDProperty != value){
						IsDirty = true;
					}
					_originalTransactionIDProperty=value; 
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

			// ManyToZeroOrOne
			private bool _bankAccountPropertyChecked = false;
			private BankAccount _bankAccountProperty = null;
			public BankAccount BankAccount
			{
				get
				{
                    if(!BankAccountID.HasValue) 
					return null;

					if(!_bankAccountPropertyChecked)
					{						
						var criteria = new CFMData.BankAccountCriteria {};
						if(BankAccountID.HasValue) criteria.BankAccountID = BankAccountID.Value;
						_bankAccountPropertyChecked=true;                       
						_bankAccountProperty= CFMData.BankAccount.GetByBankAccountID(BankAccountID.Value);
					}                
					return _bankAccountProperty;
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

			// ZeroOrOneToMany
			//PropertyInfo<GlList>
			private bool _glsPropertyChecked = false;
			private GlList _glsProperty = null;
			public GlList Gls
			{
				get
				{
					if(!_glsPropertyChecked )
					{
						_glsPropertyChecked =true; 
						var criteria = new CFMData.GlCriteria {BankTransactionID = BankTransactionID};
						                        
						_glsProperty= CFMData.GlList.GetByBankTransactionID(BankTransactionID);
 
					}
					return _glsProperty;
				}
			}


        #endregion
		public bool IsChildDirty()
		{
		
		
			 
			if(_glsPropertyChecked)
			{
					if(_glsProperty != null)
					{
						foreach (Gl childObj in _glsProperty)
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
        /// Creates a new object of type <see cref="BankTransaction"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="BankTransaction"/>.</returns>    
        public static BankTransaction NewBankTransaction()
        {
            BankTransaction obj=new BankTransaction();

            return obj;
        }

			public static BankTransaction GetBankTransaction(Func<IDataReader, BankTransaction> rowParser,SqlDataReader reader)
			{
				BankTransaction obj = rowParser(reader);
				obj.InitDTO();					
				obj.IsDirty = false;
				obj.IsNew = false;
				return obj;
			}
        
 

        /// <summary>
        /// Returns a <see cref="BankTransaction"/> object of the specified criteria. 
        /// </summary>
        /// <param name="bankTransactionID">No additional detail available.</param>
        /// <returns>A <see cref="BankTransaction"/> object of the specified criteria.</returns>
        public static BankTransaction GetByBankTransactionID(System.Int32 bankTransactionID)
        {
            var criteria = new BankTransactionCriteria {BankTransactionID = bankTransactionID};
            
            
          return  new BankTransaction().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="BankTransaction"/> object of the specified criteria. 
        /// </summary>
        /// <param name="createdBy">No additional detail available.</param>
        /// <returns>A <see cref="BankTransaction"/> object of the specified criteria.</returns>
        public static BankTransaction GetByCreatedBy(System.Int32 createdBy)
        {
            var criteria = new BankTransactionCriteria {CreatedBy = createdBy};
            
            
          return  new BankTransaction().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="BankTransaction"/> object of the specified criteria. 
        /// </summary>
        /// <param name="bankAccountID">No additional detail available.</param>
        /// <returns>A <see cref="BankTransaction"/> object of the specified criteria.</returns>
        public static BankTransaction GetByBankAccountID(System.Int32? bankAccountID)
        {
            var criteria = new BankTransactionCriteria {};
                            if(bankAccountID.HasValue) criteria.BankAccountID = bankAccountID.Value;
            
          return  new BankTransaction().DataPortal_Fetch(criteria);
           
        }

        /// <summary>
        /// Returns a <see cref="BankTransaction"/> object of the specified criteria. 
        /// </summary>
        /// <param name="updatedBy">No additional detail available.</param>
        /// <returns>A <see cref="BankTransaction"/> object of the specified criteria.</returns>
        public static BankTransaction GetByUpdatedBy(System.Int32? updatedBy)
        {
            var criteria = new BankTransactionCriteria {};
                            if(updatedBy.HasValue) criteria.UpdatedBy = updatedBy.Value;
            
          return  new BankTransaction().DataPortal_Fetch(criteria);
           
        }

        public static void DeleteBankTransaction(System.Int32 bankTransactionID)
        {
            var criteria = new BankTransactionCriteria {BankTransactionID = bankTransactionID};
            
            
             new BankTransaction().DataPortal_Delete(criteria);
        }

        #endregion
 

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BankTransaction"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BankTransactionCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BankTransactionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BankTransaction"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BankTransaction"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BankTransaction"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BankTransaction"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BankTransaction"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BankTransactionCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BankTransactionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BankTransaction"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
        #region ChildPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BankTransaction"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BankTransactionCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(BankTransactionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BankTransaction"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BankTransaction"/> object has been mapped. 
        /// </summary>
        //partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="BankTransaction"/> object. 
        /// </summary>
        partial void OnChildInserting(ApplicationUser applicationUser, BankAccount bankAccount, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BankTransaction"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BankTransaction"/> object. 
        /// </summary>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildUpdating(ApplicationUser applicationUser, BankAccount bankAccount, SqlConnection connection, ref bool cancel,SqlTransaction trans);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BankTransaction"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BankTransaction"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BankTransactionCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        //partial void OnDeleting(BankTransactionCriteria criteria, ref bool cancel);
        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the child <see cref="BankTransaction"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BankTransactionCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BankTransactionCriteria criteria, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BankTransaction"/> object with the specified criteria has been deleted. 
        /// </summary>
        //partial void OnDeleted();
        //partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
   

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the BankTransaction table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BankTransaction"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static BankTransaction Exists(BankTransactionCriteria criteria)
        {
			try
			{
					
				return new BankTransaction().DataPortal_Fetch(criteria);
			}
			catch(Exception ex)
			{
			}
			return null;
			
        }

        
        #endregion

    }
}