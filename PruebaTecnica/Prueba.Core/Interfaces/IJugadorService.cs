using Prueba.Core.DTOS;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IJugadorService
    {
        Task<IEnumerable<Jugador>> GetJugadores();
        Task<Jugador> GetJugador(int id);
        Task InsertJugador(Jugador jugador);
        Task<bool> UpdateJugador(Jugador jugador);

        Task<bool> DeleteJugador(int id);
    }
}
