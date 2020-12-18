using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioEncapsulamento
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }
        public Conta(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular) // por meio deste this eu acesso o outro construtor.
        {
            this.Depositar(depositoInicial);
        }

        public void Sacar(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor + 5;
                Console.WriteLine($"Dados da conta atualizados: ");
                Console.WriteLine(this.ToString());
            }
            else
            {
                Console.WriteLine($"Valor solicitado: {valor} maior que saldo: {Saldo}");
            }
        }

        public void SaldoInicial(double saldoInicial)
        {
            Saldo += saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Dados da conta atualizados: ");
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
