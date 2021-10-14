using System;
using System.Collections.Generic;
using System.Text;

namespace ExExemploHerança
{
    //Criando a classe conta
    class Conta
    {
        //Declarando as variáveis com o encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }

        //Usando o protected para alteração de valores entre classes
        public double Saldo { get; protected set; }

        //Criando um construtor padrão
        public Conta()
        {

        }

        //Criando um construtor com parâmetros
        public Conta (int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        //Criando o método de saque
        public void Saque (double saldoTotal)
        {
            Saldo -= saldoTotal;
        }

        //Método de Depósito
        public void Deposito (double saldoTotal)
        {
            Saldo += saldoTotal;
        }

    }
}
