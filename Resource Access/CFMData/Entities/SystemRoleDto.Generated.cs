//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'SystemRole.cs'.
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
    public partial class SystemRoleDTO
    {
 #region Contructor(s)

        public SystemRoleDTO()
        { /* Require use of factory methods */ }

        #endregion

public SystemRole CopyDTO(SystemRole obj)
		{
			 
			obj.SystemRoleID =this.SystemRoleID ;
			obj.Code =this.Code ;
			obj.Name =this.Name ;
			obj.SystemRoleTypeID =this.SystemRoleTypeID ;
			return obj;
		}
        #region Properties

        public System.Int32 SystemRoleID { get; set; }
        public System.String Code { get; set; }
        public System.String Name { get; set; }
        public System.Int32 SystemRoleTypeID { get; set; }

	// OneToMany
        public void LoadApplicationRoles(SystemRole obj)
        {
			if(obj.ApplicationRoles!=null)
			{
				_applicationRolesProperty=obj.ApplicationRoles.CurrentDTO;
			}
        }
	// OneToMany
	
        private List<ApplicationRoleDTO>  _applicationRolesProperty=new List<ApplicationRoleDTO>();
        public List<ApplicationRoleDTO> ApplicationRoles
        {
			get
			{
				return  _applicationRolesProperty;
			}
			
		}
	
	
	
	
	
	
        private SystemRoleTypeDTO  _systemRoleTypeProperty=null;
        public SystemRoleTypeDTO SystemRoleType
        {
			get
			{
				return  _systemRoleTypeProperty;
			}
			set
			{
				 _systemRoleTypeProperty=value;
			}
			
		}
        public void LoadSystemRoleType(SystemRole obj)
		{
			if(obj.SystemRoleType!=null)
			{
				_systemRoleTypeProperty=obj.SystemRoleType.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}