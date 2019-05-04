using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int numero;
            string depositoInicial;
            double deposito;
            double saque;

            // Conta 01
            for (int i = 0; i < 2; i++){

                deposito = 0.0;
                saque = 0.0;

                // Cria conta
                Console.Write("Num. Conta: ");
                numero = int.Parse(Console.ReadLine());
                Console.Write("Nome do Titular: ");
                nome = Console.ReadLine();
                Conta conta = new Conta(numero, nome);
                Console.Write("Haverá deposito inicial? S/N ");
                depositoInicial = Console.ReadLine();
                if (depositoInicial.ToUpper() == "S") {
                    Console.Write("Valor deposito inicial: ");
                    deposito = double.Parse(Console.ReadLine());
                    conta.Deposito(deposito);
                }
                ExibeDados(conta, "Dados da Conta:");

                // Efetua deposito
                Console.Write("Valor do deposito: ");
                deposito = double.Parse(Console.ReadLine());
                conta.Deposito(deposito);
                ExibeDados(conta, "Dados da Conta (Atualizado):");
                // Efetua saque
                Console.Write("Valor do saque: ");
                saque = double.Parse(Console.ReadLine());
                conta.Saque(saque);
                ExibeDados(conta, "Dados da Conta (Atualizado):");
            }

            Console.WriteLine("Fim");
        }

        static void ExibeDados(Conta conta, string msg)
        {
            Console.WriteLine();
            Console.WriteLine(msg);
            Console.WriteLine(conta.ToString());
            Console.WriteLine();
        }
    }
}
