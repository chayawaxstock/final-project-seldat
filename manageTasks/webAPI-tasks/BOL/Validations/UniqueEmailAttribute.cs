﻿
using BOL.HelpModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Validations
{
    class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            try
            {
                //Take userId and email of the user parameter
                int userId = (validationContext.ObjectInstance as UserWithoutPassword).UserId;
                string email = value.ToString();

                //Invoke method 'getAllUsers' from 'UserService' in 'BLL project' by reflection (not by adding reference!)

                //1. Load 'BLL' project
                Assembly assembly = Assembly.LoadFrom(@"C:\Users\user1\Desktop\final-project-seldat\manageTasks\webAPI-tasks\BLL\bin\Debug\BLL.dll");

                //2. Get 'UserService' type
                Type userServiceType = assembly.GetTypes().First(t => t.Name.Equals("LogicManager"));

                //3. Get 'GetAllUsers' method
                MethodInfo getAllUsersMethod = userServiceType.GetMethods().First(m => m.Name.Equals("GetAllUsers"));

                //4. Invoke this method
                List<UserWithoutPassword> users = getAllUsersMethod.Invoke(Activator.CreateInstance(userServiceType), new object[] { }) as List<UserWithoutPassword>;

                //The result of this method is list of users

                //check if email of the user parameter is unique
                bool isUnique =users.Any(user => user.Email.Equals(email)&&user.UserId!=userId) == false;
                if (isUnique == false)
                {
                    ErrorMessage = "email nust be unique";
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
