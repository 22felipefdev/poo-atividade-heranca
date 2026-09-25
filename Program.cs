using System;
using System.Collections.Generic;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pagamento> pagamentos = new List<Pagamento>();
            bool Executa = true;

            while (Executa)
            {
                Console.WriteLine("\n =-=Menu=-=");
                Console.WriteLine("1 - Informar Pagamento");
                Console.WriteLine("2 - Listar Pagamentos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opcao");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RegistrarPagamento(pagamentos);
                        break;
                    case "2":
                        ListarPagamentos(pagamentos);
                        break;
                    case "0":
                        Executa = false;
                        Console.WriteLine("Fechando...");
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida!");
                        break;
                }
            }
        }

        static void RegistrarPagamento(List<Pagamento> lista)
        {
            Console.WriteLine("Informe o valor de pagamento: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor) || valor <= 0)
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Console.WriteLine("\nEscolha a forma de pagamento:");
            Console.WriteLine("1 - Dinheiro (a vista)");
            Console.WriteLine("2 - Cartao de Debito");
            Console.WriteLine("3 - Cartao de Credito");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    PagamentoDinheiro din = new PagamentoDinheiro(valor);
                    lista.Add(din);
                    Console.WriteLine("\nPagamento registrado com sucesso!");
                    din.Exibir();
                    break;
                case "2":
                    Console.Write("Informe os 4 ultimos digitos do cartao: ");
                    string digitosDebito = Console.ReadLine();
                    PagamentoDebito deb = new PagamentoDebito(valor, digitosDebito);
                    lista.Add(deb);
                    Console.WriteLine("\nPagamento registrado com sucesso!");
                    deb.Exibir();
                    break;
                case "3":
                    Console.Write("Informe os 4 ultimos digitos do cartao: ");
                    string digitosCredito = Console.ReadLine();
                    PagamentoCredito cred = new PagamentoCredito(valor, digitosCredito);
                    lista.Add(cred);
                    Console.WriteLine("\n Pagamento registrado com sucesso!");
                    cred.Exibir();
                    break;

                default:
                    Console.WriteLine("Forma de pagamento invalida");
                    break;
            }
        }
        static void ListarPagamentos(List<Pagamento> lista)
        {
            Console.WriteLine("\n === Historico de pagamentos ===");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum pagamento registrado ate o momento");
                return;
            }

            foreach (Pagamento p in lista)
            {
                p.Exibir();
            }
        }
    }
}