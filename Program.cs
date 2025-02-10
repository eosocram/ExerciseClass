using System;

namespace PracticeClass
{
    class Program
    {
        static void Main(string[] args)
        {


            //Cachorro cachorro = new Cachorro();
            //Console.WriteLine("Nome do cachorro:");
            //cachorro.Name = Console.ReadLine();
            //cachorro.EmitirSom();
            Gato gato = new Gato();
            Console.WriteLine("Digite o nome do gato:");
            gato.Name = Console.ReadLine();
            gato.EmitirSom();


            

        }

    }
}


