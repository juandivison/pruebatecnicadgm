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
    public class PaisController : ControllerBase
    {
        private readonly IPaisService _paisService;
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public PaisController(AppDBContext context, IPaisService paisService,
            IMapper mapper)
        {
            this._context = context;
            _paisService = paisService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPaises()
        {
            var pais = _paisService.GetPaises();
            var paisdto = _mapper.Map<IEnumerable<PaisDto>>(pais);

            return Ok(paisdto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPais(int id)
        {
            var pais = await _paisService.GetPais(id);
            var paisdto = _mapper.Map<IEnumerable<PaisDto>>(pais);
            var response = new ApiResponse<IEnumerable<PaisDto>>(paisdto);
            return Ok(response);
        }
    }
}
