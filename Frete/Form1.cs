using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frete
{
    public partial class Form1 : Form
    {
        Frete ft = new Frete();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ft.setCode(Convert.ToInt32(textBox1.Text));
            ft.setValue(Convert.ToInt32(textBox3.Text));

            if (radioButton1.Checked)
            {
                ft.setDest("SP");
            }

            if (radioButton2.Checked)
            {
                ft.setDest("Outros");
            }

            if (ft.getDest().Equals("SP"))
            {
                ft.FreteSP(Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Código da carga: " + ft.getCode() + "\nEstado de Destino: " + ft.getDest() + "\nValor total a ser pago: $" + ft.FreteSP(Convert.ToInt32(textBox3.Text)));
            }

            if (ft.getDest().Equals("Outros"))
            {
                ft.FreteOutros(Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Código da carga: " + ft.getCode() + "\nEstado de Destino: " + ft.getDest() + "\nValor total a ser pago: $" + ft.FreteOutros(Convert.ToInt32(textBox3.Text)));

            }

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";

        }
    }
}
