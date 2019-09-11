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

        public string verificaEstagio(DateTime x)
        {
            string validar;

            if (Convert.ToDateTime(x).AddYears(18) <= DateTime.Now)
            {
                validar = "maior";
            }
            else
            {
                validar = "menor";
            }
            return validar;
        }

    }
}
