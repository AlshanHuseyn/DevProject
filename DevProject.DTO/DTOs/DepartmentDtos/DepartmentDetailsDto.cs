using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.DTO.DTOs.DepartmentDtos
{
    public class DepartmentDetailsDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<AppUser> AppUsers { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
