using manageTask.HelpModel;
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

namespace manageTask.Logic
{
   public class TaskRequests
    {
        public static List<ProjectWorker> GetAllTasksByUserId(int userId)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"http://localhost:61309/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"api/Users/getHoursAndProjectForUser/{userId}").Result;
            if (response.IsSuccessStatusCode)
            {
                var CardsJson = response.Content.ReadAsStringAsync().Result;
                List<ProjectWorker> workers = JsonConvert.DeserializeObject<List<ProjectWorker>>(response.Content.ReadAsStringAsync().Result);
                return workers;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }

        }
        
            public static List<ProjectWorker> getProjectsById(int userId)
        {
            HttpClient client2 = new HttpClient();
            client2.BaseAddress = new Uri(@"http://localhost:61309/");
            client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response2 = client2.GetAsync($"api/getProjectsById/{GlobalProp.CurrentUser.UserId}").Result;
            if (response2.IsSuccessStatusCode)
            {
                var CardsJson = response2.Content.ReadAsStringAsync().Result;

                List<ProjectWorker> projects = JsonConvert.DeserializeObject<List<ProjectWorker>>(response2.Content.ReadAsStringAsync().Result);
                return projects;

            }
            
              
                else
            {
                Console.WriteLine("{0} ({1})", (int)response2.StatusCode, response2.ReasonPhrase);
                return null;
            }

        }
        public static List<Project> getProjectsManager(int userId)
        {
            HttpClient client2 = new HttpClient();
            client2.BaseAddress = new Uri(@"http://localhost:61309/");
            client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response2 = client2.GetAsync($"api/getProjectsManager/{GlobalProp.CurrentUser.UserId}").Result;
            if (response2.IsSuccessStatusCode)
            {
                var CardsJson = response2.Content.ReadAsStringAsync().Result;

                List<Project> projects = JsonConvert.DeserializeObject<List<Project>>(response2.Content.ReadAsStringAsync().Result);
                return projects;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response2.StatusCode, response2.ReasonPhrase);
                return null;
            }
        }

            public static List<Project> getAllProjects()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"http://localhost:61309/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"api/getAllProjects").Result;
            if (response.IsSuccessStatusCode)
            {
                var CardsJson = response.Content.ReadAsStringAsync().Result;
                List<Project> projects = JsonConvert.DeserializeObject<List<Project>>(response.Content.ReadAsStringAsync().Result);
                if (projects != null)
                    return projects;
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }

        }

        public static Dictionary<string, decimal> getHoursUsersProject()
        {

            HttpClient client3 = new HttpClient();
            client3.BaseAddress = new Uri(@"http://localhost:61309/");
            client3.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response3 = client3.GetAsync($"api/Users/getHoursForUserProjects/{GlobalProp.CurrentUser.UserId}").Result;
            if (response3.IsSuccessStatusCode)
            {

                Dictionary<string, decimal> projectsDictionary = new Dictionary<string, decimal>();
                var CardsJson = response3.Content.ReadAsStringAsync().Result;
                List<SumHoursDoneUser> sumHoursDoneUserProjects = JsonConvert.DeserializeObject<List<SumHoursDoneUser>>(response3.Content.ReadAsStringAsync().Result);
                if (sumHoursDoneUserProjects != null)
                {


                    foreach (SumHoursDoneUser sumHoursDoneUserProject in sumHoursDoneUserProjects)
                    {

                        projectsDictionary.Add(sumHoursDoneUserProject.Label, sumHoursDoneUserProject.Data);
                    }
                    return projectsDictionary;

                }
                else return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response3.StatusCode, response3.ReasonPhrase);
                return null;
            }
        }

        public static bool adddProject(Project project)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://localhost:61309/api/Projects");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    string NewUserString = Newtonsoft.Json.JsonConvert.SerializeObject(project, Formatting.None);
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
                    return false;


                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

