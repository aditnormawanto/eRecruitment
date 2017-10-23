using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Erecruitment.WebApi.DataAccess;
using System.IO;
using Newtonsoft.Json;

namespace Erecruitment.WebApi.Services
{
    public class ZipcodeService
    {
        public object Get()
        {
            string jsonString = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/REF_KODEPOS.json"));
            return JsonConvert.DeserializeObject(jsonString);
        }
    }
}