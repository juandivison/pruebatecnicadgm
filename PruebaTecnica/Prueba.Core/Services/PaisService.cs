using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Services
{
    public class PaisService
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IRepository<Estado> _estadoService;
        public PaisService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Pais> GetPais(int id)
        {
            return _unitOfWork.PaisRepository.GetById(id);
        }

        public IEnumerable<Pais> GetPaises()
        {
            return _unitOfWork.PaisRepository.GetAll();
        }        
    }
}
