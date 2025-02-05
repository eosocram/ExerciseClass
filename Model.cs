namespace PracticeClass
{
    public class ModelCar
    {
        public string nomeCarro;
        public string marcaCarro;
        public int anoCarro;

        public void ShowMeDetails()
        {
            Console.WriteLine($"Nome carro: {nomeCarro}");
            Console.WriteLine($"Marca carro: {marcaCarro}");
            Console.WriteLine($"Ano carro: {anoCarro}");
        }
    }
}