using System;
using System.Linq;

namespace Arquitetura.SOLID.OCP.Solucao_Interface
{
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public decimal Valor { get; set; }
        public string NumeroTransacao { get; set; }

        public void Debitar(decimal valor, string conta, IConta tipoConta)
        {
            tipoConta.Debitar(valor, conta);
        }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero de transacao formatado
            return NumeroTransacao;
        }
    }
}
