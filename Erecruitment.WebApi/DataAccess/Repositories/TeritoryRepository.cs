using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Erecruitment.WebApi.DataAccess.Repositories
{
    public class TeritoryRepository : Repository<DATA_WILAYAH_INDONESIA>
    {
        public ICollection<DATA_WILAYAH_INDONESIA> GetByCode(string code)
        {
            return _context.Set<DATA_WILAYAH_INDONESIA>().Where(z => z.KODE == code).ToList();
        }

        public async Task<ICollection<DATA_WILAYAH_INDONESIA>> GetByCodeAsync(string code)
        {
            return await _context.Set<DATA_WILAYAH_INDONESIA>().Where(z => z.KODE == code).ToListAsync();
        }
    }
}