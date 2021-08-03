using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoService _estadoService;
        public EstadoService(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }

        public async Task<bool> DeleteEstado(int id)
        {
            return await _estadoService.DeleteEstado(id);
        }

        public async  Task<Estado> GetEstado(int id)
        {
            return await _estadoService.GetEstado(id);
        }

        public async  Task<IEnumerable<Estado>> GetEstados()
        {
            return await _estadoService.GetEstados();
        }

        public async Task InsertEstado(Estado estado)
        {
            await _estadoService.InsertEstado(estado);
        }

        public async Task<bool> UpdateEstado(Estado estado)
        {
           return await _estadoService.UpdateEstado(estado);
        }
    }
}
