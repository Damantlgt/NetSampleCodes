//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BankAccount.cs'.
//
//     Template path: DTO.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;


using System.Collections.Generic;
 
namespace CFMData
{
    [Serializable]
    public partial class BankAccountDTO
    {
 #region Contructor(s)

        public BankAccountDTO()
        { /* Require use of factory methods */ }

        #endregion

public BankAccount CopyDTO(BankAccount obj)
		{
			 
			obj.BSBNumber =this.BSBNumber ;
			obj.AccountNumber =this.AccountNumber ;
			obj.AccountName =this.AccountName ;
			obj.BSBDetailID =this.BSBDetailID ;
			obj.IsActive =this.IsActive ;
			return obj;
		}
        #region Properties

        public System.Int32 BankAccountID { get; set; }
        public System.String BSBNumber { get; set; }
        public System.String AccountNumber { get; set; }
        public System.String AccountName { get; set; }
        public System.Int32? BSBDetailID { get; set; }
        public System.Boolean IsActive { get; set; }
        public System.Int32 CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Int32? UpdatedBy { get; set; }
        public System.DateTime? UpdatedOn { get; set; }

	// OneToMany
        public void LoadBankAccountCards(BankAccount obj)
        {
			if(obj.BankAccountCards!=null)
			{
				_bankAccountCardsProperty=obj.BankAccountCards.CurrentDTO;
			}
        }
	// OneToMany
	
        private List<BankAccountCardDTO>  _bankAccountCardsProperty=new List<BankAccountCardDTO>();
        public List<BankAccountCardDTO> BankAccountCards
        {
			get
			{
				return  _bankAccountCardsProperty;
			}
			
		}
	// ZeroOrOneToMany
        public void LoadBankTransactions(BankAccount obj)
        {
			if(obj.BankTransactions!=null)
			{
				_bankTransactionsProperty=obj.BankTransactions.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<BankTransactionDTO>  _bankTransactionsProperty=new List<BankTransactionDTO>();
        public List<BankTransactionDTO> BankTransactions
        {
			get
			{
				return  _bankTransactionsProperty;
			}
			
		}
	// ZeroOrOneToMany
        public void LoadFinAdministrators(BankAccount obj)
        {
			if(obj.FinAdministrators!=null)
			{
				_finAdministratorsProperty=obj.FinAdministrators.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<FinAdministratorDTO>  _finAdministratorsProperty=new List<FinAdministratorDTO>();
        public List<FinAdministratorDTO> FinAdministrators
        {
			get
			{
				return  _finAdministratorsProperty;
			}
			
		}
	// ZeroOrOneToMany
        public void LoadGLAccounts(BankAccount obj)
        {
			if(obj.GLAccounts!=null)
			{
				_gLAccountsProperty=obj.GLAccounts.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<GLAccountDTO>  _gLAccountsProperty=new List<GLAccountDTO>();
        public List<GLAccountDTO> GLAccounts
        {
			get
			{
				return  _gLAccountsProperty;
			}
			
		}
	
	
	
	
	
	
        private ApplicationUserDTO  _createdByApplicationUserProperty=null;
        public ApplicationUserDTO CreatedByApplicationUser
        {
			get
			{
				return  _createdByApplicationUserProperty;
			}
			set
			{
				 _createdByApplicationUserProperty=value;
			}
			
		}
        public void LoadCreatedByApplicationUser(BankAccount obj)
		{
			if(obj.CreatedByApplicationUser!=null)
			{
				_createdByApplicationUserProperty=obj.CreatedByApplicationUser.CurrentDTO;
			}
		}
		
		
        private ApplicationUserDTO  _updatedByApplicationUserProperty=null;
        public ApplicationUserDTO UpdatedByApplicationUser
        {
			get
			{
				return  _updatedByApplicationUserProperty;
			}
			set
			{
				 _updatedByApplicationUserProperty=value;
			}
			
		}
        public void LoadUpdatedByApplicationUser(BankAccount obj)
		{
			if(obj.UpdatedByApplicationUser!=null)
			{
				_updatedByApplicationUserProperty=obj.UpdatedByApplicationUser.CurrentDTO;
			}
		}
		
		
        private BSBDetailDTO  _bSBDetailProperty=null;
        public BSBDetailDTO BSBDetail
        {
			get
			{
				return  _bSBDetailProperty;
			}
			set
			{
				 _bSBDetailProperty=value;
			}
			
		}
        public void LoadBSBDetail(BankAccount obj)
		{
			if(obj.BSBDetail!=null)
			{
				_bSBDetailProperty=obj.BSBDetail.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}