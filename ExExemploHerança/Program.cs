using System;

namespace ExExemploHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma nova conta juridica e passando os valores de cada variável
            ContaJuridica conta = new ContaJuridica(8010, "LARA", 100.0, 500.0);

            //Imprimindo o saldo da conta cadastrada
            Console.WriteLine(conta.Saldo);

            
        }
    }
}
