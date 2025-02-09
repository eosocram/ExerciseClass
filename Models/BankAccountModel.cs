namespace PracticeClass
{

    public class BankAccountModel
    {
        private static readonly Random random = new Random();


        public int numConta { get; set; }
        public decimal saldo  { get; private set; }

        public BankAccountModel()
        {
            saldo = random.Next(-250, 250);
        }


        public void ExibirDetalhes()
        {
            Console.WriteLine($"Número conta: {numConta}");
            Console.WriteLine($"Saldo disponível: {saldo}");
        }

        public void Deposit(decimal saldoAtualizado)
        {
            if (saldo < 0 && saldoAtualizado > 0)
            {
                saldo += saldoAtualizado;
                Console.WriteLine($"Débito automático da conta - MOTIVO: uso do crédito especial. Saldo atual R${saldo}");
            }
            else if (saldo > 0 &&  saldoAtualizado > 0)
            {
                saldo += saldoAtualizado;
                Console.WriteLine($"Saldo atualizado R${saldo}");
            }
        }
    }
}

