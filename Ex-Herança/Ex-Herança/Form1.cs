using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Herança
{
    public partial class Form1 : Form
    {
        Empregado ep = new Empregado();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ep.setNome(textBox1.Text);
            ep.setSex(textBox2.Text);
            ep.setIdade(Convert.ToInt32(textBox3.Text));
            ep.setMatricula(textBox4.Text);
            ep.setSalario(Convert.ToInt32(textBox5.Text));
            ep.DescontoINSS(ep.getSalario());

            MessageBox.Show("Salario: " + ep.DescontoINSS(ep.getSalario()));

        }
    }
}
