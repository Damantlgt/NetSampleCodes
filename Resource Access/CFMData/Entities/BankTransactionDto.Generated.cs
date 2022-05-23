﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BankTransaction.cs'.
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
    public partial class BankTransactionDTO
    {
 #region Contructor(s)

        public BankTransactionDTO()
        { /* Require use of factory methods */ }

        #endregion

public BankTransaction CopyDTO(BankTransaction obj)
		{
			 
			obj.BankAccountID =this.BankAccountID ;
			obj.TransactionDate =this.TransactionDate ;
			obj.AccountNumber =this.AccountNumber ;
			obj.AccountName =this.AccountName ;
			obj.CurrencyCode =this.CurrencyCode ;
			obj.ClosingBalanace =this.ClosingBalanace ;
			obj.TransactionAmount =this.TransactionAmount ;
			obj.TransactionCode =this.TransactionCode ;
			obj.Narrative =this.Narrative ;
			obj.SerialNumber =this.SerialNumber ;
			obj.SegmentAccountNumber =this.SegmentAccountNumber ;
			obj.PaymentTransactionID =this.PaymentTransactionID ;
			obj.InstructionID =this.InstructionID ;
			obj.ValueDate =this.ValueDate ;
			obj.TransactionDateTimeUTC =this.TransactionDateTimeUTC ;
			obj.DebtorName =this.DebtorName ;
			obj.CreditorName =this.CreditorName ;
			obj.EndToEndID =this.EndToEndID ;
			obj.RemittanceInformation1 =this.RemittanceInformation1 ;
			obj.RemittanceInfoformation2 =this.RemittanceInfoformation2 ;
			obj.PayiDType =this.PayiDType ;
			obj.PayID =this.PayID ;
			obj.ReversalreasonCode =this.ReversalreasonCode ;
			obj.OriginalTransactionID =this.OriginalTransactionID ;
			obj.IsActive =this.IsActive ;
			return obj;
		}
        #region Properties

        public System.Int32 BankTransactionID { get; set; }
        public System.Int32? BankAccountID { get; set; }
        public System.Int32 TransactionDate { get; set; }
        public System.String AccountNumber { get; set; }
        public System.DateTime AccountName { get; set; }
        public System.String CurrencyCode { get; set; }
        public System.Decimal ClosingBalanace { get; set; }
        public System.Decimal TransactionAmount { get; set; }
        public System.String TransactionCode { get; set; }
        public System.String Narrative { get; set; }
        public System.Int32? SerialNumber { get; set; }
        public System.String SegmentAccountNumber { get; set; }
        public System.String PaymentTransactionID { get; set; }
        public System.String InstructionID { get; set; }
        public System.Int32? ValueDate { get; set; }
        public System.DateTime? TransactionDateTimeUTC { get; set; }
        public System.String DebtorName { get; set; }
        public System.String CreditorName { get; set; }
        public System.String EndToEndID { get; set; }
        public System.String RemittanceInformation1 { get; set; }
        public System.String RemittanceInfoformation2 { get; set; }
        public System.String PayiDType { get; set; }
        public System.String PayID { get; set; }
        public System.String ReversalreasonCode { get; set; }
        public System.String OriginalTransactionID { get; set; }
        public System.Boolean IsActive { get; set; }
        public System.Int32 CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Int32? UpdatedBy { get; set; }
        public System.DateTime? UpdatedOn { get; set; }

	// ZeroOrOneToMany
        public void LoadGls(BankTransaction obj)
        {
			if(obj.Gls!=null)
			{
				_glsProperty=obj.Gls.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<GlDTO>  _glsProperty=new List<GlDTO>();
        public List<GlDTO> Gls
        {
			get
			{
				return  _glsProperty;
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
        public void LoadCreatedByApplicationUser(BankTransaction obj)
		{
			if(obj.CreatedByApplicationUser!=null)
			{
				_createdByApplicationUserProperty=obj.CreatedByApplicationUser.CurrentDTO;
			}
		}
		
		
        private BankAccountDTO  _bankAccountProperty=null;
        public BankAccountDTO BankAccount
        {
			get
			{
				return  _bankAccountProperty;
			}
			set
			{
				 _bankAccountProperty=value;
			}
			
		}
        public void LoadBankAccount(BankTransaction obj)
		{
			if(obj.BankAccount!=null)
			{
				_bankAccountProperty=obj.BankAccount.CurrentDTO;
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
        public void LoadUpdatedByApplicationUser(BankTransaction obj)
		{
			if(obj.UpdatedByApplicationUser!=null)
			{
				_updatedByApplicationUserProperty=obj.UpdatedByApplicationUser.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}