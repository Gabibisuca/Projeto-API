using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Clientes");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Cliente {id}");
        }

        [HttpGet("/nome/{nome}")]
        public IActionResult GetByNome(char nome)
        {
            return Ok($"Cliente {nome}");
        }

        [HttpGet("/email/{email}")]
        public IActionResult GetByEmail(char email)
        {
            return Ok($"Cliente {email}");
        }

        [HttpGet("/CPF/{CPF}")]
        public IActionResult GetByCPF(char CPF)
        {
            return Ok($"Cliente {CPF}");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok($"Cliente {id} atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Cliente {id} deletado");
        }
    }
}
