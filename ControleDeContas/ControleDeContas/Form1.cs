using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeContas;

namespace ControleDeContas
{
    public partial class Form1 : Form
    {
        ContaCorrente x = new ContaCorrente(0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            x.setConta(Convert.ToInt32(textBox1.Text));
            x.setNome(textBox2.Text);
            x.setSaldo(Convert.ToDouble(textBox3.Text));

            MessageBox.Show("Dados cadastrados com Sucesso!","Abertura de Conta");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                x.credita(Convert.ToInt32(textBox4.Text));
                MessageBox.Show("Crédito de " + textBox4.Text + "Reais " + "realizado com sucesso");
            }
            else if (radioButton2.Checked)
            {
                x.debita(Convert.ToInt32(textBox4.Text));
                MessageBox.Show("Debito" + textBox4.Text + "Reais " + "realizado com sucesso");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox4.Text = Convert.ToString(x.getSaldo());
            }
            else if (radioButton2.Checked)
            {
                textBox4.Text = Convert.ToString(x.getSaldo());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
