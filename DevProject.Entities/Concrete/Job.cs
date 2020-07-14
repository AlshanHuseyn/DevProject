using DevProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace DevProject.Entities.Concrete
{
    public class Job : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int WorkingPersonalCount { get; set; }

        public int? PersonalId { get; set; }
        public AppUser User { get; set; }
        //public IList<AppUser> Personals { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Report> Reports { get; set; }
    }
}
