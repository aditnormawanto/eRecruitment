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

        public ICollection<REF_KODEPOS> GetByKelurahan(string code)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.KELURAHAN.Contains(code)).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKelurahanAsync(string code)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.KELURAHAN.Contains(code)).ToListAsync();
        }

        public ICollection<REF_KODEPOS> GetByKecamatan(string code)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.KECAMATAN.Contains(code)).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKecamatanAsync(string code)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.KECAMATAN.Contains(code)).ToListAsync();
        }

        public ICollection<REF_KODEPOS> GetByKotamadya(string code)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.KABUPATEN.Contains(code)).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByKotamadyaAsync(string code)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.KABUPATEN.Contains(code)).ToListAsync();
        }

        public ICollection<REF_KODEPOS> GetByProvinsi(string code)
        {
            return _context.Set<REF_KODEPOS>().Where(z => z.PROVINSI.Contains(code)).ToList();
        }

        public async Task<ICollection<REF_KODEPOS>> GetByProvinsiAsync(string code)
        {
            return await _context.Set<REF_KODEPOS>().Where(z => z.PROVINSI.Contains(code)).ToListAsync();
        }
    }
}