using System;
using System.Globalization;

namespace ExercicioEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero da conta: ");
            int numeroConta = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Havera deposito inicial: ");
            char comDepositoInicial = Convert.ToChar(Console.ReadLine());

            Conta c1 = new Conta(numeroConta, nomeTitular);

            if (comDepositoInicial == 's')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double saldoInicial = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1.SaldoInicial(saldoInicial);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c1);

            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Depositar(deposito);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Sacar(saque);


        }
    }
}
