using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMistica
{
    class Veiculo
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Veiculo(string tipoveiculo)
        {
            this.tipo = tipoveiculo;
        }

        public virtual void Mover()
        {

        }

        public virtual void Parar()
        {

        }

        


    }
}
