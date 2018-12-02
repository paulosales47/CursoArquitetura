using Arquitetura.DI.Base.Interfaces;
using System;
using System.Collections.Generic;

namespace Arquitetura.DI.Base
{
    public class MensagemFactory : Dictionary<string, Func<IMensagem>>, IMensagemFactory
    {
        public IMensagem CreateNew(string name) => this[name]();
    }
}
