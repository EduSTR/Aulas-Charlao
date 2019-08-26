using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeContas_2;

namespace ControleDeContas_2
{
    class ContaCorrente
    {
        private int nconta;
        private string nome;
        private double saldo;

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

        public void setSaldo(int sa)
        {
            this.saldo = sa;
        }

        public void setNome(string no)
        {
            this.nome = no;
        }

        public void setConta(int co)
        {
            this.nconta = co;
        }

        public void credita(double valor)
        {
            this.saldo = saldo + valor;
        }

        public void debita(double valor)
        {
            this.saldo = saldo - valor;
        }






    }
}
