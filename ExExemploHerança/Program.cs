using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExExemploHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma lista
            List<Conta> list = new List<Conta>();
            //Adicionando contas de diversos tipos na lista e passando seus valores
            list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.0));
            list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
            list.Add(new ContaJuridica(1004, "Mae", 500.0, 400.0));

            //Criando a variavel soma
            double soma = 0.0;

            //Criando uma estrutura de repetição para cada conta somar o saldo e armazarnar na variavel soma
            foreach(Conta acc in list)
            {
                soma += acc.Saldo;
            }
            //Impriminso o total do saldo de todas as contas
            Console.WriteLine("Total do saldo de contas: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            //Criando uma estrutura de repetição para chamar o método saque para cada conta (com uma valor de parametro para saldo total de 100)
            foreach(Conta acc in list)
            {
                acc.Saque(10.0);
            }
            //Criando outra estrutura de repetição para escrever cada saldo de cada conta com seu determinado número
            foreach (Conta acc in list)
            {
                Console.WriteLine("Atualização do saldo das contas "
                + acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
