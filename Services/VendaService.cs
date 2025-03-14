using System.Collections.Generic;
using ApiCrud.Entities;
using ApiCrud.Persistence;

namespace ApiCrud.Services
{
    public class VendaService
    {
        private readonly VendaRepository _vendaRepository;

        public VendaService(VendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public List<Venda> GetAllVendas() => _vendaRepository.GetAll();

        public Venda GetVendaById(int id) => _vendaRepository.GetById(id);

        public void CreateVenda(Venda venda)
        {
            venda.VlrTotalVenda = venda.QtdVenda * venda.VlrUnitarioVenda;
            _vendaRepository.Add(venda);
        }

        public void UpdateVenda(Venda venda)
        {
            _vendaRepository.Update(venda);
        }

        public void DeleteVenda(int id) => _vendaRepository.Delete(id);
    }
}
