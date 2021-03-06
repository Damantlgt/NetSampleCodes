//------------------------------------------------------------------------------
// <autogenerated>
//     
//       Changes to this template will not be lost.
//
//     Template: EditableRootList.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
 

namespace CFMData
{
    /// <summary>
    /// The SystemConfigList class is a CSLA editable root list class collection of <see cref="SystemConfig"/> objects.  See CSLA documentation for a more detailed description.
    /// </summary>
    /// <returns></returns>
    public partial class SystemConfigList
    {
    public static SystemConfigList GetForUI()
    {
        var criteria = new SystemConfigCriteria { IsForUI = true };


        return new SystemConfigList().DataPortal_Fetch(criteria);

    }
  }
}