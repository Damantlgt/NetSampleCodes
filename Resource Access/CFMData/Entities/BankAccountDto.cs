//------------------------------------------------------------------------------
// <autogenerated>
//     
//       Changes to this template will not be lost.
//
//     Template: DTO.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;

 

namespace CFMData
{    
    /// <summary>
    /// The BankAccount class is a CSLA editable root class.  See CSLA documentation for a more detailed description.
    /// </summary>
    public partial class BankAccountDTO
    {
        public BankAccount CustomCopyDTO(BankAccount obj)
        {

            obj.BankAccountID = this.BankAccountID;
            obj.BSBNumber = this.BSBNumber;
            obj.AccountNumber = this.AccountNumber;
            obj.AccountName = this.AccountName;
            obj.BSBDetailID = this.BSBDetailID;
            obj.IsActive = this.IsActive;
  
            return obj;
        }
  }
}