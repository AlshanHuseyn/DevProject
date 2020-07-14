using DevProject.Entities.Concrete;
using System;

namespace DevProject.DTO.DTOs.JobDtos
{
    public class JobUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public DateTime CreationDate { get; set; }
        public Department Department { get; set; }
    }
}
