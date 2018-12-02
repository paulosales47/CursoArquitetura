using Arquitetura.DI.Base.Interfaces;

namespace Arquitetura.DI.Base
{
    public class ClienteService : IClienteService
    {
        private readonly IMensagem _mensagem;
        private readonly IClienteRepository _clienteRepository;
        
        public ClienteService(IMensagemFactory mensagemFactory, IClienteRepository clienteRepository)
        {
            _mensagem = mensagemFactory.CreateNew("Email");
            _clienteRepository = clienteRepository;
        }

        public void Adicionar()
        {
            _clienteRepository.Adicionar(new Cliente());
            _mensagem.Enviar();
        }
    }
}