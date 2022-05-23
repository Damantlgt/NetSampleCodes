﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ApplicationPermission.cs'.
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
    public partial class ApplicationPermissionDTO
    {
 #region Contructor(s)

        public ApplicationPermissionDTO()
        { /* Require use of factory methods */ }

        #endregion

public ApplicationPermission CopyDTO(ApplicationPermission obj)
		{
			 
			obj.ApplicationRoleID =this.ApplicationRoleID ;
			obj.ApplicationUserID =this.ApplicationUserID ;
			obj.BusinessAreaID =this.BusinessAreaID ;
			obj.BusinessDivisionID =this.BusinessDivisionID ;
			obj.BusinessEntityID =this.BusinessEntityID ;
			obj.HomeID =this.HomeID ;
			obj.ClientID =this.ClientID ;
			obj.IsActive =this.IsActive ;
			return obj;
		}
        #region Properties

        public System.Int32 ApplicationPermissionID { get; set; }
        public System.Int32? ApplicationRoleID { get; set; }
        public System.Int32? ApplicationUserID { get; set; }
        public System.Int32? BusinessAreaID { get; set; }
        public System.Int32? BusinessDivisionID { get; set; }
        public System.Int32? BusinessEntityID { get; set; }
        public System.Int32? HomeID { get; set; }
        public System.Int32? ClientID { get; set; }
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
        public void LoadCreatedByApplicationUser(ApplicationPermission obj)
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
        public void LoadUpdatedByApplicationUser(ApplicationPermission obj)
		{
			if(obj.UpdatedByApplicationUser!=null)
			{
				_updatedByApplicationUserProperty=obj.UpdatedByApplicationUser.CurrentDTO;
			}
		}
		
		
        private BusinessAreaDTO  _businessAreaProperty=null;
        public BusinessAreaDTO BusinessArea
        {
			get
			{
				return  _businessAreaProperty;
			}
			set
			{
				 _businessAreaProperty=value;
			}
			
		}
        public void LoadBusinessArea(ApplicationPermission obj)
		{
			if(obj.BusinessArea!=null)
			{
				_businessAreaProperty=obj.BusinessArea.CurrentDTO;
			}
		}
		
		
        private BusinessDivisionDTO  _businessDivisionProperty=null;
        public BusinessDivisionDTO BusinessDivision
        {
			get
			{
				return  _businessDivisionProperty;
			}
			set
			{
				 _businessDivisionProperty=value;
			}
			
		}
        public void LoadBusinessDivision(ApplicationPermission obj)
		{
			if(obj.BusinessDivision!=null)
			{
				_businessDivisionProperty=obj.BusinessDivision.CurrentDTO;
			}
		}
		
		
        private BusinessEntityDTO  _businessEntityProperty=null;
        public BusinessEntityDTO BusinessEntity
        {
			get
			{
				return  _businessEntityProperty;
			}
			set
			{
				 _businessEntityProperty=value;
			}
			
		}
        public void LoadBusinessEntity(ApplicationPermission obj)
		{
			if(obj.BusinessEntity!=null)
			{
				_businessEntityProperty=obj.BusinessEntity.CurrentDTO;
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
        public void LoadClient(ApplicationPermission obj)
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
        public void LoadHome(ApplicationPermission obj)
		{
			if(obj.Home!=null)
			{
				_homeProperty=obj.Home.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}