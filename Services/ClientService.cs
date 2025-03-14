using System.Collections.Generic;
using ApiCrud.Entities;
using ApiCrud.Persistence;

namespace ApiCrud.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> GetAllClientes() => _clienteRepository.GetAll();

        public Cliente GetClienteById(int id) => _clienteRepository.GetById(id);

        public void CreateCliente(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.NmCliente))
                throw new System.Exception("Nome do cliente é obrigatório");

            _clienteRepository.Add(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.NmCliente))
                throw new System.Exception("Nome do cliente é obrigatório");

            _clienteRepository.Update(cliente);
        }

        public void DeleteCliente(int id) => _clienteRepository.Delete(id);
    }
}
