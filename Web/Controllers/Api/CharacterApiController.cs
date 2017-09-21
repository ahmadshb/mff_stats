using MFFStats.Models.Domain;
using MFFStats.Models.Responses;
using MFFStats.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MFFStats.Web.Controllers.Api
{
    [RoutePrefix("api/character")]
    public class CharacterApiController : ApiController
    {
        CharacterService svc = new CharacterService();

        // GET api/<controller>
        [Route, HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                ItemsResponse<Character> response = new ItemsResponse<Character>();
                response.Items = svc.SelectAll();
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}