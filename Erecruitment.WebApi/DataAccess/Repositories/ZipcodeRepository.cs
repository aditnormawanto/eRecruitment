using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace Erecruitment.WebApi.DataAccess.Repositories
{
    public class ZipcodeRepository : Repository<REF_KODEPOS>
    {
        public ICollection<REF_KODEPOS> GetByZipcode(string code)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.KODEPOS == code).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByZipcodeAsync(string code)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.KODEPOS == code).ToListAsync();
        }

        public ICollection<REF_KODEPOS> GetByKelurahan(string kel)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.KELURAHAN.Contains(kel)).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKelurahanAsync(string kel)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.KELURAHAN.Contains(kel)).ToListAsync();
        }

        public ICollection<REF_KODEPOS> GetByKecamatan(string kec)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.KECAMATAN.Contains(kec)).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKecamatanAsync(string kec)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.KECAMATAN.Contains(kec)).ToListAsync();
        }

        public ICollection<REF_KODEPOS> GetByKotamadya(string kot)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.KABUPATEN.Contains(kot)).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKotamadyaAsync(string kot)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.KABUPATEN.Contains(kot)).ToListAsync();
        }

        public ICollection<REF_KODEPOS> GetByProvinsi(string prov)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.PROVINSI.Contains(prov)).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByProvinsiAsync(string prov)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.PROVINSI.Contains(prov)).ToListAsync();
        }
    }
}