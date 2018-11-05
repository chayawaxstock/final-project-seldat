using BOL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Convertors
{
   public class ConvertDepartment
    {

        public static DepartmentUser convertDBtoDepartment(MySqlDataReader readerRow)
        {
            return new DepartmentUser()
            {
                Id = readerRow.GetInt32(0),
                Department = readerRow.GetString(1)

            };
        }
    }
}
