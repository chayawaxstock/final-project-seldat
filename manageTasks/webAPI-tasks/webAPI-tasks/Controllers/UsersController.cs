
using BOL;
using BLL;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;
using BOL.HelpModel;
using BOL.Models;

namespace webAPI_tasks.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/Users
       
        [HttpGet]
        [Route("api/Users/getAllUsers")]   
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicManager.GetAllUsers());
        
        }
        //managers or teamleaders
        [HttpGet]
        [Route("api/Users/getUsersByDepartment/{departmentName}")]
        public HttpResponseMessage getUserByDepartment(string departmentName)
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicManager.getUserByDepartment(departmentName));
          
        }
        //get all the workers that belong to a specific project
        [HttpGet]
        [Route("api/Users/getUserBelongProject/{projectId}")]
        public HttpResponseMessage getUserBelongProject(int projectId)
        {
           return Request.CreateResponse(HttpStatusCode.OK, LogicManager.getUsersBelongProjects(projectId));

        }
        //get all the workers that belong to a specfic teamleader
        [HttpGet]
        [Route("api/Users/getUsersOfTeamLeader/{teamleaderId}")]
        public HttpResponseMessage getUsersOfTeamLeader(int teamleaderId)
        {
            var x = LogicManager.getUsersOfTeamLeader(teamleaderId);
            return Request.CreateResponse(HttpStatusCode.OK,x);

        }
        [HttpGet]
        [Route("api/Users/getSumHoursDoneForUsers/{teamleaderId}")]
        public HttpResponseMessage getSumHoursDoneForUsers(int teamleaderId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicManager.getSumHoursDoneForUsers(teamleaderId));

        }
        [HttpGet]
        [Route("api/Users/getHoursForUserProjects/{userId}")]
        public HttpResponseMessage getHoursForUserProjects(int userId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicManager.getHoursForUserProjects(userId));

        }

        [HttpGet]
        [Route("api/Users/getHoursAndProjectForUser/{userId}")]
        public HttpResponseMessage getHoursAndProjectForUser(int userId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicManager.getHoursAndProjectForUser(userId));

        }
        //simple workers
        [HttpGet]
        [Route("api/Users/getWorkers")]
        public HttpResponseMessage getWorkers()
        {

            return new HttpResponseMessage(HttpStatusCode.OK)
            {

                Content = new ObjectContent<List<UserWithoutPassword>>(LogicManager.getWorkers(), new JsonMediaTypeFormatter())
            };
        }



        [HttpGet]
        [Route("api/Users/getUserDetails/{id}")]
        // GET: api/Users/5
        /// <summary>
        /// get details user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage Get(int id)
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ObjectContent<UserWithoutPassword>(LogicManager.GetUserDetails(id), new JsonMediaTypeFormatter())
            };
        }

        [HttpGet]
        [Route("api/getProjectsById/{id}")]
        public HttpResponseMessage getProjectsById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicManager.GetProjectsUser(id));

        }
        [HttpGet]
        [Route("api/getProjectsManager/{id}")]
        public HttpResponseMessage getProjectsManager(int id)
        {
          return  Request.CreateResponse(HttpStatusCode.OK, LogicManager.getProjectsManager(id));
          
        }


        //[HttpGet]
        //[Route("api/getSumHoursUserDoneByMonth/{id}")]
        //public HttpResponseMessage getSumHoursUserDoneByMonth(int id)
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, LogicManager.getSumHoursUserDoneByMonth(id));
        //}




        [HttpPost]
        [Route("api/addUser")]
        // POST: api/Users
        public HttpResponseMessage Post([FromBody]User value)
        {
           
            if (ModelState.IsValid)
            {
                return (LogicManager.AddUser(value)) ?
                   new HttpResponseMessage(HttpStatusCode.Created) :
                   new HttpResponseMessage(HttpStatusCode.BadRequest)
                   {
                       Content = new ObjectContent<String>("Can not add to DB", new JsonMediaTypeFormatter())
                   };
            };

            List<string> ErrorList = new List<string>();

            //if the code reached this part - the user is not valid
            foreach (var item in ModelState.Values)
                foreach (var err in item.Errors)
                    ErrorList.Add(err.ErrorMessage);

            return new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new ObjectContent<List<string>>(ErrorList, new JsonMediaTypeFormatter())
            };

        }

        [HttpPost]
        [Route("api/loginByPassword")]
        public HttpResponseMessage LoginByPassword([FromBody]LoginUser value)
        {
            if (ModelState.IsValid)
            {
                UserWithoutPassword user = LogicManager.GetUserDetailsByPassword(value.Password,value.UserName);
                //TODO:TOKEN
                return (user != null ?Request.CreateResponse(HttpStatusCode.OK,user):

                   new HttpResponseMessage(HttpStatusCode.Forbidden)
                   {
                       Content = new ObjectContent<String>("Can not add to DB", new JsonMediaTypeFormatter())
                   });
            };

            List<string> ErrorList = new List<string>();

            //if the code reached this part - the user is not valid
            foreach (var item in ModelState.Values)
                foreach (var err in item.Errors)
                    ErrorList.Add(err.ErrorMessage);

            return new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new ObjectContent<List<string>>(ErrorList, new JsonMediaTypeFormatter())
            };

        }
        [HttpPost]
        [Route("api/LoginByComputerUser")]
        public HttpResponseMessage LoginByComputerUser([FromBody]string ComputerUser)
        {

            UserWithoutPassword user = LogicManager.GetUserDetailsComputerUser(ComputerUser);
                //TODO:TOKEN
                return (user != null ?
                   new HttpResponseMessage(HttpStatusCode.Created)
                   {
                       Content = new ObjectContent<UserWithoutPassword>(user, new JsonMediaTypeFormatter())
                   } :
                   new HttpResponseMessage(HttpStatusCode.BadRequest)
                   {
                       Content = new ObjectContent<String>("Can not add to DB", new JsonMediaTypeFormatter())
                   });
        }

        // PUT: api/Users/5
        [HttpPut]
        [Route("api/updateUser")]
        public HttpResponseMessage Put([FromBody]UserWithoutPassword value)
        {
            ModelState.Remove("Password");
            if (ModelState.IsValid)
            {
                return (LogicManager.UpdateUser(value)) ?
                    new HttpResponseMessage(HttpStatusCode.OK) :
                    new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new ObjectContent<String>("Can not update in DB", new JsonMediaTypeFormatter())
                    };
            };

            List<string> ErrorList = new List<string>();

            //if the code reached this part - the user is not valid
            foreach (var item in ModelState.Values)
                foreach (var err in item.Errors)
                    ErrorList.Add(err.ErrorMessage);

            return new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new ObjectContent<List<string>>(ErrorList, new JsonMediaTypeFormatter())
            };
        }

        [HttpDelete]
        [Route("api/deleteUser/{id}")]
        // DELETE: api/Users/5
        public HttpResponseMessage Delete(int id)
        {
            return (LogicManager.RemoveUser(id)) ?
                    new HttpResponseMessage(HttpStatusCode.OK) :
                    new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new ObjectContent<String>("Can not remove from DB", new JsonMediaTypeFormatter())
                    };
        }

      

        [HttpPut]
        [Route("api/sendMessageToManagers/{idUser}")]
        public HttpResponseMessage sendMessageToManagers(int idUser, [FromBody] SendEmail message)
        {
            return (LogicManager.sendMessageToManagers(idUser,message.message)) ?
                    new HttpResponseMessage(HttpStatusCode.OK) :
                    new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new ObjectContent<String>("Can not send Email", new JsonMediaTypeFormatter())
                    };
        }


    }
}
