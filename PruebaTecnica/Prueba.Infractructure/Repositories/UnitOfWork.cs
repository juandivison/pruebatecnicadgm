using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using Prueba.Infractructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Infractructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        //private readonly IRepository<Estado> _estadoRepository;
        private readonly IEstadoRepository _estadoRepository;
        private readonly IRepository<Jugador> _jugadorRepository;
        private readonly IRepository<Equipo> _equipoRepository;
        private readonly IRepository<Pais> _paisRepository;

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
        }
        public IRepository<Estado> EstadoRepository => _estadoRepository ?? new EstadoRepository(_context);

        public IRepository<Jugador> JugadorRepository => _jugadorRepository ?? new BaseRepository<Jugador>(_context);

        public IRepository<Equipo> EquipoRepository => _equipoRepository ?? new BaseRepository<Equipo>(_context);

        public IRepository<Pais> PaisRepository =>  _paisRepository ?? new BaseRepository<Pais>(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
