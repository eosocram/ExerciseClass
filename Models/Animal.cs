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
            Console.WriteLine($"{Name} está latindo!");
        }
    }

    public class Gato : AnimalModel
    {
        public override void EmitirSom() 
        {
            Console.WriteLine($"{Name} está miando!");
        }
    }
}