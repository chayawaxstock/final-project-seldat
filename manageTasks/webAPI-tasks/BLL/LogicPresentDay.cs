using _00_DAL;
using BOL;
using BOL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class LogicPresentDay
    {

        public static List<PresentDay> GetAllPresents()
        {
            string query = $"SELECT * FROM managetasks.PresentDayUser;";
            //TODO:לגמור לעדכן
            Func<MySqlDataReader, List<PresentDay>> func = (reader) =>
            {
                List<PresentDay> presentDays = new List<PresentDay>();
                while (reader.Read())
                {
                    presentDays.Add(new PresentDay
                    {
                        PresentDayId=reader.GetInt32(0),
                        UserId=reader.GetInt32(1),
                        ProjectId=reader.GetInt32(2)
                    });
                }
                return presentDays;
            };

            return DBAccess.RunReader(query, func);
        }

        public static PresentDay GetPresent(int idWorker,int idProject)
        {
            string query = $"SELECT Name FROM managetasks.PresentDayUser WHERE projectid={idProject} and workerid={idWorker}";
            
           

            Func<MySqlDataReader, List<PresentDay>> func = (reader) =>
            {
                List<PresentDay> presentDays = new List<PresentDay>();
                while (reader.Read())
                {
                    presentDays.Add(new PresentDay
                    {
                        PresentDayId = reader.GetInt32(0),
                        TimeBegin = reader.GetDateTime(1),
                        TimeEnd = reader.GetDateTime(2),
                        ProjectId = reader.GetInt32(4),
                        UserId = reader.GetInt32(5)
                    });
                }
                return presentDays;
            };

            return DBAccess.RunReader(query, func)[0];
        }
        public static PresentDay GetPresentByWorkerId(int idWorker)
        {
            string query = $"SELECT Name FROM managetasks.PresentDay WHERE  workerid={idWorker}";



            Func<MySqlDataReader, List<PresentDay>> func = (reader) =>
            {
                List<PresentDay> presentDays = new List<PresentDay>();
                while (reader.Read())
                {
                    presentDays.Add(new PresentDay
                    {
                        PresentDayId = reader.GetInt32(0),
                        TimeBegin = reader.GetDateTime(1),
                        TimeEnd = reader.GetDateTime(2),
                        ProjectId = reader.GetInt32(4),
                        UserId = reader.GetInt32(5)
                    });
                }
                return presentDays;
            };

            return DBAccess.RunReader(query, func)[0];
        }

        public static bool RemovePresent(int id)
        {
            string query = $"DELETE FROM managetasks.PresentDay WHERE presentid={id}";
            return DBAccess.RunNonQuery(query) == 1;
        }

        public static bool UpdatePresent(PresentDay present)
        {
            string dateBegin = present.TimeBegin.ToString("yyyy-MM-dd hh:mm:ssss");
            string dateEnd = present.TimeEnd.ToString("yyyy-MM-dd hh:mm:ssss");
            string query = $"set @id=0;select max(presentDayId) into @id from presentday where id = {present.UserId} and projectId ={present.ProjectId}; UPDATE `managertasks`.`presentday`SET`timeEnd` = '{dateEnd}' WHERE presentDayId = @id and id ={present.UserId} and projectId = {present.ProjectId}";
            return DBAccess.RunNonQuery(query) != null;
        }

        public static bool AddPresent(PresentDay presentDay)
        {
            //TODO:לעדכן את סך השעות שהעובד עבד
            string dateBegin = presentDay.TimeBegin.ToString("yyyy-MM-dd hh:mm:ssss");
            string dateEnd = presentDay.TimeEnd.ToString("yyyy-MM-dd hh:mm:ssss");
            string query = $"INSERT INTO `managertasks`.`PresentDay`(`timeBegin`,`timeEnd`,`projectId`,`id`) VALUES('{dateBegin}','{dateEnd}',{presentDay.ProjectId},{presentDay.UserId}); ";
            return DBAccess.RunNonQuery(query) == 1;
        }
    }
}
