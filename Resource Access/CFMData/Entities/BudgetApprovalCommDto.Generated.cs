//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BudgetApprovalComm.cs'.
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
    public partial class BudgetApprovalCommDTO
    {
 #region Contructor(s)

        public BudgetApprovalCommDTO()
        { /* Require use of factory methods */ }

        #endregion

public BudgetApprovalComm CopyDTO(BudgetApprovalComm obj)
		{
			 
			obj.BudgetApprovalID =this.BudgetApprovalID ;
			obj.CommsDate =this.CommsDate ;
			obj.Narration =this.Narration ;
			obj.IsActive =this.IsActive ;
			return obj;
		}
        #region Properties

        public System.Int32 BudgetApprovalCommsID { get; set; }
        public System.Int32 BudgetApprovalID { get; set; }
        public System.DateTime? CommsDate { get; set; }
        public System.String Narration { get; set; }
        public System.Boolean IsActive { get; set; }
        public System.Int32 CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Int32? UpdatedBy { get; set; }
        public System.DateTime? UpdatedOn { get; set; }

	
	
	
	
	
	
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
        public void LoadCreatedByApplicationUser(BudgetApprovalComm obj)
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
        public void LoadUpdatedByApplicationUser(BudgetApprovalComm obj)
		{
			if(obj.UpdatedByApplicationUser!=null)
			{
				_updatedByApplicationUserProperty=obj.UpdatedByApplicationUser.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}