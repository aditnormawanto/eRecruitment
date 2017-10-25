using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Erecruitment.WebApi.DataAccess;
using Erecruitment.WebApi.DataAccess.Repositories;
using System.IO;
using Newtonsoft.Json;

namespace Erecruitment.WebApi.Services
{
    public class ZipcodeService
    {
        ZipcodeRepository repository = new ZipcodeRepository();

        public ICollection<REF_KODEPOS> GetByZipcode(string code)
        {
            return repository.GetByZipcode(code);
        }

        public ICollection<REF_KODEPOS> GetByKelurahan(string kel)
        {
            return repository.GetByKelurahan(kel);
        }

        public ICollection<REF_KODEPOS> GetByKecamatan(string kec)
        {
            return repository.GetByKecamatan(kec);
        }

        public ICollection<REF_KODEPOS> GetByKotamadya(string kot)
        {
            return repository.GetByKotamadya(kot);
        }

        public ICollection<REF_KODEPOS> GetByProvinsi(string prov)
        {
            return repository.GetByProvinsi(prov);
        }
    }
}