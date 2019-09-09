using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Herança_2
{
    public class Estagio : Aluno
    {
        string vaga, empresa;
        int cargahoraria;

        public void setVaga(string v)
        {
            vaga = v;
        }

        public void setEmpresa(string e)
        {
            empresa = e;
        }

        public void setCargaHora(int ch)
        {
            cargahoraria = ch;
        }

        public string getVaga()
        {
            return vaga;
        }

        public string getEmpresa()
        {
            return empresa;
        }

        public int getCarga()
        {
            return cargahoraria;
        }
    }
}
