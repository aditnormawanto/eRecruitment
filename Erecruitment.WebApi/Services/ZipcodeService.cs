using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Erecruitment.WebApi.DataAccess;
using Erecruitment.WebApi.DataAccess.Repositories;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Erecruitment.WebApi.Services
{
    public class ZipcodeService
    {
        ZipcodeRepository repository = new ZipcodeRepository();

        public ICollection<REF_KODEPOS> GetByZipcode(string code)
        {
            return repository.GetByZipcode(code);
        }

        public async Task<ICollection<REF_KODEPOS>> GetByZipcodeAsync(string code)
        {
            return await repository.GetByZipcodeAsync(code);
        }

        public ICollection<REF_KODEPOS> GetByKelurahan(string kel)
        {
            return repository.GetByKelurahan(kel);
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKelurahanAsync(string kel)
        {
            return await repository.GetByKelurahanAsync(kel);
        }

        public ICollection<REF_KODEPOS> GetByKecamatan(string kec)
        {
            return repository.GetByKecamatan(kec);
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKecamatanAsync(string kec)
        {
            return await repository.GetByKecamatanAsync(kec);
        }

        public ICollection<REF_KODEPOS> GetByKotamadya(string kot)
        {
            return repository.GetByKotamadya(kot);
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKotamadyaAsync(string kot)
        {
            return await repository.GetByKotamadyaAsync(kot);
        }

        public ICollection<REF_KODEPOS> GetByProvinsi(string prov)
        {
            return repository.GetByProvinsi(prov);
        }

        public async Task<ICollection<REF_KODEPOS>> GetByProvinsiAsync(string prov)
        {
            return await repository.GetByProvinsiAsync(prov);
        }
    }
}