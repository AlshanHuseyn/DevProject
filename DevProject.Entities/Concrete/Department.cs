using DevProject.Core.Entities.Abstract;
using System.Collections.Generic;

namespace DevProject.Entities.Concrete
{
    public class Department : IEntity
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public List<AppUser> Personals { get; set; }

        public List<Job> Jobs { get; set; }
    }
}
