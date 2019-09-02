using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Herança
{
    public class Pessoa
    {
        private string nome, sexo;
        private int idade;

        public void setNome(String n)
        {
            nome = n;
        }

        public void setSex(String s)
        {
            sexo = s;
        }

        public void setIdade(int id)
        {
            idade = id;
        }

        public String getNome()
        {
            return nome;
        }
    }
}
