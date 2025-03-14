using System.Collections.Generic;
using ApiCrud.Entities;
using ApiCrud.Persistence;

namespace ApiCrud.Services
{
    public class ProdutoService
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoService(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> GetAllProdutos() => _produtoRepository.GetAll();

        public Produto GetProdutoById(int id) => _produtoRepository.GetById(id);

        public void CreateProduto(Produto produto)
        {
            _produtoRepository.Add(produto);
        }

        public void UpdateProduto(Produto produto)
        {
            _produtoRepository.Update(produto);
        }

        public void DeleteProduto(int id) => _produtoRepository.Delete(id);
    }
}
