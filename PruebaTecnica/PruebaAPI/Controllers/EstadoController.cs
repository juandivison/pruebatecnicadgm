using Microsoft.AspNetCore.Mvc;
using Prueba.Core.Interfaces;
using Prueba.Infractructure.Repositories;
using System.Threading.Tasks;

namespace PruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoRepository _estadoRepository;
        public EstadoController(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEstados()
        {
            var estado = await  _estadoRepository.GetEstados();            
            return Ok(estado);
        }
    }
}
