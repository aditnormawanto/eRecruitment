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

        //public object GetByCode(string code)
        //{
        //    string jsonString = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/REF_KODEPOS.json"));

        //    //JObject[] obj = JObject.Parse(jsonString);

        //    //JObject objResult = obj[""].Values<JObject>()
        //    //    .Where(m => m["KODEPOS"].Value<string>() == code)
        //    //    .FirstOrDefault();

        //    return objResult.ToString(Formatting.None);
        //}

        //public object GetByKelurahan(string kel)
        //{
        //    string jsonString = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/REF_KODEPOS.json"));
        //    return JsonConvert.DeserializeObject(jsonString);
        //}

        //public object GetByKecamatan(string kec)
        //{
        //    string jsonString = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/REF_KODEPOS.json"));
        //    return JsonConvert.DeserializeObject(jsonString);
        //}

        //public object GetByKotamadya(string kot)
        //{
        //    string jsonString = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/REF_KODEPOS.json"));
        //    return JsonConvert.DeserializeObject(jsonString);
        //}

        //public object GetByProvinsi(string prov)
        //{
        //    string jsonString = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/REF_KODEPOS.json"));
        //    return JsonConvert.DeserializeObject(jsonString);
        //}
    }
}