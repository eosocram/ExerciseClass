using System;

namespace PracticeClass
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }
        private static void AppBank()
        {

            Console.WriteLine("Digite o número da conta:");
            int numConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um método de pagamento: 1 - PIX | 2 - BOLETO (FATURAMENTO EM ATÉ 48H)");
            int opcao = int.Parse(Console.ReadLine());

            IBankAccount pagamento;
            switch (opcao)
            {
                case 1:
                    pagamento = new PagamentoPix();
                    Console.WriteLine("Pagamento via PIX selecionado.");
                    break;
                case 2:
                    pagamento = new PagamentoBoleto();
                    Console.WriteLine("Pagamento via BOLETO selecionado.");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    return;
            };


            pagamento.numConta = numConta;
            pagamento.ExibirSaldoCompleto();

            Console.WriteLine("Valor do pagamento:");
            decimal valor = decimal.Parse(Console.ReadLine());

            pagamento.ProcessarPagamento(valor);
            pagamento.ExibirSaldo();
        }
    }
}



