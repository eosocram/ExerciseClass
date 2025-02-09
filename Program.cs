using System;

namespace PracticeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            

            BankAccountModel x = new BankAccountModel();

            Console.WriteLine("Digite o número da conta:");
            x.numConta = int.Parse(Console.ReadLine());
            x.ExibirDetalhes();

            Console.WriteLine("Digite um valor para realizar o depósito:");
            decimal valorDeposito = decimal.Parse(Console.ReadLine());
            x.Deposit(valorDeposito);

            x.ExibirDetalhes();




        }

    }
}


