using Prueba.Core.DTOS;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface  IEstadoRepository
    {
        Task<IEnumerable<Estado>> GetEstados();
        Task<Estado> GetEstado(int id);
        Task InsertEstado(Estado estado);
        Task<bool> UpdateEstado(Estado estado);

        Task<bool> DeleteEstado(int id);
    }
}
