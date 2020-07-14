using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.DTO.DTOs.UserDtos
{
    public class UserListDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        public List<AppUser> Users { get; set; }

        public Job Job { get; set; }
    }
}
