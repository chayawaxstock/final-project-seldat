using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace manageTask.Logic
{
   public class PresentDayRequests
    {
        public static bool addPresentDay(PresentDay presentDay)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://localhost:61309/api/AddPresent");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    string NewUserString = Newtonsoft.Json.JsonConvert.SerializeObject(presentDay, Formatting.None);
                    streamWriter.Write(NewUserString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                //Gettting response
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                //Reading response
                using (var streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream(), ASCIIEncoding.ASCII))
                {
                    string result = streamReader.ReadToEnd();
                    //If Login succeeded
                    if (result != null)
                    {
                        return true;

                    }
                    else return false;


                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool updatePresentDay(PresentDay presentDay)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($@"http://localhost:61309/api/updatePresentDay");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string cardsString = Newtonsoft.Json.JsonConvert.SerializeObject(presentDay, Formatting.None);
                    streamWriter.Write(cardsString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if (httpResponse.StatusDescription == "OK")
                    return true;
                else return false;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
