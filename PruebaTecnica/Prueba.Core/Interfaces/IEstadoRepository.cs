using Prueba.Core.DTOS;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface  IEstadoRepository : IRepository<Estado>
    {
        Task<IEnumerable<Estado>> GetEstados();
    }
}
