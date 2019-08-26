
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeContas
{
    class ContaCorrente
    {
        //Atributos da Classe
        private int nconta;
        private string nome;
        private double saldo;

        //Métodos da clasee
        public ContaCorrente(double saldoinicio)
        {
            saldo = saldoinicio;
        }

        public int getConta()
        {
            return nconta;
        }

        public string getNome()
        {
            return nome;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void setConta(int c)
        {
            nconta = c;
        }

        public void setNome(string no)
        {
            nome = no;
        }

        public void setSaldo(double s)
        {
            saldo = s;
        }

        public void credita(double valor)
        {
            saldo = saldo + valor;
        }

        public void debita(double valor)
        {
            saldo = saldo - valor;
        }
    }
}
