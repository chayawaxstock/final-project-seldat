
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOL.Validations
{
   public class UniquePasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            try
            {
                //Take userId and email of the user parameter
                int userId = (validationContext.ObjectInstance as User).UserId;
              
                string password = value.ToString();

                //Invoke method 'getAllUsers' from 'UserService' in 'BLL project' by reflection (not by adding reference!)

                //1. Load 'BLL' project
                // string s = @"\BLL\bin\Debug\BLL.dll";
             //  string x = HttpContext.Current.Server.MapPath(s);
            // string path=   AppDomain.CurrentDomain.BaseDirectory;
                
         
                  //  path = path.Substring(0, path.Length-14) + "\\BLL\\bin\\Debug\\BLL.dll";
                //@"S:\חני ולדר\manageTasks\server\BLL\bin\Debug\BLL.dll"
                Assembly assembly = Assembly.LoadFrom(@"C:\Users\user1\Desktop\final-project-seldat\manageTasks\webAPI-tasks\BLL\bin\Debug\BLL.dll");

                //2. Get 'UserService' type
                Type userServiceType = assembly.GetTypes().First(t => t.Name.Equals("LogicManager"));

                //3. Get 'GetAllUsers' method
                MethodInfo getAllUsersMethod = userServiceType.GetMethods().First(m => m.Name.Equals("ConfirmPassword"));

                //4. Invoke this method
                List<User> users = getAllUsersMethod.Invoke(Activator.CreateInstance(userServiceType), new object[] { }) as List<User>;

                //The result of this method is list of users

                
                bool isUnique = users.Any(user => user.Password.Equals(password)&&user.UserId!=userId) == false;
                if (isUnique == false)
                {
                    ErrorMessage = "password nust be unique";
                    validationResult = new ValidationResult(ErrorMessageString);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return validationResult;
        }

    }
}
