using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class PagamentoDebito : Pagamento
    {
        public string NumeroCartao { get; set; }

        public PagamentoDebito(decimal valorOriginal, string numeroCartao) : base(valorOriginal)
        {
            NumeroCartao = numeroCartao;
        }
        public override void Exibir()
        {
            Console.WriteLine("Forma de Pagamento: Cartao de Debito");
            Console.WriteLine($"Cartao (Ultimos digitos:) **** **** **** {NumeroCartao}");
            Console.WriteLine($"Valor Original: {ValorOriginal:C2}");
            Console.WriteLine("Desconto: N/A");
            Console.WriteLine($"Valor final: {ValorFinal:C2}");
        }
    }
}
