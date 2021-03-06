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

        public Task<Estado> GetEstado(int id)
        {
            return _unitOfWork.EstadoRepository.GetById(id);
        }

        public IEnumerable<Estado> GetEstados()
        {
            return _unitOfWork.EstadoRepository.GetAll();
        }

        public async Task InsertEstado(Estado estado)
        {
            await _unitOfWork.EstadoRepository.Add(estado);
            await _unitOfWork.SaveChangesAsync();
        }

        public bool UpdateEstado(Estado estado)
        {
            _unitOfWork.EstadoRepository.Update(estado);
            _unitOfWork.SaveChanges();
            return  true;
        }
        public bool DeleteEstado(int id)
        {
            _unitOfWork.EstadoRepository.Delete(id);
            _unitOfWork.SaveChanges();
            return true;
        }

    }
}
