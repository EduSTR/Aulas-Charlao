using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Herança
{
    public class Empregado : Pessoa
    {
        private double salario;
        private string matricula;
        Pessoa pe = new Pessoa();

        public void setMatricula(String m)
        {
            matricula = m;
        }

        public void setSalario(double s)
        {
            salario = s;
        }

        public double getSalario()
        {
            return salario;
        }

        public double DescontoINSS(double v)
        {
            if (getSalario() <= 3000)
            {
                v = getSalario() - (0.03 * getSalario());
            }

            if (getSalario() >= 3001 && getSalario() <= 7000)
            {
                v = getSalario() - (0.05 * getSalario());
            }

            else if (getSalario() > 7000)
            {
                v = getSalario() - (0.11 * getSalario());
            } 

            return v;
        }
 
    }
}

