using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Pagamento
    {
            public decimal ValorOriginal { get; set; }
            public decimal ValorFinal { get; set; }


            public Pagamento(decimal valorOriginal)
            {
                ValorOriginal = valorOriginal;
                ValorFinal = valorOriginal;
            }

            public virtual void Exibir()
            {
                Console.WriteLine($"Valor Original: {ValorOriginal:C}");
                Console.WriteLine($"Valor Final: {ValorFinal:C}");
            }
        }
}

