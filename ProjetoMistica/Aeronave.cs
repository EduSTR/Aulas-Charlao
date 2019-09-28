using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMistica
{
    class Aeronave : Veiculo
    {
        public Aeronave(string tipoveiculo) : base(tipoveiculo)
        {

        }

        public override void Mover()
        {
            Console.WriteLine("Decolando o avião... ");
        }

        public override void Parar()
        {
            Console.WriteLine("Aterrisando o avião. ");
        }
    }
}
