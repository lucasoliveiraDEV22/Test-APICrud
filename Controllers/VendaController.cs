using Microsoft.AspNetCore.Mvc;
using ApiCrud.Entities;
using ApiCrud.Services;
using System.Collections.Generic;

namespace ApiCrud.Controllers
{
    [Route("api/vendas")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly VendaService _vendaService;

        public VendaController(VendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [HttpGet]
        public ActionResult<List<Venda>> Get() => _vendaService.GetAllVendas();

        [HttpGet("{id}")]
        public ActionResult<Venda> GetById(int id) => _vendaService.GetVendaById(id);

        [HttpPost]
        public IActionResult Create([FromBody] Venda venda)
        {
            _vendaService.CreateVenda(venda);
            return CreatedAtAction(nameof(GetById), new { id = venda.IdVenda }, venda);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Venda venda)
        {
            if (id != venda.IdVenda)
                return BadRequest();

            _vendaService.UpdateVenda(venda);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _vendaService.DeleteVenda(id);
            return NoContent();
        }
    }
}
