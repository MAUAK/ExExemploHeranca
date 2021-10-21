using System;
using System.Collections.Generic;
using System.Text;

namespace ExExemploHerança
{
    //Criando uma subclasse Conta Juridica
    class ContaPoupanca :  Conta
    {
        //Declarando as variáveis com o encapsulamento
        public double TaxaJuros { get; set; }

        //Criando um construtor padrão
        public ContaPoupanca()
        {

        }
        //Criando um construtor com parâmetros
        public ContaPoupanca (int numero, string titular, double saldo, double taxaJuros) : base (numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
            
        }
        //Criando método de atualização de saldo
        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        
        //Sobrescrevendo o método saque da super classe Conta
        public override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }
}
