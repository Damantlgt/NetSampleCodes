//------------------------------------------------------------------------------
// <autogenerated>
//     
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'DataOptionTypeSortList.cs'.
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
    public partial class DataOptionTypeSortList : List< DataOptionTypeSort>
    {    
        private List<DataOptionTypeSortDTO> _currentDto =null; 
        public List<DataOptionTypeSortDTO> CurrentDTO
        {
            get 
            {
                if (_currentDto==null)
                {
                    _currentDto=new List<DataOptionTypeSortDTO>();
                    foreach (DataOptionTypeSort entity in this)
                    {
                        _currentDto.Add(entity.CurrentDTO);
                    }
                }
                return _currentDto;
			}
            
        }
        #region Contructor(s)

        public DataOptionTypeSortList()
        { 
       //     AllowNew = true;
        }

        #endregion

       

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="DataOptionTypeSortList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="DataOptionTypeSortList"/>.</returns>
        public static DataOptionTypeSortList NewList()
        {
            return new DataOptionTypeSortList();
        }      

        /// <summary>
        /// Returns a <see cref="DataOptionTypeSortList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="dataOptionTypeSortID">No additional detail available.</param>
        /// <returns>A <see cref="DataOptionTypeSortList"/> object of the specified criteria.</returns>
        public static DataOptionTypeSortList GetByDataOptionTypeSortID(System.Int32 dataOptionTypeSortID)
        {
            var criteria = new DataOptionTypeSortCriteria{DataOptionTypeSortID = dataOptionTypeSortID};
            
            
          return  new DataOptionTypeSortList().DataPortal_Fetch(criteria);
        }

        public static DataOptionTypeSortList GetByCriteria(DataOptionTypeSortCriteria criteria)
        {
          return  new DataOptionTypeSortList().DataPortal_Fetch(criteria);
//            return DataPortal.Fetch<DataOptionTypeSortList>(criteria);
        }

        public static DataOptionTypeSortList GetAll()
        {
          return  new DataOptionTypeSortList().DataPortal_Fetch(new DataOptionTypeSortCriteria());
            //return DataPortal.Fetch<DataOptionTypeSortList>(new DataOptionTypeSortCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods
     

     
 
        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="DataOptionTypeSort"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="DataOptionTypeSort"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="DataOptionTypeSort"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="DataOptionTypeSortCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(DataOptionTypeSortCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="DataOptionTypeSort"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="DataOptionTypeSort"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="DataOptionTypeSort"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        //partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="DataOptionTypeSort"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="DataOptionTypeSort"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="DataOptionTypeSort"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
       // partial void OnAddNewCore(ref DataOptionTypeSort item, ref bool cancel);

        #endregion

    }
}