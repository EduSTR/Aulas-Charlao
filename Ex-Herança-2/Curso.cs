using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Herança_2
{
    public class Curso : Estagio
    {
        string curso, aprovado;

        public void cadastraVaga()
        {
            
        }

        public void cadastraAluno()
        {

        }

        public string verificaEstagio()
        {
            string estagio;
            if (getData() - DateTime.Now >= TimeSpan.FromDays(6570))
            {
                estagio = "s";
            }
            else
            {
                estagio = "n";
            }
            return estagio;
        }

    }
}
