using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IRepository<Estado> _estadoService;
        public EstadoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork  = unitOfWork;
        }

        public bool DeleteEstado(int id)
        {
            _unitOfWork.EstadoRepository.Delete(id);
            return true;
        }

        public Task<Estado> GetEstado(int id)
        {
            return _unitOfWork.EstadoRepository.GetById(id);
        }

        public async Task<IEnumerable<Estado>> GetEstados()
        {
            return _unitOfWork.EstadoRepository.GetAll();
        }

        public async Task InsertEstado(Estado estado)
        {
            await _unitOfWork.EstadoRepository.Add(estado);
        }

        public bool UpdateEstado(Estado estado)
        {
            _unitOfWork.EstadoRepository.Update(estado);
            return  true;
        }
    }
}
