using Microsoft.AspNetCore.Mvc;
using ApiCrud.Entities;
using ApiCrud.Services;
using System.Collections.Generic;

namespace ApiCrud.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public ActionResult<List<Produto>> Get() => _produtoService.GetAllProdutos();

        [HttpGet("{id}")]
        public ActionResult<Produto> GetById(int id) => _produtoService.GetProdutoById(id);

        [HttpPost]
        public IActionResult Create([FromBody] Produto produto)
        {
            _produtoService.CreateProduto(produto);
            return CreatedAtAction(nameof(GetById), new { id = produto.IdProduto }, produto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Produto produto)
        {
            if (id != produto.IdProduto)
                return BadRequest();

            _produtoService.UpdateProduto(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _produtoService.DeleteProduto(id);
            return NoContent();
        }
    }
}
