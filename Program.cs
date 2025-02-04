namespace PracticeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro primeiroCarro = new Carro();
            Console.WriteLine("Insira os dados do carro abaixo:");
            Console.WriteLine("Nome do carro:");
            primeiroCarro.nomeCarro = Console.ReadLine();

            Console.WriteLine("Marca do carro:");
            primeiroCarro.marcaCarro = Console.ReadLine();

            Console.WriteLine("Ano do carro:");
            primeiroCarro.anoCarro = int.Parse(Console.ReadLine());

            Console.WriteLine($"{primeiroCarro.nomeCarro}, {primeiroCarro.marcaCarro}, {primeiroCarro.anoCarro}");


        }

    }

    class Carro
    {
        public string nomeCarro;
        public string marcaCarro;
        public int anoCarro; 
    }
}