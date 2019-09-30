using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poliEx_1
{
    class Onibus : Veiculo
    {
        protected int assentos;

        public int Assentos
        {
            get { return assentos; }
            set { assentos = value; }
        }

        public override void ExibirDados()
        {
            
        }
    }
}
