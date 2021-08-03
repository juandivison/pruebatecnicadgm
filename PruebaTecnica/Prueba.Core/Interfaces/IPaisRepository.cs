using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    interface IPaisRepository
    {
        IEnumerable<Pais> GetPaises();
        Task<Pais> GetPais(int id);
        
    }
}
