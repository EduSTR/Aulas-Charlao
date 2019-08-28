using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frete
{
    class Frete
    {
        private int codigo;
        private double valornota;
        private String destino;


        public void setCode(int cod)
        {
            codigo = cod;
        }

        public void setDest(string d)
        {
            destino = d;
        }

        public void setValue(double va)
        {
            valornota = va;
        }

        public int getCode()
        {
            return codigo;
        }

        public string getDest()
        {
            return destino;
        }

        public double getValue()
        {
            return valornota;
        }

        public double FreteSP(double v)
        {
            
            if (getValue() < 3000)
            {
               v = (getValue() + (0.05 * getValue()));
            }

            else if (getValue() >= 3000 && getValue() <= 5000)
            {
               v = (getValue() + (0.1 * getValue()));
            }

            else if (getValue() > 5000)
            {
                v = (getValue() + (0.15 * getValue()));
            }
            return v;
        }

        public double FreteOutros(double v)
        {
            v = (getValue() + (0.2 * getValue()));
            return v;
        }
    }
}
