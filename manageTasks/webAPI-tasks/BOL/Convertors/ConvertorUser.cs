
using BOL.HelpModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Convertors
{
  public class ConvertorUser
    {
        public static UserWithoutPassword convertDBtoUser(MySqlDataReader readerRow)
        {
            //TODO:לעדכן את הסטטוס של המשתמש באוביקט
            return new UserWithoutPassword() {
                UserId = readerRow.GetInt32(0),
                UserName = readerRow.GetString(1),
                UserComputer = readerRow.IsDBNull(2)?"": readerRow.GetString(2),
                DepartmentId = readerRow.GetInt32(4),
                Email = readerRow.GetString(5),
                NumHoursWork = readerRow.GetDecimal(6),
                ManagerId = readerRow.IsDBNull(7)?0:readerRow.GetInt32(7),
                DepartmentUser=new Models.DepartmentUser()
                {
                    Id=readerRow.GetInt32(8),
                    Department=readerRow.GetString(9)
                }
            };
        }


        public static UserWithoutPassword convertDBtoUser1(MySqlDataReader readerRow)
        {
            //TODO:לעדכן את הסטטוס של המשתמש באוביקט
            return new UserWithoutPassword()
            {
                UserId = readerRow.GetInt32(0),
                UserName = readerRow.GetString(1),
                UserComputer = readerRow.IsDBNull(2) ? "" : readerRow.GetString(2),
                DepartmentId = readerRow.GetInt32(4),
                Email = readerRow.GetString(5),
                NumHoursWork = readerRow.GetDecimal(6),
                ManagerId = readerRow.IsDBNull(7) ? 0 : readerRow.GetInt32(7),
               
            };
        }

        public static User convertDBtoConfirm(MySqlDataReader readerRow)
        {
            //TODO:לעדכן את הסטטוס של המשתמש באוביקט
            return new User()
            {
                UserId = readerRow.GetInt32(0),
                UserName = readerRow.GetString(1),
                UserComputer = readerRow.IsDBNull(2) ? "" : readerRow.GetString(2),
                Password=readerRow.GetString(3),
                DepartmentId = readerRow.GetInt32(4),
                Email = readerRow.GetString(5),
                NumHoursWork = readerRow.GetDecimal(6),
                ManagerId = readerRow.IsDBNull(7) ? 0 : readerRow.GetInt32(7),
                DepartmentUser = new Models.DepartmentUser()
                {
                    Id = readerRow.GetInt32(8),
                    Department = readerRow.GetString(9)
                }
            };
        }


        public static UserWithoutPassword convertDBtoNameUser(MySqlDataReader readerRow)
        {
            //TODO:לעדכן את הסטטוס של המשתמש באוביקט
            return new UserWithoutPassword()
            {
                UserId = readerRow.GetInt32(0),
                UserName = readerRow.GetString(1),
            };
        }
    }
}
