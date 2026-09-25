using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class PagamentoDinheiro : Pagamento
    {
        public PagamentoDinheiro(decimal valorOriginal) : base(valorOriginal)
        {
        }

        public override void Exibir()
        {
            Console.WriteLine("Forma de Pagamento: Dinheiro (a vista)");
            Console.WriteLine($"Valor original: {ValorOriginal:C2}");
            Console.WriteLine("Desconto: N/A");
            Console.WriteLine($"Valor final: {ValorFinal:C2}");
        }
    }
}
