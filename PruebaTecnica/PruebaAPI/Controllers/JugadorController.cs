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
    public class JugadorController : ControllerBase
    {
        private readonly IJugadorService _jugadorService;
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public JugadorController(AppDBContext context, IJugadorService jugadorService,
            IMapper mapper)
        {
            this._context = context;
            _jugadorService = jugadorService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetJugadores()
        {
            var jugador = _jugadorService.GetJugadores();
            var jugadordto = _mapper.Map<IEnumerable<JugadorDto>>(jugador);

            return Ok(jugadordto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJugador(int id)
        {
            var jugador = await _jugadorService.GetJugador(id);
            var jugadordtos = _mapper.Map<IEnumerable<JugadorDto>>(jugador);
            var response = new ApiResponse<IEnumerable<JugadorDto>>(jugadordtos);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(JugadorDto jugadorDto)
        {
            var jugador = _mapper.Map<Jugador>(jugadorDto);
            await _jugadorService.InsertJugador(jugador);
            jugadorDto = _mapper.Map<JugadorDto>(jugador);
            var response = new ApiResponse<JugadorDto>(jugadorDto);
            return Ok(response);
        }
        [HttpPut]
        public IActionResult Update(int id, JugadorDto jugadorDto)
        {
            var jugador = _mapper.Map<Jugador>(jugadorDto);
            jugador.Id = id;
            var result = _jugadorService.UpdateJugador(jugador);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _jugadorService.DeleteJugador(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
