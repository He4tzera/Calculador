using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Calculadora_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox1.Text);
            int numero2 = Convert.ToInt32(numero2TextBox2.Text);

            int multiplicar = numero1 * numero2;

            label2.Text = Convert.ToString(multiplicar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox1.Text);
            int numero2 = Convert.ToInt32(numero2TextBox2.Text);

            int soma = numero1 + numero2;

            label2.Text = Convert.ToString(soma);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox1.Text);
            int numero2 = Convert.ToInt32(numero2TextBox2.Text);

            int dividir = numero1 / numero2;

            label2.Text = Convert.ToString(dividir);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void subitrairButton4_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox1.Text);
            int numero2 = Convert.ToInt32(numero2TextBox2.Text);

            int subtrair = numero1 - numero2;

            label2.Text = Convert.ToString(subtrair);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numero1TextBox1.Text = "";
            numero2TextBox2.Text = "";
            label2.Text = "";

        }
    }
}
