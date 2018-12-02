using Arquitetura.DI.Base.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Arquitetura.DI.Base
{
    public class ClienteService : IClienteService
    {
        private readonly IMensagem _mensagem;
        private readonly IClienteRepository _clienteRepository;
        
        public ClienteService(IEnumerable<IMensagem> mensagens, IClienteRepository clienteRepository)
        {
            _mensagem = mensagens.FirstOrDefault(mensagem => mensagem.GetType().Name.Equals("Email"));
            _clienteRepository = clienteRepository;
        }

        public void Adicionar()
        {
            _clienteRepository.Adicionar(new Cliente());
            _mensagem.Enviar();
        }
    }
}