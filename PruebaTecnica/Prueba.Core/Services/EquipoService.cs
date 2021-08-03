using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Services
{
    public class EquipoService : IEquipoService
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IRepository<Estado> _estadoService;
        public EquipoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Equipo> GetEquipo(int id)
        {
            return _unitOfWork.EquipoRepository.GetById(id);
        }

        public IEnumerable<Equipo> GetEquipos()
        {
            return _unitOfWork.EquipoRepository.GetAll();
        }

        public async Task InsertEquipo(Equipo equipo)
        {
            await _unitOfWork.EquipoRepository.Add(equipo);
            await _unitOfWork.SaveChangesAsync();
        }

        public bool UpdateEquipo(Equipo equipo)
        {
            _unitOfWork.EquipoRepository.Update(equipo);
            _unitOfWork.SaveChanges();
            return true;
        }
        public bool DeleteEquipo(int id)
        {
            _unitOfWork.EquipoRepository.Delete(id);
            _unitOfWork.SaveChanges();
            return true;
        }
    }
}
