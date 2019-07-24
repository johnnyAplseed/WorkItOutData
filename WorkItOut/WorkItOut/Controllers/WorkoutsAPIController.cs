using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.ServiceModel;
using WorkItOut.Models;
using WorkItOut.Business.Items;
using WorkItOut.Business.Managers;

namespace WorkItOut.Controllers
{
    [RoutePrefix("api/workouts")]
    public class WorkoutsAPIController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response;
            try
            {
                List<WorkoutItem> result = WorkoutManager.GetAllWorkouts();
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, new StandardResponse(ex));
            }

            return response;
        }
        
        // GET api/Workouts/5
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetWorkoutById(int id)
        {
            HttpResponseMessage response;
            try
            {
                WorkoutItem workout = WorkoutManager.GetWorkoutById(id);
                response = Request.CreateResponse(HttpStatusCode.OK, workout);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, new StandardResponse(ex));
            }

            return response;
        }
        
        [HttpGet]
        [Route("{category}")]
        public HttpResponseMessage WorkoutsByCategory(string category)
        {
            HttpResponseMessage response;
            try
            {
                WorkoutItem workout = WorkoutManager.GetWorkoutByCategory(category);
                response = Request.CreateResponse(HttpStatusCode.OK, workout);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, new StandardResponse(ex));
            }

            return response;
        }


        [HttpPost]
        [Route("saveProfile")]
        public HttpResponseMessage SaveProfile(ProfileItem profile)
        {

            HttpResponseMessage response;
            try
            {
                WorkoutManager.SaveProfile(profile);
                response = Request.CreateResponse(HttpStatusCode.OK, new StandardResponse());
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, new StandardResponse(ex));
            }

            return response;
        }

    }
}
