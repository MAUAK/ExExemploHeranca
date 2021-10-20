using System;

namespace ExExemploHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma nova conta juridica e passando os valores de cada variável
            ContaPoupanca conta = new ContaPoupanca(8010, "LARA", 100.0, 500.0);

            //Chamando o método Saque
            conta.Saque();

            //Imprimindo o saldo da conta cadastrada
            Console.WriteLine(conta.Saldo);

            /*------------UPCASTING AND DOWNCASTING------------------
             
            //Instanciando uma Conta e passando os valores nela
            Conta acc = new Conta(1001, "Goku", 0.0);
            //Instanciando uma varialvel conta juridica e passando os valores nela
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);

            //Upcasting - instanciando um objeto da classes filhas(Conta) para uma classe base (Conta juridica) / e já passando valores para as demais variaveis
            Conta acc1 = bacc;
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
            Conta acc3 = new ContaJuridica(1004, "Vegeta", 0.0, 0.01);

            //Downcasting - instanciando um objeto da classe base (acc4 - Conta juridica) para uma classe base (acc2 - Conta juridica)
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);

            //Comparando se a conta acc3 é uma conta juridica
            if(acc3 is ContaJuridica)
            {
                //instanciando contas de classe base(acc5 - Conta juridica) para uma classe base (acc3 - Conta juridica)
                    //ContaPoupanca acc5 = (ContaPoupanca)acc3;
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }

            //Comparando se a conta acc3 é uma conta poupança
            if (acc3 is ContaPoupanca)
            {
                //instanciando contas de classe base(acc5 - Conta juridica) para uma classe base (acc3 - Conta juridica)
                    //ContaPoupanca acc5 = (ContaPoupanca)acc3;
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
            */
            
        }
    }
}
