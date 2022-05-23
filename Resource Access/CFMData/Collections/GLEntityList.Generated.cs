﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'GLEntityList.cs'.
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
    public partial class GLEntityList : List< GLEntity>
    {    
        private List<GLEntityDTO> _currentDto =null; 
        public List<GLEntityDTO> CurrentDTO
        {
            get 
            {
                if (_currentDto==null)
                {
                    _currentDto=new List<GLEntityDTO>();
                    foreach (GLEntity entity in this)
                    {
                        _currentDto.Add(entity.CurrentDTO);
                    }
                }
                return _currentDto;
			}
            
        }
        #region Contructor(s)

        public GLEntityList()
        { 
       //     AllowNew = true;
        }

        #endregion

       

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="GLEntityList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="GLEntityList"/>.</returns>
        public static GLEntityList NewList()
        {
            return new GLEntityList();
        }      

        /// <summary>
        /// Returns a <see cref="GLEntityList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="gLEntityID">No additional detail available.</param>
        /// <returns>A <see cref="GLEntityList"/> object of the specified criteria.</returns>
        public static GLEntityList GetByGLEntityID(System.Int32 gLEntityID)
        {
            var criteria = new GLEntityCriteria{GLEntityID = gLEntityID};
            
            
          return  new GLEntityList().DataPortal_Fetch(criteria);
        }

        /// <summary>
        /// Returns a <see cref="GLEntityList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="createdBy">No additional detail available.</param>
        /// <returns>A <see cref="GLEntityList"/> object of the specified criteria.</returns>
        public static GLEntityList GetByCreatedBy(System.Int32 createdBy)
        {
            var criteria = new GLEntityCriteria{CreatedBy = createdBy};
            
            
          return  new GLEntityList().DataPortal_Fetch(criteria);
        }

        /// <summary>
        /// Returns a <see cref="GLEntityList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="entityTypeID">No additional detail available.</param>
        /// <returns>A <see cref="GLEntityList"/> object of the specified criteria.</returns>
        public static GLEntityList GetByEntityTypeID(System.Int32 entityTypeID)
        {
            var criteria = new GLEntityCriteria{EntityTypeID = entityTypeID};
            
            
          return  new GLEntityList().DataPortal_Fetch(criteria);
        }

        /// <summary>
        /// Returns a <see cref="GLEntityList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="updatedBy">No additional detail available.</param>
        /// <returns>A <see cref="GLEntityList"/> object of the specified criteria.</returns>
        public static GLEntityList GetByUpdatedBy(System.Int32? updatedBy)
        {
            var criteria = new GLEntityCriteria{};
                            if(updatedBy.HasValue) criteria.UpdatedBy = updatedBy.Value;
            
          return  new GLEntityList().DataPortal_Fetch(criteria);
        }

        public static GLEntityList GetByCriteria(GLEntityCriteria criteria)
        {
          return  new GLEntityList().DataPortal_Fetch(criteria);
//            return DataPortal.Fetch<GLEntityList>(criteria);
        }

        public static GLEntityList GetAll()
        {
          return  new GLEntityList().DataPortal_Fetch(new GLEntityCriteria());
            //return DataPortal.Fetch<GLEntityList>(new GLEntityCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods
     

     

     

     

     
 
        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="GLEntityCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(GLEntityCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="GLEntity"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="GLEntity"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="GLEntity"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
       // partial void OnAddNewCore(ref GLEntity item, ref bool cancel);

        #endregion

    }
}