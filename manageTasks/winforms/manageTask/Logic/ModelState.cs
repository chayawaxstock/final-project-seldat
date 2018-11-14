using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageTask.Logic
{
    public static class ModelState
    {
        public static List<ValidationResult> Results = new List<ValidationResult>();

        public static bool IsValid<T>(T model)
        {
            var validationContext = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            if (Validator.TryValidateObject(model, validationContext, results, true))
            {
                return true;
            }
            else
            {
                Results = results;
                return false;
            }
        }
    }
}
