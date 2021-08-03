using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Estado> EstadoRepository { get; }
        IRepository<Jugador> JugadorRepository { get; }
        //IRepository<Estado> EstadoRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
