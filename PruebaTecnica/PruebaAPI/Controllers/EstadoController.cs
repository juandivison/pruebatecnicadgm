using Microsoft.AspNetCore.Mvc;
using Prueba.Core.Entities;
using Prueba.Core.Interfaces;
using Prueba.Infractructure.Data;
using Prueba.Infractructure.Repositories;
using System.Threading.Tasks;

namespace PruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoRepository _estadoRepository;
        private readonly AppDBContext _context;
                
        public EstadoController(AppDBContext context,IEstadoRepository estadoRepository)
        {
            this._context = context;
            _estadoRepository = estadoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEstados()
        {
            var estado = await  _estadoRepository.GetEstados();            
            return Ok(estado);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstados(int id)
        {
            var estado = await _estadoRepository.GetEstados(id);
            return Ok(estado);
        }

        [HttpPost]
        public async Task<IActionResult> InsertEstado(Estado estado )
        {
            await _context.Estado.AddAsync(estado);
            return Ok(estado);
        }
    }
}
