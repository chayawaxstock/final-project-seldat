
using BLL;
using BOL.HelpModel;
using BOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace webAPI_tasks.Controllers
{
    public class ProjectWorkerController : ApiController
    {

        // PUT: api/ProjectWorker/5
        [HttpPut]
        [Route("api/updateProjectHours")]
        public HttpResponseMessage Put([FromBody]ProjectWorker value)
        {

            if (ModelState.IsValid)
            {
                return (LogicProjectWorker.UpdateProjectWorker(value)) ?
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


        [HttpGet]
        [Route("api/getWorkerNotProject/{projectId}")]
        public HttpResponseMessage Get(int projectId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicProjectWorker.GetWorkerNotInProject(projectId));
        }

        [HttpGet]
        [Route("api/getWorkerInProject/{projectId}")]
        public HttpResponseMessage getWorkerInProject(int projectId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicProjectWorker.getWorkerInProject(projectId));
        }
    }
}
