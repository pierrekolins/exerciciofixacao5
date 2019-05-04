using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta() {
        }

        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public Conta(int numero, string titular, double depositoInicial) : this (numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito){
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return "Conta: "+Numero
                +", Titular: "+Titular
                +", Saldo: "+Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
