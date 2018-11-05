using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace manageTask.Logic
{
    public class UserLogic
    {
        public static b manager = new b();
        public static CompanyWorker companyWorker = new CompanyWorker();
        public static TeamLeader teamLeader = new TeamLeader();
        public static Main main = new Main();
        public static Login login = new Login();

        public static string addUser(User worker)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://localhost:61309/api/addUser");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    string NewUserString = Newtonsoft.Json.JsonConvert.SerializeObject(worker, Formatting.None);
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


                    return result;


                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static List<DepartmentUser> getAllDepartments()
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"http://localhost:61309/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"api/Department/getAllDepartments").Result;
            if (response.IsSuccessStatusCode)
            {
                var CardsJson = response.Content.ReadAsStringAsync().Result;
                List<DepartmentUser> departments = JsonConvert.DeserializeObject<List<DepartmentUser>>(response.Content.ReadAsStringAsync().Result);
                if (departments != null)
                    return departments;
                else return null;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }

        }

        public static List<User> getUserByDepartment(string department)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"http://localhost:61309/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"api/Users/getUsersByDepartment/{department}").Result;
            if (response.IsSuccessStatusCode)
            {
                var CardsJson = response.Content.ReadAsStringAsync().Result;
                List<User> teamLeaders = JsonConvert.DeserializeObject<List<User>>(response.Content.ReadAsStringAsync().Result);
                return teamLeaders;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }

        }
       

        public static string passwordToSHA(string password)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            string newPassword = hash.ToString();
            return newPassword;
        }

        public static HttpWebResponse updateUser(User editUser)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($@"http://localhost:61309/api/updateUser");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string cardsString = Newtonsoft.Json.JsonConvert.SerializeObject(editUser, Formatting.None);
                    streamWriter.Write(cardsString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                return httpResponse;



            }
            catch (Exception ex)
            {
                return null;
                
            }
        }

        public static List<User> getAllUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"http://localhost:61309/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"api/Users/getAllUsers").Result;
            if (response.IsSuccessStatusCode)
            {
                var CardsJson = response.Content.ReadAsStringAsync().Result;
                List<User> workers = JsonConvert.DeserializeObject<List<User>>(response.Content.ReadAsStringAsync().Result);
                return workers;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        public static HttpResponseMessage deleteUser(int userId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61309/");
                var response = client.DeleteAsync($"api/deleteUser/{userId}").Result;
                return response;
            }
        }

        public static List<ProjectWorker> getUserBelongProject(int projectId)
        {
            HttpClient client2 = new HttpClient();
            client2.BaseAddress = new Uri(@"http://localhost:61309/");
            client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response2 = client2.GetAsync($"api/Users/getUserBelongProject/{projectId}").Result;
            if (response2.IsSuccessStatusCode)
            {
                var CardsJson = response2.Content.ReadAsStringAsync().Result;
                List<ProjectWorker> projectWorkers = JsonConvert.DeserializeObject<List<ProjectWorker>>(response2.Content.ReadAsStringAsync().Result);
                if (projectWorkers != null)
                {
                    return projectWorkers;


                }
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response2.StatusCode, response2.ReasonPhrase);
                return null;
            }

        }
        public static List<SumHoursDoneUser> getSumHoursDoneForUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"http://localhost:61309/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"api/Users/getSumHoursDoneForUsers/{GlobalProp.CurrentUser.UserId}").Result;
            if (response.IsSuccessStatusCode)
            {
 
                var CardsJson = response.Content.ReadAsStringAsync().Result;
                List<SumHoursDoneUser> sumHoursDoneUsers = JsonConvert.DeserializeObject<List<SumHoursDoneUser>>(response.Content.ReadAsStringAsync().Result);

                if (sumHoursDoneUsers != null)
                {
                    return sumHoursDoneUsers;
                  
                }
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        public static List<User> getUsersOfTeamLeader(int teamLeaderId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"http://localhost:61309/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync($"api/Users/getUsersOfTeamLeader/{teamLeaderId}").Result;
            if (response.IsSuccessStatusCode)
            {

               
                var CardsJson = response.Content.ReadAsStringAsync().Result;
                List<User> workers = JsonConvert.DeserializeObject<List<User>>(response.Content.ReadAsStringAsync().Result);
                if (workers != null)
                {
                    return workers;

                }
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        public static bool updateProjectHours(ProjectWorker projectWorker)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($@"http://localhost:61309/api/updateProjectHours");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string cardsString = Newtonsoft.Json.JsonConvert.SerializeObject(projectWorker, Formatting.None);
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
