using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace poliEx_1
{
    class Veiculo
    {
        protected string placa;
        protected int ano;

        public string Placa
        {
            get{ return placa; }
            set{ placa = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public virtual void ExibirDados()
        {
           
        }
    }
}
