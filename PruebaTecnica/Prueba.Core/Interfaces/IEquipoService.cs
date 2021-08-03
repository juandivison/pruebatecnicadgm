using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    interface IEquipoService
    {
        Task InsertEquipo(Equipo equipo);
        IEnumerable<Equipo> GetEquipos();
        Task<Equipo> GetEquipo(int id);
        bool UpdateEquipo(Equipo equipo);
        bool DeleteEquipo(int id);
    }
}
