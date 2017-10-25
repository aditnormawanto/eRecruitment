using Erecruitment.WebApi.DataAccess;
using Erecruitment.WebApi.DataAccess.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Erecruitment.WebApi.Services
{
    public class TeritoryService
    {
        TeritoryRepository repository = new TeritoryRepository();

        public ICollection<DATA_WILAYAH_INDONESIA> GetByCode(string code)
        {
            return repository.GetByCode(code);
        }

        public async Task<ICollection<DATA_WILAYAH_INDONESIA>> GetByCodeAsync(string code)
        {
            return await repository.GetByCodeAsync(code);
        }
    }
}