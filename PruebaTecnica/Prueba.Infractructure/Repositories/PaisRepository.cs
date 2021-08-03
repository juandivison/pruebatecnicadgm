using Microsoft.EntityFrameworkCore;
using Prueba.Core.Entities;
using Prueba.Infractructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Infractructure.Repositories
{
    public class PaisRepository : BaseRepository<Pais>
    {
        public PaisRepository(AppDBContext context) : base(context)
        {

        }
        //ejemplo para hacer busquedas
        public async Task<IEnumerable<Pais>> GetPaises()
        {
            return await _entities.Where(x => x.Iso31662.Length > 3).ToListAsync();
        }
    }
}
