using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.SOLID.OCP.Solucao_Interface
{
    public class ContaInvestimento : IConta
    {
        public void Debitar(decimal valor, string conta)
        {
            //debita conta investimento
        }
    }
}
