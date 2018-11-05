using _00_DAL;
using BOL;
using BOL.Convertors;
using BOL.HelpModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogicProjects
    {

        public static List<Project> GetAllProjects()
        {
            string query = $"SELECT p.*,u.* FROM managertasks.project p join user u on u.id=p.managerId";

            Func<MySqlDataReader, List<Project>> func = (reader) =>
            {
                List<Project> projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(convertProject.convertDBtoProjectsWithManager(reader));
                }
                return projects;
            };

            return DBAccess.RunReader(query, func);
        }


        public static Project GetProjectDetails(string projectName)
        {
            string query = $"SELECT * FROM managertasks.project WHERE name='{projectName}'";
            Func<MySqlDataReader, List<Project>> func = (reader) =>
            {
                List<Project> projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(new Project
                    {
                        ProjectId = reader.GetInt32(0),
                        ProjectName = reader.GetString(2),
                        CustomerName = reader.GetString(6),
                        numHourForProject = reader.GetDecimal(1),
                        DateBegin = reader.GetDateTime(3),
                        DateEnd = reader.GetDateTime(4),
                        IsFinish = reader.GetBoolean(5),
                        IdManager = reader.GetInt32(7)
                    });
                }
                return projects;
            };
            List<Project> list = DBAccess.RunReader(query, func);
            return(list!=null&&list.Count>0? list[0] : null);

        }


        public static Project GetProjectDetails(int projectId)
        {
            string query = $"SELECT * FROM managetasks.project WHERE projectId={projectId}";
            Func<MySqlDataReader, List<Project>> func = (reader) =>
            {
                List<Project> projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(new Project
                    {
                        ProjectId = reader.GetInt32(0),
                        ProjectName = reader.GetString(1),
                        CustomerName = reader.GetString(2),
                        numHourForProject = reader.GetDecimal(3),
                        DateBegin = reader.GetDateTime(4),
                        DateEnd = reader.GetDateTime(5),
                        IsFinish = reader.GetBoolean(6),
                        IdManager = reader.GetInt32(7)
                    });
                }
                return projects;
            };

            return (DBAccess.RunReader(query, func).Count() != 0 ? DBAccess.RunReader(query, func)[0] : null);

        }




        public static bool RemoveProject(string projectName)
        {
          //  int projectId = GetProjectDetails(projectName).Id;
          //  string query = $"DELETE FROM managetasks.projectworker WHERE projectid={projectId}";
          //if(DBAccess.RunNonQuery(query)!=1)
          //      return false;
          //  query = $"DELETE FROM managetasks.projectworker WHERE projectid={projectId}";
          //  if (DBAccess.RunNonQuery(query) != 1)
          //      return false;
           string query = $"DELETE FROM managetasks.hourfordepartment WHERE Name={projectName}";
            return DBAccess.RunNonQuery(query) == 1;
        }



        public static bool UpdateProject(Project project)
        {
            string query = $"UPDATE managetasks.project SET numHour='{project.numHourForProject}',name='{project.ProjectName}',dateBegin={project.DateBegin} ,dateEnd={project.DateEnd} ,isFinish='{project.IsFinish}',customerName='{project.CustomerName}'  WHERE id={project.ProjectId} ";
            return DBAccess.RunNonQuery(query) == 1;
        }
        public static bool AddWorkerToProject(int projectId,List<UserWithoutPassword> workers)
        {
           
            foreach (var item in workers)
            {
                  string query = $"INSERT INTO `managertasks`.`projectworker`(`projectId`,`id`)VALUES({ projectId},{ item.UserId})";
                if (DBAccess.RunNonQuery(query)==null)
                    return false;
            }
            return true;
        }
        

        public static bool AddProject(Project project)
        {
            //TODO:איזה דפרטמנט
            string dateBegin = project.DateBegin.ToString("yyyy-MM-dd");
            string dateEnd = project.DateEnd.ToString("yyyy-MM-dd");
            int IsFinish= project.IsFinish ? 1 : 0;

            string query = $"INSERT INTO `managertasks`.`project`(`numHour`,`name`,`dateBegin`,`dateEnd`,`isFinish`,`customerName`,`managerId`) VALUES({project.numHourForProject},'{project.ProjectName}','{dateBegin}','{dateEnd}',{IsFinish},'{project.CustomerName}',{project.IdManager}); ";
            
            if (DBAccess.RunNonQuery(query)!=null&& DBAccess.RunStore("addProject", project.IdManager)!=null)
            {

            foreach (var item in project.HoursForDepartment)
            {
                query = $"SET @EE=0;SELECT MAX(projectId) FROM project INTO @EE; INSERT INTO `managertasks`.`hourfordepartment`(`projectId`,`departmentId`,`sumHours`)VALUES(@EE,{item.DepartmentId},{item.SumHours});";
                    DBAccess.RunNonQuery(query);
                        
            }
                return true;
            }
            else return false;

        }


    }
}
