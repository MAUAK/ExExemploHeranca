using System;
using System.Collections.Generic;
using System.Text;

namespace ExExemploHerança
{
    //Criando uma subclasse Conta Juridica
    class ContaJuridica : Conta
    {
        //Declarando a variável e usando o encapsulamento
        public double EmprestimoLimite { get; set; }

        //Criando o contrutor padrão
        public ContaJuridica() { }

        //Criando o construtor com parâmetros
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        //Criando o método Emprestimo
        public void Emprestimo(double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}
