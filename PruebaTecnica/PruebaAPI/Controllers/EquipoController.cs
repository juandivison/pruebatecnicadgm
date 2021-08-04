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
using Prueba.Core.Services;

namespace PruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly IEquipoService _equipoService;
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        public EquipoController(AppDBContext context, EquipoService equipoService,IMapper mapper)
        {
            this._context = context;
            _equipoService = equipoService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetEquipoes()
        {
            var Equipo = _equipoService.GetEquipos();
            var Equipodto = _mapper.Map<IEnumerable<EquipoDto>>(Equipo);

            return Ok(Equipodto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEquipo(int id)
        {
            var Equipo = await _equipoService.GetEquipo(id);
            var Equipodtos = _mapper.Map<IEnumerable<EquipoDto>>(Equipo);
            var response = new ApiResponse<IEnumerable<EquipoDto>>(Equipodtos);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EquipoDto EquipoDto)
        {
            var Equipo = _mapper.Map<Equipo>(EquipoDto);
            await _equipoService.InsertEquipo(Equipo);
            EquipoDto = _mapper.Map<EquipoDto>(Equipo);
            var response = new ApiResponse<EquipoDto>(EquipoDto);
            return Ok(response);
        }
        [HttpPut]
        public IActionResult Update(int id, EquipoDto EquipoDto)
        {
            var Equipo = _mapper.Map<Equipo>(EquipoDto);
            Equipo.Id = id;
            var result = _equipoService.UpdateEquipo(Equipo);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _equipoService.DeleteEquipo(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
