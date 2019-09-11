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

            if (aec.verificaEstagio(aec.getData()).Equals("maior"))
            {
                MessageBox.Show("Você foi cadastrado com sucesso na vaga de estágio!.\n" + "--------------------------------------------------------------------\n" + "Seus Dados:\n" + "Nome: " + aec.getNome() + "\nData de Nascimento: " + aec.getData() + "\nMatricula: " + aec.getMat() + "\nVaga: " + aec.getVaga() + "\nEmpresa: " + aec.getEmpresa() + "\nCarga/Hora: " + aec.getCarga());
            }
            else
            {
                MessageBox.Show("Erro! Aluno menor de 18 anos.");
            }

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
