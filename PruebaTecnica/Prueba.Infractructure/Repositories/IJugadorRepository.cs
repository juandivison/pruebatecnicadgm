using Prueba.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prueba.Infractructure.Repositories
{
    public interface IJugadorRepository
    {
        Task<bool> DeleteJugador(int id);
        Task<IEnumerable<Jugador>> GetJuagadores();
        Task<Jugador> GetJugador(int id);
        Task InsertJugador(Jugador jugador);
        Task<bool> UpdateJugador(Jugador jugador);
    }
}