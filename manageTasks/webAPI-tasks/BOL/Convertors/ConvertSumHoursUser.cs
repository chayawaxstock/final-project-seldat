using BOL.HelpModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Convertors
{
    public  class ConvertSumHoursUser
    {
        public static SumHoursDoneUser convertDBtoSumHoursUser(MySqlDataReader readerRow)
        {
            //TODO:לעדכן את הסטטוס של המשתמש באוביקט
            return new SumHoursDoneUser()
            {
                Label = readerRow.IsDBNull(3) ? "" : readerRow.GetString(3),
                Data = readerRow.IsDBNull(0) ? 0 : readerRow.GetDecimal(0)
            };
        }


        public static SumHoursUserDoneByMonth convertDBtoSumHoursUserDoneByMonth(MySqlDataReader readerRow)
        {
            
            return new SumHoursUserDoneByMonth()
            {
              ProjectName=readerRow.GetString(0),
              SumHours=readerRow.GetInt32(1),
              Month=readerRow.GetString(2)

            };
        }
    }
}
