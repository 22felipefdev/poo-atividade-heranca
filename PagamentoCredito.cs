using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class PagamentoCredito : Pagamento
    {
        public string NumeroCartao { get; set; }
        public decimal Desconto { get; set; }

        public PagamentoCredito(decimal ValorOriginal, string numeroCartao) : base(ValorOriginal)
        {
            NumeroCartao = numeroCartao;
            Desconto = ValorOriginal * 0.10m;
            ValorFinal = ValorOriginal - Desconto;
        }
        public override void Exibir()
        {
            Console.WriteLine("Forma de Pagamento: Cartao de Credito");
            Console.WriteLine($"Cartao (Ultimos digitos:) **** **** **** {NumeroCartao}");
            Console.WriteLine($"Valor Original: {ValorOriginal:C2}");
            Console.WriteLine($"Desconto: {Desconto:C2}");
            Console.WriteLine($"Valor final: {ValorFinal:C2}");
        }

    }
}
