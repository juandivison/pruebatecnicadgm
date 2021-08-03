﻿using Prueba.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IEstadoService
    {
        Task InsertEstado(Estado estado);
        Task<IEnumerable<Estado>> GetEstados();
        Task<Estado> GetEstado(int id);
        Task<bool> UpdateEstado(Estado estado);

        Task<bool> DeleteEstado(int id);
    }
}