using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMistica
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] v = new Veiculo[2];
            v[0] = new Automovel("Ferrari");
            v[1] = new Aeronave("Tucano");

            Console.WriteLine(v[0].Tipo);
            v[0].Mover();

            Console.WriteLine(v[1].Tipo);
            v[1].Parar();


        }
    }
}
