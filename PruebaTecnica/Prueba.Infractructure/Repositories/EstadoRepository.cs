using Microsoft.EntityFrameworkCore;
using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using Prueba.Infractructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Infractructure.Repositories
{
    public class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(AppDBContext context) : base(context)
        {

        }
        //ejemplo para hacer busquedas
        public async Task<IEnumerable<Estado>> GetEstados()
        {
            return await _entities.Where(x => x.Id > 0).ToListAsync(); 
        }
    }
}
    
