using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Herança_2
{
    public partial class Form1 : Form
    {
        Curso aec = new Curso();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            aec.setNome(textBox1.Text);
            aec.setData(dateTimePicker1.Value);
            aec.setMat(textBox3.Text);
            aec.setVaga(textBox4.Text);
            aec.setEmpresa(textBox5.Text);
            aec.setCargaHora(Convert.ToInt32(textBox6.Text));

            MessageBox.Show(Convert.ToDateTime(aec.getData()).ToString());
        }

    }
}
