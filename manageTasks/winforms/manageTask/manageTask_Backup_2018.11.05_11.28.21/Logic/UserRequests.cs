using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageTask.Logic
{
   public class UserRequests
    {

        public static List<User> getSimpleWorkers()
        {
            HttpClient client1 = new HttpClient();
            client1.BaseAddress = new Uri(@"http://localhost:61309/");
            client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response1 = client1.GetAsync($"api/Users/getWorkers").Result;
            if (response1.IsSuccessStatusCode)
            {
                var CardsJson = response1.Content.ReadAsStringAsync().Result;
                List<User> workers = JsonConvert.DeserializeObject<List<User>>(response1.Content.ReadAsStringAsync().Result);
                if (workers != null)
                    return workers;
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response1.StatusCode, response1.ReasonPhrase);
                return null;
            }

        }


        public static bool addWorkerToProject(int projectId,List<User>users)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($@"http://localhost:61309/api/addWorkersToProject/{projectId}");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string cardsString = Newtonsoft.Json.JsonConvert.SerializeObject(users, Formatting.None);
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

        public static bool sendMessage(int userId, Object message)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($@"http://localhost:61309/api/sendMessageToManagers/{userId}");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string cardsString = Newtonsoft.Json.JsonConvert.SerializeObject(message, Formatting.None);
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
