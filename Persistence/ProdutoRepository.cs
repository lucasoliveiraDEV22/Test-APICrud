using System.Collections.Generic;
using System.Linq;
using ApiCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Persistence
{
    public class ProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Produto> GetAll() => _context.Produtos.ToList();
        public Produto GetById(int id) => _context.Produtos.Find(id);
        public void Add(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
        public void Update(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }
        }
    }
}
