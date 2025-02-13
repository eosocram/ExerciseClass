using System;

namespace PracticeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount conta = new DepositoPix();

            Console.WriteLine("Digite o número da conta:");
            conta.numConta = int.Parse(Console.ReadLine());
            conta.ExibirSaldoCompleto();

            Console.WriteLine("Insira o valor:");
            decimal pagamentoPix = decimal.Parse(Console.ReadLine());


            conta.ProcessarDeposito(pagamentoPix);
            conta.ExibirSaldo();

        }

    }
}


