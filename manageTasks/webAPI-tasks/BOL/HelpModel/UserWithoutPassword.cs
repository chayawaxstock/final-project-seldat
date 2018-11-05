using BOL.Models;
using BOL.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.HelpModel
{
  public  class UserWithoutPassword
    {

        public UserWithoutPassword()
        {
            Projects = new List<Project>();
            PresentsDayUser = new List<PresentDay>();
            users = new List<User>();
        }

        public int UserId { get; set; }
        [Required(ErrorMessage = "name is required")]
        [MinLength(2, ErrorMessage = "name must be more than 2 chars"), MaxLength(15, ErrorMessage = "name must be less than 15 chars")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "email is required")]
        [UniqueEmail]
        [EmailAddress]
        public string Email { get; set; }
        //[MinLength(20),MaxLength(50)]
        public string UserComputer { get; set; } = "";
        public decimal NumHoursWork { get; set; } = 9;

        public int? ManagerId { get; set; }
        public int DepartmentId { get; set; }

        public DepartmentUser DepartmentUser { get; set; }
        public List<Project> Projects { get; set; }
        public User Manager { get; set; }
        public List<PresentDay> PresentsDayUser { get; set; }

        public List<User> users { get; set; }
    }
}
