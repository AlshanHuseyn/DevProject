using DevProject.Business.Abstract;
using DevProject.DataAccess.Abstract;
using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public List<Department> List()
        {
            return _departmentDal.GetList();
        }

        public Department GetById(int departmentId)
        {
            if (departmentId <= 0)
            {
                throw new System.NotImplementedException();
            }
            return _departmentDal.Get(m => m.DepartmentId == departmentId);
        }

        public void Add(Department department)
        {
            if (department == null)
            {
                throw new System.NotImplementedException();
            }

            _departmentDal.Add(department);
        }

        public void Update(Department department)
        {
            if (department == null)
            {
                throw new System.NotImplementedException();
            }

            _departmentDal.Update(department);
        }

        public void Delete(Department department)
        {
            if (department == null)
            {
                throw new System.NotImplementedException();
            }
            _departmentDal.Delete(department);
        }
    }
}
