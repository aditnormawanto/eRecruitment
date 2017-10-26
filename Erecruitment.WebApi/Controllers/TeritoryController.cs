using Erecruitment.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;

namespace Erecruitment.WebApi.Controllers
{
    public class TeritoryController : ApiController
    {
        TeritoryService service = new TeritoryService();

        [Route("api/teritory/t1/{code}")]
        public IHttpActionResult GetByCode(string code)
        {
            var result = service.GetByCode(SetZipcode(code));

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/teritory/t2/{code}")]
        public async Task<IHttpActionResult> GetByCodeAsync(string code)
        {
            var result = await service.GetByCodeAsync(SetZipcode(code));

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        private string SetZipcode(string code)
        {
            if (code.Count() > 8)
            {
                string firstPart = code.Substring(0, 6);
                string secondPart = code.Substring(6, code.Length - 6);
                code = Regex.Replace(firstPart, ".{2}", "$0.") + secondPart;
            }
            else
            {
                code = Regex.Replace(code, ".{2}", "$0.");
                code = code.Substring(0, code.Length - 1);
            }

            return code;
        }
    }
}
