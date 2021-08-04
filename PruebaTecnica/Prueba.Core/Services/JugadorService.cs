using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Services
{
    public class JugadorService
    {
        private readonly IJugadorService _jugadorService;
        public JugadorService(IJugadorService jugadorRepository)
        {
            _jugadorService = jugadorRepository;
        }

        public  bool DeleteJugador(int id)
        {
            return  _jugadorService.DeleteJugador(id);
        }

        public async Task<Jugador> GetJugador(int id)
        {
            return await _jugadorService.GetJugador(id);
        }

        public async Task<IEnumerable<Jugador>> GetJugadors()
        {
            return await _jugadorService.GetJugadores();
        }

        public async Task InsertJugador(Jugador jugador)
        {
            await _jugadorService.InsertJugador(jugador);
        }

        public bool UpdateJugador(Jugador jugador)
        {
            return  _jugadorService.UpdateJugador(jugador);
        }

    }
}
