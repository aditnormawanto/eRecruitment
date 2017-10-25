using Erecruitment.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Erecruitment.WebApi.Controllers
{
    public class TeritoryController : ApiController
    {
        TeritoryService service = new TeritoryService();

        [Route("api/zipcode/t1/{code}")]
        public IHttpActionResult GetByCode(string code)
        {
            var result = service.GetByCode(code);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t2/{code}")]
        public async Task<IHttpActionResult> GetByCodeAsync(string code)
        {
            var result = await service.GetByCodeAsync(code);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
