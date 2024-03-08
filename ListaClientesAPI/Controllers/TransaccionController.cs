using ListaClientesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListaClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionController : ControllerBase
    {
        private static List<Transacción> _transaccion = new List<Transacción>
        {
            new Transacción
            {
                Transaccion = "0001",
                RecargaExitosa = true,
                Mensaje = "Transacción exitosa",
                Celular = "0998907153"
            },
            new Transacción
            {
                Transaccion = "0002",
                RecargaExitosa = false,
                Mensaje = "Transacción Fallida",
                Celular = "0999283259"
            },
            new Transacción
            {
                Transaccion = "0003",
                RecargaExitosa = true,
                Mensaje = "Transacción exitosa",
                Celular = "0987654321"
            },
             new Transacción
            {
                Transaccion = "0001",
                RecargaExitosa = true,
                Mensaje = "Transacción exitosa",
                Celular = "0954168282"
             }
        };
        [HttpGet("{transaccionId}")]
        public IActionResult GetTransaccionById(string transaccionId)
        {
            var transaccion = _transaccion.Find(t => t.Transaccion == transaccionId);

            if (transaccion != null)
                return Ok(transaccion);
            else
                return NotFound();
        }
    }
}
