using System;

namespace Course

{
    class Program
    {
        static void Main(string[] args)
        {
            //    Pessoa x, y;
            //    x = new Pessoa();
            //    y = new Pessoa();

            //    Console.WriteLine("Nome e idade da primeira pessoa:");
            //    x.nome = Console.ReadLine();
            //    x.idade = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Nome e idade da segunda pessoa:");
            //    y.nome = Console.ReadLine();
            //    y.idade = int.Parse(Console.ReadLine());

            //    if (x.idade > y.idade)
            //    {
            //        Console.WriteLine($"{x.nome} é a pessoa mais velha.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{y.nome} é a pessoa mais velha.");
            //    }



            Colaborador x, y;
            x = new Colaborador();
            y = new Colaborador();

            Console.WriteLine("Digite o nome e salário do funcionário:");
            x.nomeColaborador = Console.ReadLine();
            x.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e salário do funcionário:");
            y.nomeColaborador = Console.ReadLine();
            y.salario = double.Parse(Console.ReadLine());

            double salarioMedio = (x.salario + y.salario) / 2;  
            Console.WriteLine($"O salário médio é {salarioMedio}");
        }

    }
    class Colaborador
    {
        public string nomeColaborador;
        public double salario;
    }


    class Pessoa
    {
        public string nome;
        public int idade;

    }
}