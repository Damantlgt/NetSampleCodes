//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'MailingTemplate.cs'.
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
    public partial class MailingTemplateDTO
    {
 #region Contructor(s)

        public MailingTemplateDTO()
        { /* Require use of factory methods */ }

        #endregion

public MailingTemplate CopyDTO(MailingTemplate obj)
		{
			 
			obj.MailingTemplateID =this.MailingTemplateID ;
			obj.Description =this.Description ;
			obj.MailingText =this.MailingText ;
			obj.MailingSubject =this.MailingSubject ;
			obj.MailingFrom =this.MailingFrom ;
			return obj;
		}
        #region Properties

        public System.Int32 MailingTemplateID { get; set; }
        public System.String Description { get; set; }
        public System.String MailingText { get; set; }
        public System.String MailingSubject { get; set; }
        public System.String MailingFrom { get; set; }
        public System.Int32 CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Int32? UpdatedBy { get; set; }
        public System.DateTime? UpdatedOn { get; set; }

	// ZeroOrOneToMany
        public void LoadEmailQueues(MailingTemplate obj)
        {
			if(obj.EmailQueues!=null)
			{
				_emailQueuesProperty=obj.EmailQueues.CurrentDTO;
			}
        }
	// ZeroOrOneToMany
	
        private List<EmailQueueDTO>  _emailQueuesProperty=new List<EmailQueueDTO>();
        public List<EmailQueueDTO> EmailQueues
        {
			get
			{
				return  _emailQueuesProperty;
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
        public void LoadCreatedByApplicationUser(MailingTemplate obj)
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
        public void LoadUpdatedByApplicationUser(MailingTemplate obj)
		{
			if(obj.UpdatedByApplicationUser!=null)
			{
				_updatedByApplicationUserProperty=obj.UpdatedByApplicationUser.CurrentDTO;
			}
		}
		
		
			



        #endregion

    }
}