using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMistica
{
    class Automovel : Veiculo
    {
        public Automovel(string tipoveiculo) : base(tipoveiculo)
        {

        }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o carro... ");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o carro. ");
        }

        
        

    }
}
