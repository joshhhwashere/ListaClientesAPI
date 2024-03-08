using ListaClientesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListaClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecargaController : ControllerBase
    {
        private static List<Recarga> _recarga = new List<Recarga>
        {
            new Recarga
            {
                Celular = "0998907153",
                Cantidad = 10,
                Tipo = TipoCombo.Combo1,
                Cliente = "David Sánchez"
            },
            new Recarga
            {
                Celular = "0999283259",
                Cantidad = 10,
                Tipo = TipoCombo.Combo1,
                Cliente = "Nicole Sánchez"
            },
            new Recarga
            {
                Celular = "0987654321",
                Cantidad = 15,
                Tipo = TipoCombo.Combo2,
                Cliente = "Maria Rodriguez"
            },
            new Recarga
            {
                Celular = "0978123456",
                Cantidad = 20,
                Tipo = TipoCombo.Combo3,
                Cliente = "Juan Perez"
            }
        };
        [HttpGet("{celular}")]
        public IActionResult GetRecargaByCelular(string celular)
        {
            var recarga = _recarga.Find(r => r.Celular == celular);

            if (recarga != null)
                return Ok(recarga);
            else
                return NotFound();
        }
    }
}
