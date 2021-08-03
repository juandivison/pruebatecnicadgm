using Prueba.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IEstadoService
    {
        Task InsertEstado(Estado estado);
        Task<IEnumerable<Estado>> GetEstados();
        Task<Estado> GetEstado(int id);
        bool UpdateEstado(Estado estado);
        bool DeleteEstado(int id);
    }
}