using System.Collections.Generic;
using System.Linq;
using ApiCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Persistence
{
    public class VendaRepository
    {
        private readonly ApplicationDbContext _context;

        public VendaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Venda> GetAll() => _context.Vendas.Include(v => v.Cliente).Include(v => v.Produto).ToList();
        public Venda GetById(int id) => _context.Vendas.Include(v => v.Cliente).Include(v => v.Produto).FirstOrDefault(v => v.IdVenda == id);
        public void Add(Venda venda)
        {
            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }
        public void Update(Venda venda)
        {
            _context.Vendas.Update(venda);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var venda = _context.Vendas.Find(id);
            if (venda != null)
            {
                _context.Vendas.Remove(venda);
                _context.SaveChanges();
            }
        }
    }
}
