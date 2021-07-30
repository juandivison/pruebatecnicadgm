using Microsoft.EntityFrameworkCore;
using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using Prueba.Infractructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Infractructure.Repositories
{
    public class SqlDBRepository : IEstadoRepository
    {
        private readonly AppDBContext _appDBContext;

        public SqlDBRepository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        public Task<IEnumerable<Estado>> GetEstados()
        {
            throw new NotImplementedException();
        }

        public Task<Estado> GetEstados(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Estado> InsertEstado(Estado estado)
        {
            throw new NotImplementedException();
        } 

    }
}
