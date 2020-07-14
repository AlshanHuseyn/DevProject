using DevProject.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DevProject.DTO.DTOs.JobDtos
{
    public class JobListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int? PersonalId { get; set; }
        //public AppUser User { get; set; }
        //public List<AppUser> Personals { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Report> Reports { get; set; }

        public List<Job> Jobs { get; set; }
        public Job Job { get; set; }

    }
}
