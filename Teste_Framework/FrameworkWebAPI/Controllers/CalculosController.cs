using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FrameworkBO;
using FrameworkReactApp.Services;

namespace FrameworkReactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculosController : ControllerBase
    {
        private readonly IServiceCalculos _service;

        public CalculosController(IServiceCalculos service)
        {
            _service = service;
        }

        [Route("/Divisores/{numeroDecompor}")]
        [HttpGet]
        public ActionResult DecomporNumero(string numeroDecompor)
        {
            try
            {
                if (int.TryParse(numeroDecompor, out int numeroEntrada))
                    return Ok(_service.RetornarDivisores(numeroEntrada));
                else
                    return BadRequest("Valor incorreto! Por favor informe um número natural (inteiro, não negativo).");
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

    }
}
