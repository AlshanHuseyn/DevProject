using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.Business.Abstract
{
    public interface IDepartmentService
    {
        /// <summary>
        /// Departmenti listələmək
        /// </summary>
        /// <returns></returns>
        List<Department> List();
        /// <summary>
        /// Departmenti id-yə görə gətirmək
        /// </summary>
        /// <returns></returns>
        Department GetById(int departmentId);
        /// <summary>
        /// Department əlavə etmək
        /// </summary>
        /// <returns></returns>
        void Add(Department department);
        /// <summary>
        /// Department məlumatlarında dəyişiklik etmək
        /// </summary>
        /// <returns></returns>
        void Update(Department department);
        /// <summary>
        /// Department silmək
        /// </summary>
        /// <returns></returns>
        void Delete(Department department);

    }
}
