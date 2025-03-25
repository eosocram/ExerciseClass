namespace PracticeClass
{
    abstract public class AnimalModel
    {
        public string Name { get; set; }

        abstract public void EmitirSom();
    }

    public class Cachorro : AnimalModel
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Name} est� latindo!");
        }
    }

    public class Gato : AnimalModel
    {
        public override void EmitirSom() 
        {
            Console.WriteLine($"{Name} est� miando!");
        }
    }
}