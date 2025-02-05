using System;

namespace PracticeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelCar carro = new ModelCar();

            Console.WriteLine("Digite os dados do carro:");

            Console.WriteLine("Modelo do Carro:");
            carro.nomeCarro = Console.ReadLine();

            Console.WriteLine("Marca do carro:");
            carro.marcaCarro = Console.ReadLine();

            Console.WriteLine("Ano do carro:");
            carro.anoCarro = int.Parse(Console.ReadLine());


            carro.ShowMeDetails();
        }

    }
}


