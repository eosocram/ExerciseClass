namespace PracticeClass
{
    public class BankAccount
    {
        public int numConta { get; set; }
        public decimal saldo = 2500;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Número conta: {numConta}");
            Console.WriteLine($"Saldo disponível: {saldo}");
        }

        public void Deposit()
        {
            Console.WriteLine("Adicione saldo para sua conta:");
            decimal depositAccount = decimal.Parse(Console.ReadLine());

            decimal valorFinal = saldo + depositAccount;
            Console.WriteLine($"O saldo disponível atualizado é de: R${valorFinal}");
        }
    }

    
}