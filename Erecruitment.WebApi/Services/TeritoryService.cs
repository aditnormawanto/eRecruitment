using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Erecruitment.WebApi.Services
{
    public class TeritoryService
    {
        public object Get()
        {
            string jsonString = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/DATA_WILAYAH_INDONESIA.json"));
            return JsonConvert.DeserializeObject(jsonString);
        }
    }
}