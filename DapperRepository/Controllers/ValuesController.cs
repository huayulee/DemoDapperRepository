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
        protected BreedRepository _br = new BreedRepository();

        // GET api/values
        [SwaggerOperation("GetAll")]
        [Route("GetBreeds")]
        public IHttpActionResult Get()
        {
            return Ok(_br.Get());
        }

        [SwaggerOperation("GetCat")]
        [Route("GetCats")]
        public IHttpActionResult GetCats()
        {
            var rrr = new CatRepository();
            return Ok(rrr.Get());
        }

        // GET api/values/5
        [HttpGet]
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [Route("Insert")]
        public bool Insert()
        {
            return _br.Insert();
        }

        [HttpGet]
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [Route("BulkInsert")]
        public int BulkInsert()
        {
            return _br.BulkInsert();
        }

        [HttpGet]
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [Route("Update")]
        public bool Update()
        {
            return _br.Update();
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
