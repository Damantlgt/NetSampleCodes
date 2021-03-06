//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Budget.cs'.
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
    public partial class BudgetDTO
    {
 #region Contructor(s)

        public BudgetDTO()
        { /* Require use of factory methods */ }

        #endregion

public Budget CopyDTO(Budget obj)
		{
			 
			obj.BudgetTypeID =this.BudgetTypeID ;
			obj.ClientID =this.ClientID ;
			obj.HomeID =this.HomeID ;
			obj.BudgetCode =this.BudgetCode ;
			obj.EffectiveDate =this.EffectiveDate ;
			obj.TemplateName =this.TemplateName ;
			obj.IsActive =this.IsActive ;
			obj.EnteredMonthly =this.EnteredMonthly ;
			obj.ScopeContribution =this.ScopeContribution ;
			obj.NumberOfBeds =this.NumberOfBeds ;
			obj.Vacancies =this.Vacancies ;
			return obj;
		}
        #region Properties

        public System.Int32 BudgetID { get; set; }
        public System.Int32 BudgetTypeID { get; set; }
        public System.Int32? ClientID { get; set; }
        public System.Int32? HomeID { get; set; }
        public System.String BudgetCode { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public System.String TemplateName { get; set; }
        public System.Boolean IsActive { get; set; }
        public System.Int32 CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Int32? UpdatedBy { get; set; }
        public System.DateTime? UpdatedOn { get; set; }
        public System.Boolean EnteredMonthly { get; set; }
        public System.Int32 ScopeContribution { get; set; }
        public System.Int32 NumberOfBeds { get; set; }
        public System.Int32 Vacancies { get; set; }

	// OneToMany
        public void LoadBudgetApprovals(Budget obj)
        {
			if(obj.BudgetApprovals!=null)
			{
				_budgetApprovalsProperty=obj.BudgetApprovals.CurrentDTO;
			}
        }
	// OneToMany
	
        private List<BudgetApprovalDTO>  _budgetApprovalsProperty=new List<BudgetApprovalDTO>();
        public List<BudgetApprovalDTO> BudgetApprovals
        {
			get
			{
				return  _budgetApprovalsProperty;
			}
			
		}
	// OneToMany
        public void LoadBudgetClientAdjustments(Budget obj)
        {
			if(obj.BudgetClientAdjustments!=null)
			{
				_budgetClientAdjustmentsProperty=obj.BudgetClientAdjustments.CurrentDTO;
			}
        }
	// OneToMany
	
        private List<BudgetClientAdjustmentDTO>  _budgetClientAdjustmentsProperty=new List<BudgetClientAdjustmentDTO>();
        public List<BudgetClientAdjustmentDTO> BudgetClientAdjustments
        {
			get
			{
				return  _budgetClientAdjustmentsProperty;
			}
			
		}
	// OneToMany
        public void LoadBudgetLines(Budget obj)
        {
			if(obj.BudgetLines!=null)
			{
				_budgetLinesProperty=obj.BudgetLines.CurrentDTO;
			}
        }
	// OneToMany
	
        private List<BudgetLineDTO>  _budgetLinesProperty=new List<BudgetLineDTO>();
        public List<BudgetLineDTO> BudgetLines
        {
			get
			{
				return  _budgetLinesProperty;
			}
			
		}
	// ZeroOrOneToMany
        public void LoadHouseBudgetGls(Budget obj)
        {
			if(obj.HouseBudgetGls!=null)
			{
				_houseBudgetGlsProperty=obj.HouseBudgetGls.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<GlDTO>  _houseBudgetGlsProperty=new List<GlDTO>();
        public List<GlDTO> HouseBudgetGls
        {
			get
			{
				return  _houseBudgetGlsProperty;
			}
			
		}
	// ZeroOrOneToMany
        public void LoadClientBudgetGls(Budget obj)
        {
			if(obj.ClientBudgetGls!=null)
			{
				_clientBudgetGlsProperty=obj.ClientBudgetGls.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<GlDTO>  _clientBudgetGlsProperty=new List<GlDTO>();
        public List<GlDTO> ClientBudgetGls
        {
			get
			{
				return  _clientBudgetGlsProperty;
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
        public void LoadCreatedByApplicationUser(Budget obj)
		{
			if(obj.CreatedByApplicationUser!=null)
			{
				_createdByApplicationUserProperty=obj.CreatedByApplicationUser.CurrentDTO;
			}
		}
		
		
        private BudgetTypeDTO  _budgetTypeProperty=null;
        public BudgetTypeDTO BudgetType
        {
			get
			{
				return  _budgetTypeProperty;
			}
			set
			{
				 _budgetTypeProperty=value;
			}
			
		}
        public void LoadBudgetType(Budget obj)
		{
			if(obj.BudgetType!=null)
			{
				_budgetTypeProperty=obj.BudgetType.CurrentDTO;
			}
		}
		
		
        private ClientDTO  _clientProperty=null;
        public ClientDTO Client
        {
			get
			{
				return  _clientProperty;
			}
			set
			{
				 _clientProperty=value;
			}
			
		}
        public void LoadClient(Budget obj)
		{
			if(obj.Client!=null)
			{
				_clientProperty=obj.Client.CurrentDTO;
			}
		}
		
		
        private HomeDTO  _homeProperty=null;
        public HomeDTO Home
        {
			get
			{
				return  _homeProperty;
			}
			set
			{
				 _homeProperty=value;
			}
			
		}
        public void LoadHome(Budget obj)
		{
			if(obj.Home!=null)
			{
				_homeProperty=obj.Home.CurrentDTO;
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
        public void LoadUpdatedByApplicationUser(Budget obj)
		{
			if(obj.UpdatedByApplicationUser!=null)
			{
				_updatedByApplicationUserProperty=obj.UpdatedByApplicationUser.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}