using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Herança_2
{
    public class Aluno
    {
        string nome, matricula;
        DateTime datanasc;

        public void setNome(string n)
        {
            nome = n;
        }

        public void setData(DateTime dn)
        {
            datanasc = dn;
        }

        public void setMat(string ma)
        {
            matricula = ma;
        }

        public string getNome()
        {
            return nome;
        }

        public DateTime getData()
        {
            return datanasc;
        }

        public string getMat()
        {
            return matricula;
        }
    }
}
