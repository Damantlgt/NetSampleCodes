//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Address.cs'.
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
    public partial class AddressDTO
    {
 #region Contructor(s)

        public AddressDTO()
        { /* Require use of factory methods */ }

        #endregion

public Address CopyDTO(Address obj)
		{
			 
			obj.Street =this.Street ;
			obj.Suburb =this.Suburb ;
			obj.StateID =this.StateID ;
			obj.CountryID =this.CountryID ;
			obj.PostCode =this.PostCode ;
			obj.IsActive =this.IsActive ;
			return obj;
		}
        #region Properties

        public System.Int32 AddressID { get; set; }
        public System.String Street { get; set; }
        public System.String Suburb { get; set; }
        public System.Int32? StateID { get; set; }
        public System.Int32? CountryID { get; set; }
        public System.String PostCode { get; set; }
        public System.Boolean IsActive { get; set; }
        public System.Int32 CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Int32? UpdatedBy { get; set; }
        public System.DateTime? UpdatedOn { get; set; }

	// ZeroOrOneToMany
        public void LoadPhysicalAddressApplicationUsers(Address obj)
        {
			if(obj.PhysicalAddressApplicationUsers!=null)
			{
				_physicalAddressApplicationUsersProperty=obj.PhysicalAddressApplicationUsers.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<ApplicationUserDTO>  _physicalAddressApplicationUsersProperty=new List<ApplicationUserDTO>();
        public List<ApplicationUserDTO> PhysicalAddressApplicationUsers
        {
			get
			{
				return  _physicalAddressApplicationUsersProperty;
			}
			
		}
	// ZeroOrOneToMany
        public void LoadPostalAddressApplicationUsers(Address obj)
        {
			if(obj.PostalAddressApplicationUsers!=null)
			{
				_postalAddressApplicationUsersProperty=obj.PostalAddressApplicationUsers.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<ApplicationUserDTO>  _postalAddressApplicationUsersProperty=new List<ApplicationUserDTO>();
        public List<ApplicationUserDTO> PostalAddressApplicationUsers
        {
			get
			{
				return  _postalAddressApplicationUsersProperty;
			}
			
		}
	// ZeroOrOneToMany
        public void LoadClients(Address obj)
        {
			if(obj.Clients!=null)
			{
				_clientsProperty=obj.Clients.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<ClientDTO>  _clientsProperty=new List<ClientDTO>();
        public List<ClientDTO> Clients
        {
			get
			{
				return  _clientsProperty;
			}
			
		}
	// ZeroOrOneToMany
        public void LoadFinAdministrators(Address obj)
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
        public void LoadCreatedByApplicationUser(Address obj)
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
        public void LoadUpdatedByApplicationUser(Address obj)
		{
			if(obj.UpdatedByApplicationUser!=null)
			{
				_updatedByApplicationUserProperty=obj.UpdatedByApplicationUser.CurrentDTO;
			}
		}
		
		
        private DataOptionDTO  _stateDataOptionProperty=null;
        public DataOptionDTO StateDataOption
        {
			get
			{
				return  _stateDataOptionProperty;
			}
			set
			{
				 _stateDataOptionProperty=value;
			}
			
		}
        public void LoadStateDataOption(Address obj)
		{
			if(obj.StateDataOption!=null)
			{
				_stateDataOptionProperty=obj.StateDataOption.CurrentDTO;
			}
		}
		
		
        private DataOptionDTO  _countryDataOptionProperty=null;
        public DataOptionDTO CountryDataOption
        {
			get
			{
				return  _countryDataOptionProperty;
			}
			set
			{
				 _countryDataOptionProperty=value;
			}
			
		}
        public void LoadCountryDataOption(Address obj)
		{
			if(obj.CountryDataOption!=null)
			{
				_countryDataOptionProperty=obj.CountryDataOption.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}