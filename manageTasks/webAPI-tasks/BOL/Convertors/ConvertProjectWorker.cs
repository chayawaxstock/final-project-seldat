using BOL.HelpModel;
using BOL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Convertors
{
    public class ConvertProjectWorker
    {
        public static ProjectWorker convertDBtoProjectWorkersWithProjectAndUser(MySqlDataReader readerRow)
        {
            return new ProjectWorker()
            {
                ProjectId = readerRow.GetInt32(8),
                HoursForProject = readerRow.IsDBNull(9) ? 0 : readerRow.GetDecimal(9),
                UserId = readerRow.GetInt32(10),
                User = new UserWithoutPassword()
                {
                    UserId = readerRow.GetInt32(11),
                    UserName = readerRow.GetString(12),
                    UserComputer = readerRow.IsDBNull(13) ? "" : readerRow.GetString(13),
                
                    DepartmentId = readerRow.GetInt32(15),
                    Email = readerRow.GetString(16),
                    NumHoursWork = readerRow.GetDecimal(17),
                    ManagerId = readerRow.IsDBNull(18) ? 0 : readerRow.GetInt32(18),
                },
                Project = new Project()
                {
                    ProjectId = readerRow.GetInt32(0),
                    numHourForProject = readerRow.GetDecimal(1),
                    ProjectName = readerRow.GetString(2),
                    DateBegin = readerRow.GetMySqlDateTime(3).GetDateTime(),
                    DateEnd = readerRow.GetMySqlDateTime(4).GetDateTime(),
                    IsFinish = readerRow.GetBoolean(5),
                    CustomerName = readerRow.GetString(6),
                    IdManager = readerRow.GetInt32(7),
                }
            };

        }


        public static ProjectWorker convertDBtoProjectWorkersWithProjectAndUser1(MySqlDataReader readerRow)
        {
            return new ProjectWorker()
            {
                ProjectId = readerRow.GetInt32(0),
                UserId = readerRow.GetInt32(1),
                HoursForProject = readerRow.IsDBNull(2) ? 0 : readerRow.GetDecimal(2),
                Project = new Project()
                {
                    ProjectName = readerRow.GetString(3),
                },
                User = new UserWithoutPassword()
                {
                    UserName = readerRow.GetString(4),  
                }
               
            };

        }

        public static ProjectWorker convertDBtoProjectWorkersWithProject(MySqlDataReader readerRow)
        {
            return new ProjectWorker()
            {
                ProjectId = readerRow.GetInt32(0),
                HoursForProject = readerRow.IsDBNull(1) ? 0 : readerRow.GetDecimal(1),
                UserId = readerRow.GetInt32(2),
                Project = new Project()
                {
                    ProjectId = readerRow.GetInt32(3),
                    numHourForProject = readerRow.GetDecimal(4),
                    ProjectName = readerRow.GetString(5),
                    DateBegin = readerRow.GetMySqlDateTime(6).GetDateTime(),
                    DateEnd = readerRow.GetMySqlDateTime(7).GetDateTime(),
                    IsFinish = readerRow.GetBoolean(8),
                    CustomerName = readerRow.GetString(9),
                    IdManager = readerRow.GetInt32(10),
                }
            };

        }

    }
}
