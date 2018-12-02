using Arquitetura.DI.Base;
using Arquitetura.DI.Base.Interfaces;
using SimpleInjector;
using System.Collections.Generic;

namespace Arquitetura.DI
{
    public class Program
    {
        private static void Main()
        {
            Bootstrap.Start();

            var mensagem = Bootstrap.Container.GetInstance<IMensagemFactory>();
            var email = mensagem.CreateNew("Email");
            var sms = mensagem.CreateNew("SMS");

            var clienteService = Bootstrap.Container.GetInstance<IClienteService>();
            clienteService.Adicionar();
        }
    }

    internal class Bootstrap
    {
        public static Container Container;

        public static void Start()
        {
            Container = new Container();
   
            Container.RegisterInstance<IMensagemFactory>(new MensagemFactory
            {
                 {"Email", ()=> Container.GetInstance<Email>()  }
                ,{"SMS", ()=> Container.GetInstance<SMS>()  }
            });
            
            Container.Register<IClienteService, ClienteService>(Lifestyle.Transient);
            Container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Transient);
            
            Container.Verify();
        }
    }
}