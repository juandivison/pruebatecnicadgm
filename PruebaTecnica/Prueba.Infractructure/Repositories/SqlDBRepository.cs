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
    public class SqlDBRepository : IEstadoRepository
    {
        private readonly AppDBContext _appDBContext;

        public SqlDBRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }
        public async Task<IEnumerable<Estado>> GetEstados()
        {
            var estado = await _appDBContext.Estado.ToListAsync();
            return estado;
        }
        public async Task<Estado> GetEstados(int id)
        {
            var estado = await _appDBContext.Estado.FirstOrDefaultAsync(x => x.Id == id);
            return estado;
        }
    }
}
