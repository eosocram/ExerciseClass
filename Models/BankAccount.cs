namespace PracticeClass
{

    public class PagamentoBoleto : IBankAccount
    {
        public int numConta {  get; set; }
        public decimal saldo { get; private set; }

        private static readonly Random random = new Random();

        public PagamentoBoleto()
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

        public void ProcessarPagamento(decimal valor)
        {

            saldo += valor;
            Console.WriteLine($"O pagamento no valor de {valor:C} foi realizado via Boleto com o prazo de até 48h para o faturamento.");
        }
    }

    public class PagamentoPix : IBankAccount
    {

        private static readonly Random random = new Random();

        public int numConta { get; set; }
        public decimal saldo { get;  private set; }

        public PagamentoPix()
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

        public void ProcessarPagamento(decimal valor)
        {
             
            saldo += valor;
            Console.WriteLine($"O pagamento no valor de {valor:C} foi realizado via PIX");
        }
    }

    public interface IBankAccount
    {
        public int numConta { get; set; }
        public decimal saldo { get; }
        void ProcessarPagamento(decimal valor);
        void ExibirSaldoCompleto();
        void ExibirSaldo();




    }

}

