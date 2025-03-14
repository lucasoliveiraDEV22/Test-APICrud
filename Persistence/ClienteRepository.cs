using System.Collections.Generic;
using System.Linq;
using ApiCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Persistence
{
    public class ClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAll() => _context.Clientes.ToList();
        public Cliente GetById(int id) => _context.Clientes.Find(id);
        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}
