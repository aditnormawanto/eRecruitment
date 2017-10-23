using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Erecruitment.WebApi.DataAccess;
using Erecruitment.WebApi.Services;

namespace Erecruitment.WebApi.Controllers
{
    public class ZipcodeController : ApiController
    {
        ZipcodeService service = new ZipcodeService();

        public IHttpActionResult Get()
        {
            var result = service.Get();
            return Ok(result);
        }

        //public IHttpActionResult GetByCode(string code)
        //{
        //    var result = service.GetByCode(code);
        //    return Ok(result);
        //}

        //public IHttpActionResult GetByKelurahan(string kel)
        //{

        //}

        //public IHttpActionResult GetByKecamatan(string kec)
        //{

        //}

        //public IHttpActionResult GetByKotamadya(string kot)
        //{

        //}

        //public IHttpActionResult GetByPrivinsi(string prov)
        //{

        //}
    }
}
