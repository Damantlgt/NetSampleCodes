﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'GLEntityTypeList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
 
namespace CFMData
{
    [Serializable]
    public partial class GLEntityTypeList : List< GLEntityType>
    {    
        private List<GLEntityTypeDTO> _currentDto =null; 
        public List<GLEntityTypeDTO> CurrentDTO
        {
            get 
            {
                if (_currentDto==null)
                {
                    _currentDto=new List<GLEntityTypeDTO>();
                    foreach (GLEntityType entity in this)
                    {
                        _currentDto.Add(entity.CurrentDTO);
                    }
                }
                return _currentDto;
			}
            
        }
        #region Contructor(s)

        public GLEntityTypeList()
        { 
       //     AllowNew = true;
        }

        #endregion

       

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="GLEntityTypeList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="GLEntityTypeList"/>.</returns>
        public static GLEntityTypeList NewList()
        {
            return new GLEntityTypeList();
        }      

        /// <summary>
        /// Returns a <see cref="GLEntityTypeList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="gLEntityTypeID">No additional detail available.</param>
        /// <returns>A <see cref="GLEntityTypeList"/> object of the specified criteria.</returns>
        public static GLEntityTypeList GetByGLEntityTypeID(System.Int32 gLEntityTypeID)
        {
            var criteria = new GLEntityTypeCriteria{GLEntityTypeID = gLEntityTypeID};
            
            
          return  new GLEntityTypeList().DataPortal_Fetch(criteria);
        }

        public static GLEntityTypeList GetByCriteria(GLEntityTypeCriteria criteria)
        {
          return  new GLEntityTypeList().DataPortal_Fetch(criteria);
//            return DataPortal.Fetch<GLEntityTypeList>(criteria);
        }

        public static GLEntityTypeList GetAll()
        {
          return  new GLEntityTypeList().DataPortal_Fetch(new GLEntityTypeCriteria());
            //return DataPortal.Fetch<GLEntityTypeList>(new GLEntityTypeCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods
     

     
 
        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="GLEntityType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntityType"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="GLEntityType"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="GLEntityTypeCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(GLEntityTypeCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntityType"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="GLEntityType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="GLEntityType"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntityType"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="GLEntityType"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntityType"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
       // partial void OnAddNewCore(ref GLEntityType item, ref bool cancel);

        #endregion

    }
}