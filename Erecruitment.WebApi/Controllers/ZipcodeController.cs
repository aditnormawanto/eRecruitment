using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Erecruitment.WebApi.DataAccess;
using Erecruitment.WebApi.Services;
using System.Threading.Tasks;

namespace Erecruitment.WebApi.Controllers
{
    public class ZipcodeController : ApiController
    {
        ZipcodeService service = new ZipcodeService();

        [Route("api/zipcode/t1/{code}")]
        public IHttpActionResult GetByZipcode(string code)
        {
            var result = service.GetByZipcode(code);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t2/{kel}")]
        public IHttpActionResult GetByKelurahan(string kel)
        {
            var result = service.GetByZipcode(kel);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t3/{kec}")]
        public IHttpActionResult GetByKecamatan(string kec)
        {
            var result = service.GetByZipcode(kec);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t4/{kot}")]
        public IHttpActionResult GetByKotamadya(string kot)
        {
            var result = service.GetByZipcode(kot);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t5/{prov}")]
        public IHttpActionResult GetByPrivinsi(string prov)
        {
            var result = service.GetByZipcode(prov);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t6/{code}")]
        public async Task<IHttpActionResult> GetByZipcodeAsync(string code)
        {
            var result = await service.GetByZipcodeAsync(code);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t7/{kel}")]
        public async Task<IHttpActionResult> GetByKelurahanAsync(string kel)
        {
            var result = await service.GetByZipcodeAsync(kel);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t8/{kec}")]
        public async Task<IHttpActionResult> GetByKecamatanAsync(string kec)
        {
            var result = await service.GetByZipcodeAsync(kec);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t9/{kot}")]
        public async Task<IHttpActionResult> GetByKotamadyaAsync(string kot)
        {
            var result = await service.GetByZipcodeAsync(kot);

            if (result.Count != 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("api/zipcode/t10/{prov}")]
        public async Task<IHttpActionResult> GetByPrivinsiAsync(string prov)
        {
            var result = await service.GetByZipcodeAsync(prov);

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
