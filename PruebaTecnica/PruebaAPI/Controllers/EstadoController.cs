using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using Prueba.Infractructure.Data;
using System.Collections.Generic;
using System.Linq;
using Prueba.Core.DTOS;
using System.Threading.Tasks;
using PruebaAPI.Responses;

namespace PruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoService _estadoService;
        private readonly AppDBContext _context;
        private readonly IMapper  _mapper;

        public EstadoController(AppDBContext context, IEstadoService estadoService,
            IMapper mapper)
        {
            this._context = context;
            _estadoService = estadoService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetEstados()
        {
            var estado = _estadoService.GetEstados();
            var estadodto = _mapper.Map<IEnumerable<EstadoDto>>(estado);
            
            return Ok(estadodto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstados(int id)
        {
            var estado = await _estadoService.GetEstado(id);
            var estadodtos =  _mapper.Map<IEnumerable<EstadoDto>>(estado);
            var response = new ApiResponse<IEnumerable<EstadoDto>>(estadodtos);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EstadoDto estadoDto )
        {   
            var estado = _mapper.Map<Estado>(estadoDto);
            await _estadoService.InsertEstado(estado);
            estadoDto = _mapper.Map<EstadoDto>(estado);            
            var response = new ApiResponse<EstadoDto>(estadoDto);
            return Ok(response);
        }
        [HttpPut]
        public IActionResult Update(int id, EstadoDto estadoDto)
        {
            var estado = _mapper.Map<Estado>(estadoDto);
            estado.Id = id;
            var result =  _estadoService.UpdateEstado(estado);            
            var response = new ApiResponse<bool>(result);
            return Ok(response);            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {            
            var result = _estadoService.DeleteEstado(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

    }
}
