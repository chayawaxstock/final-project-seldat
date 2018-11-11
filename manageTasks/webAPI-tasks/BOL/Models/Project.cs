
using BOL.HelpModel;
using BOL.Models;
using BOL.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
     public class Project
    {

        public Project()
        {
            
            HoursForDepartment = new List<HourForDepartment>();
            PresentsDayUser = new List<PresentDay>();
            workers = new List<UserWithoutPassword>();
        }
        
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(15,ErrorMessage = "ProjectName grade than 15 chars"),MinLength(2,ErrorMessage = "ProjectName less than 2 chars")]
        [UniqueProjectName]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "CustomerName is required")]
        [MaxLength(15, ErrorMessage = "CustomerName grade than 15 chars"), MinLength(2, ErrorMessage = "CustomerName less than 2 chars")]
        public string CustomerName { get; set; }

        [Required]
        [Range(2,int.MaxValue,ErrorMessage = "numHourForProject not grate than 2")]
        public decimal numHourForProject { get; set; }


        [Required(ErrorMessage = "DateBegin is required")]
        [ValidDateTimeBegin]
        public DateTime DateBegin { get; set; }


        [Required(ErrorMessage = "DateEnd is required")]
        [ValidDateTimeEnd]
        public DateTime DateEnd { get; set; }

        public bool IsFinish { get; set; } = false;
        [DefaultValue(1)]
        public int IdManager { get; set; }

        public UserWithoutPassword Manager { get; set; }
        public List<HourForDepartment> HoursForDepartment { get; set; }

        public List<PresentDay> PresentsDayUser { get; set; }

        public List<UserWithoutPassword> workers { get; set; }

    }
}
