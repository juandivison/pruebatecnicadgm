using Microsoft.EntityFrameworkCore;
using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using Prueba.Infractructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Infractructure.Repositories
{
    public class JugadorRepository : IJugadorRepository
    {
        private readonly AppDBContext _appDBContext;

        public JugadorRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }
        public async Task<Jugador> GetJugador(int id)
        {
            var jugador = await _appDBContext.Jugador.FirstOrDefaultAsync((System.Linq.Expressions.Expression<Func<Jugador, bool>>)(x => x.Id == id));
            return jugador;
        }

        public async Task<IEnumerable<Jugador>> GetJuagadores()
        {
            var jugador = await _appDBContext.Jugador.ToListAsync();
            return jugador;
        }

        public async Task InsertJugador(Jugador jugador)
        {
            _appDBContext.Jugador.Add(jugador);
            await _appDBContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteJugador(int id)
        {
            var currentJugador = await GetJugador(id);
            _appDBContext.Jugador.Remove(currentJugador);
            int rows = await _appDBContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> UpdateJugador(Jugador jugador)
        {
            var currentJugador = await GetJugador(jugador.Id);
            currentJugador.Nombre = jugador.Nombre;
            currentJugador.Apellido = jugador.Apellido;
            currentJugador.EstadoId = jugador.EstadoId;
            currentJugador.IdEquipo = jugador.IdEquipo;
            currentJugador.Direccion = jugador.Direccion;
            currentJugador.FechaNacimiento = jugador.FechaNacimiento;
            currentJugador.Pasaporte = jugador.Pasaporte;
            currentJugador.Sexo = jugador.Sexo;
            int rows = await _appDBContext.SaveChangesAsync();
            return rows > 0;
        }
    }
}
