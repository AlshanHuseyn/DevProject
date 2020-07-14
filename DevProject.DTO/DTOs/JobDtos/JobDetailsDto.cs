using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.DTO.DTOs.JobDtos
{
    public class JobDetailsDto
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string SurName { get; set; }
        //public string Age { get; set; }
        //public decimal Salary { get; set; }
        //public string Picture { get; set; }

        public List<AppUser> Users { get; set; }
        public Job Job { get; set; }
        public AppUser User { get; set; }
        public Department Department { get; set; }
    }
}
