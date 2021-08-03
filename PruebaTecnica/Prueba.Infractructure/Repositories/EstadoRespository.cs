using Microsoft.EntityFrameworkCore;
using Prueba.Core.DTOS;
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
    public class EstadoRespository : IEstadoRepository
    {
        private readonly AppDBContext _appDBContext;

        public EstadoRespository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }
        public async Task<Estado> GetEstado(int id)
        {
            var estado = await _appDBContext.Estado.FirstOrDefaultAsync(x => x.Id == id);
            return estado;
        }

        public async Task<IEnumerable<Estado>> GetEstados()
        {
            var estado = await _appDBContext.Estado.ToListAsync();
            return estado;
        }

        public async Task InsertEstado(Estado estado)
        {
            _appDBContext.Estado.Add(estado);
            //_appDBContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.estado ON");                        
            await _appDBContext.SaveChangesAsync();
            //_appDBContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.estado OFF");
        }

        public async Task<bool> DeleteEstado(int id)
        {
            var currentEstado = await GetEstado(id);
            _appDBContext.Estado.Remove(currentEstado);
            int rows = await _appDBContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> UpdateEstado(Estado estado)
        {
            var currentEstado = await GetEstado(estado.Id);
            currentEstado.Nombre = estado.Nombre;
            int rows = await _appDBContext.SaveChangesAsync();
            return rows > 0;
        }
    }
}
