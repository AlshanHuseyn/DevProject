using DevProject.Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DevProject.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int? WorkingJobCount { get; set; }
        public decimal Salary { get; set; }
        public string Picture { get; set; }

        public int? JobId { get; set; }
        public Job Job { get; set; }

        public IList<Bildirim> Bildirimler { get; set; }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
