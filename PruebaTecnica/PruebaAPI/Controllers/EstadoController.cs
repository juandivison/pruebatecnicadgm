using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using Prueba.Infractructure.Data;
using System.Collections.Generic;
using System.Linq;
using Prueba.Core.DTOS;
using System.Threading.Tasks;

namespace PruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoRepository _estadoRepository;
        private readonly AppDBContext _context;
        private readonly IMapper  _mapper;


        public EstadoController(AppDBContext context,IEstadoRepository estadoRepository,
            IMapper mapper)
        {
            this._context = context;
            _estadoRepository = estadoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetEstados()
        {
            var estado = await  _estadoRepository.GetEstados();
            var estadodto = _mapper.Map<IEnumerable<EstadoDto>>(estado);
            
            return Ok(estadodto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstados(int id)
        {
            var estado = await _estadoRepository.GetEstado(id);
            var estadodto =  _mapper.Map<IEnumerable<EstadoDto>>(estado);
            return Ok(estadodto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EstadoDto estadoDto )
        {   
            var estado = _mapper.Map<Estado>(estadoDto);
            await _estadoRepository.InsertEstado(estado);
            return Ok(estado);
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, EstadoDto estadoDto)
        {
            var estado = _mapper.Map<Estado>(estadoDto);
            estado.Id = id;
            await _estadoRepository.UpdateEstado(estado);
            return Ok(estado);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {            
            var result = await _estadoRepository.DeleteEstado(id);
            return Ok(result);
        }

    }
}
