using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using DataAccess;

namespace DapperRepository.Controllers
{
    public class ValuesController : ApiController
    {
        private PaymentAsiaPayDBContext DB = new PaymentAsiaPayDBContext("Server=DESKTOP-QT1HILT\\SQLEXPRESS;Database=School;Trusted_Connection=True;");
        // GET api/values
        [SwaggerOperation("GetAll")]
        [Route("GetBreeds")]
        public IHttpActionResult Get()
        {
            var rrr = new BreedRepository();
            return Ok(rrr.Get());
        }

        [SwaggerOperation("GetCat")]
        [Route("GetCats")]
        public IHttpActionResult GetCats()
        {
            var rrr = new CatRepository();
            return Ok(rrr.Get());
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
