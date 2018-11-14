using manageTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageTask.Validations
{
   public class ValidSumHourDepartmentAtribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;

            //sum department hours that definition to this project
            decimal hours = (value as List<HourForDepartment>).Sum(p=>p.SumHours);
            if ((validationContext.ObjectInstance as Project).numHourForProject>=hours)
                 return null;
            return new ValidationResult("date begin project less than today", new List<string>() { "DateBegin" });
        }
    }
}
