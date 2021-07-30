using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Infractructure.Repositories
{
    public class EstadoRespository : IEstadoRepository
    {
        public async Task<IEnumerable<Estado>> GetEstados()
        {
            var estados = Enumerable.Range(1, 10).Select(x => new Estado
            {
                Id = x,
                Nombre = $"Test {x}"
            });
            await Task.Delay(10);
            return estados;
        }
    }
}
