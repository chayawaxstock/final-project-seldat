
using BLL;
using BOL;
using BOL.HelpModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace webAPI_tasks.Controllers
{
    public class ProjectsController : ApiController
    {
        [HttpGet]
        [Route("api/getAllProjects")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicProjects.GetAllProjects());
        }

        // GET: api/Projects/5
        public HttpResponseMessage Get(string projectName)
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ObjectContent<Project>(LogicProjects.GetProjectDetails(projectName), new JsonMediaTypeFormatter())
            };
        }

        // POST: api/Projects
        public HttpResponseMessage Post([FromBody]Project value)
        {
            if (ModelState.IsValid)
            {
               
                return (LogicProjects.AddProject(value)) ?
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

        // PUT: api/Projects/5
        public HttpResponseMessage Put([FromBody]Project value)
        {

            if (ModelState.IsValid)
            {
                return (LogicProjects.UpdateProject(value)) ?
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
        [HttpPut]
        [Route("api/addWorkersToProject/{projectId}")]
        public HttpResponseMessage Put(int projectId, [FromBody]List<UserWithoutPassword> workers)
        {

            if (ModelState.IsValid)
            {
                return (LogicProjects.AddWorkerToProject(projectId, workers)) ?
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

        // DELETE: api/Projects/5
        public HttpResponseMessage Delete(string projectName)
        {
            return (LogicProjects.RemoveProject(projectName)) ?
                    new HttpResponseMessage(HttpStatusCode.OK) :
                    new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new ObjectContent<String>("Can not remove from DB", new JsonMediaTypeFormatter())
                    };
        }
    }
}
