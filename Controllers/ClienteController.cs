using AutoMapper;
using APICrud.API.Entities;
using APICrud.API.Models;
using APICrud.API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APICrud.API.Controllers
{
    [Route("api/dev-events")]
    [ApiController]
    public class DevEventsController : ControllerBase
    {
        private readonly DevEventsDbContext _context;
        private readonly IMapper _mapper;

        public DevEventsController(
            DevEventsDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Obter todos os eventos
        /// </summary>
        /// <returns>Coleção de eventos</returns>
        /// <response code="200">Sucesso</response>
        using Microsoft.AspNetCore.Mvc;
using ApiCrud.Entities;
using ApiCrud.Services;
using System.Collections.Generic;

namespace ApiCrud.Controllers
    {
        [Route("api/clientes")]
        [ApiController]
        public class ClienteController : ControllerBase
        {
            private readonly ClienteService _clienteService;

            public ClienteController(ClienteService clienteService)
            {
                _clienteService = clienteService;
            }

            [HttpGet]
            public ActionResult<List<Cliente>> Get() => _clienteService.GetAllClientes();

            [HttpGet("{id}")]
            public ActionResult<Cliente> GetById(int id) => _clienteService.GetClienteById(id);

            [HttpPost]
            public IActionResult Create([FromBody] Cliente cliente)
            {
                _clienteService.CreateCliente(cliente);
                return CreatedAtAction(nameof(GetById), new { id = cliente.IdCliente }, cliente);
            }

            [HttpPut("{id}")]
            public IActionResult Update(int id, [FromBody] Cliente cliente)
            {
                if (id != cliente.IdCliente)
                    return BadRequest();

                _clienteService.UpdateCliente(cliente);
                return NoContent();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _clienteService.DeleteCliente(id);
                return NoContent();
            }
        }
    }
