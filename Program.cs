using System;

namespace PracticeClass
{
    class Program
    {
        static void Main(string[] args)
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

    //IBankAccount pgPix = new PagamentoPix();
    //IBankAccount pgBoleto = new PagamentoBoleto();

    //Console.WriteLine("Digite o número da conta:");
    //pgPix.numConta = int.Parse(Console.ReadLine());

    //pgPix.ExibirSaldoCompleto();

    //IBankAccount pagamento;
    //Console.WriteLine("Escolha um método de pagamento: 1 - PIX | 2 - BOLETO (PRAZO 48H)");
    //int opcao = int.Parse(Console.ReadLine());
    //switch (opcao) 
    //{
    //    case 1:
    //        Console.WriteLine("1");
    //        break;
    //    case 2:
    //        Console.WriteLine("2");
    //        break;
    //};


    //decimal pagamento = decimal.Parse(Console.ReadLine());


    //pgPix.ProcessarPagamento(pagamento);
    //pgPix.ExibirSaldo();


