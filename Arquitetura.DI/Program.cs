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

            Container.Collection.Register<IMensagem>(typeof(Email), typeof(SMS));
            Container.Register<IClienteService, ClienteService>(Lifestyle.Transient);
            Container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Transient);

            Container.Verify();
        }
    }
}