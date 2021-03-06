//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BusinessArea.cs'.
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
    public partial class BusinessAreaDTO
    {
 #region Contructor(s)

        public BusinessAreaDTO()
        { /* Require use of factory methods */ }

        #endregion

public BusinessArea CopyDTO(BusinessArea obj)
		{
			 
			obj.Code =this.Code ;
			obj.Name =this.Name ;
			obj.BusinessDivisionID =this.BusinessDivisionID ;
			return obj;
		}
        #region Properties

        public System.Int32 BusinessAreaID { get; set; }
        public System.String Code { get; set; }
        public System.String Name { get; set; }
        public System.Int32 BusinessDivisionID { get; set; }

	// ZeroOrOneToMany
        public void LoadApplicationPermissions(BusinessArea obj)
        {
			if(obj.ApplicationPermissions!=null)
			{
				_applicationPermissionsProperty=obj.ApplicationPermissions.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<ApplicationPermissionDTO>  _applicationPermissionsProperty=new List<ApplicationPermissionDTO>();
        public List<ApplicationPermissionDTO> ApplicationPermissions
        {
			get
			{
				return  _applicationPermissionsProperty;
			}
			
		}
	// OneToMany
        public void LoadHomes(BusinessArea obj)
        {
			if(obj.Homes!=null)
			{
				_homesProperty=obj.Homes.CurrentDTO;
			}
        }
	// OneToMany
	
        private List<HomeDTO>  _homesProperty=new List<HomeDTO>();
        public List<HomeDTO> Homes
        {
			get
			{
				return  _homesProperty;
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
        public void LoadBusinessDivision(BusinessArea obj)
		{
			if(obj.BusinessDivision!=null)
			{
				_businessDivisionProperty=obj.BusinessDivision.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}