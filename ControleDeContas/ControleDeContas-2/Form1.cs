using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeContas_2;

namespace ControleDeContas
{
    public partial class Form1 : Form
    {
        ContaCorrente cc = new ContaCorrente();

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

            if(textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0)
            {
                cc.setConta(Convert.ToInt32(textBox1.Text));
                cc.setNome(textBox2.Text);
                cc.setSaldo(Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Dados cadastrado com sucesso!");
            }
            
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
                cc.credita(Convert.ToInt32(textBox4.Text));
                MessageBox.Show("Foi Creditado " + textBox4.Text + "$ na sua conta");
                textBox4.Text = "";
            }
            else if (radioButton2.Checked)
            {
                cc.debita(Convert.ToInt32(textBox4.Text));
                MessageBox.Show("Foi debitado " + textBox4.Text + "$ da sua Conta");
                textBox4.Text = "";
            }

            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo da sua conta: $" + cc.getSaldo());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
