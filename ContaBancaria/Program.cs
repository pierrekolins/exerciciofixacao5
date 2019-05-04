using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            // Conta 01
            for (int i = 0; i < 2; i++){                
                // Cria conta
                Console.Write("Num. Conta: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome do Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Haverá deposito inicial? S/N ");
                char deposita = char.Parse(Console.ReadLine());
                if (deposita == 'S' || deposita == 's')
                {
                    Console.Write("Valor deposito inicial: ");
                    double depositoInicial = double.Parse(Console.ReadLine());
                    conta = new Conta(numero, titular, depositoInicial);
                }
                else
                {
                    conta = new Conta(numero, titular);
                }
                ExibeDados(conta, "Dados da Conta:");

                // Efetua deposito
                Console.Write("Valor do deposito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta.Deposito(deposito);
                ExibeDados(conta, "Dados da Conta (Atualizado):");
                // Efetua saque
                Console.Write("Valor do saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.Saque(saque);
                ExibeDados(conta, "Dados da Conta (Atualizado):");
            }

            Console.WriteLine("Fim");
        }

        static void ExibeDados(Conta conta, string msg)
        {
            Console.WriteLine();
            Console.WriteLine(msg);
            Console.WriteLine(conta);
            Console.WriteLine();
        }
    }
}
