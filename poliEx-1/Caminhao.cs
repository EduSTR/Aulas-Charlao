using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poliEx_1
{
    class Caminhao : Veiculo
    {
        protected int eixos;

        public int Eixos
        {
            get { return eixos; }
            set { eixos = value; }
        }

        public override void ExibirDados()
        {
            
        }
    }
}
