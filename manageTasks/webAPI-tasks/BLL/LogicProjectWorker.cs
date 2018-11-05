using _00_DAL;
using BOL.Convertors;
using BOL.HelpModel;
using BOL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class LogicProjectWorker
    {

        public static bool UpdateProjectWorker(ProjectWorker projectWorker)
        {
            string query = $"UPDATE managertasks.projectworker SET `hoursForProject` = {projectWorker.HoursForProject}  WHERE id={projectWorker.UserId} and projectId ={projectWorker.ProjectId}  ";
            return DBAccess.RunNonQuery(query) == 1;
        }


        public static List<UserWithoutPassword> GetWorkerNotInProject(int projectId)
        {
            string query = $"SELECT * FROM managertasks.user WHERE id not in(SELECT id FROM projectworker WHERE projectId={projectId} GROUP BY id)";
            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> userNotInProject = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    userNotInProject.Add(ConvertorUser.convertDBtoUser1(reader));
                }
                return userNotInProject;
            };
            return DBAccess.RunReader(query, func);
        }


        public static List<UserWithoutPassword> getWorkerInProject(int projectId)
        {
            string query = $"SELECT u.*, d.* FROM managertasks.user u JOIN managertasks.department d  ON u.departmentUserId = d.id join projectworker p on u.id = p.id where p.projectId = {projectId }";
        
            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> userNotInProject = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    userNotInProject.Add(ConvertorUser.convertDBtoUser(reader));
                }
                return userNotInProject;
            };
            return DBAccess.RunReader(query, func);
        }

    }
}
