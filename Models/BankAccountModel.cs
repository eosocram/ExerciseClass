namespace PracticeClass
{
    
    public class DepositoPix : BankAccount
    {
        
        private static readonly Random random = new Random();

        public int numConta { get; set; }
        public decimal saldo { get;  private set; }

        public DepositoPix()
        {
            saldo = random.Next(-250, 250);
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
        public void ExibirSaldoCompleto()
        {
             Console.WriteLine($"Número da conta: {numConta}");
             Console.WriteLine($"Saldo atual: {saldo}");
        }

        public void ProcessarDeposito(decimal valor)
        {
             
            saldo += valor;
            Console.WriteLine($"O depósito no valor de {valor:C} foi realizado via PIX");
        }
    }

    public interface BankAccount
    {
        public int numConta { get; set; }
        public decimal saldo { get; }
        void ProcessarDeposito(decimal valor);
        void ExibirSaldoCompleto();
        void ExibirSaldo();



    }

}

