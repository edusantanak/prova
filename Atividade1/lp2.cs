using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            int valor1, valor2, result;

            valor1 = Convert.ToInt16(textBox1.Text);
            valor2 = Convert.ToInt16(textBox2.Text);

            result = valor1 + valor2;
            label4.Text = Convert.ToString(result);




        }

        private void menos_Click(object sender, EventArgs e)
        {

            int valor1, valor2, result;

            valor1 = Convert.ToInt16(textBox1.Text);
            valor2 = Convert.ToInt16(textBox2.Text);

            result = valor1 - valor2;
            label4.Text = Convert.ToString(result);
        }

        private void vezes_Click(object sender, EventArgs e)
        {

            int valor1, valor2, result;

            valor1 = Convert.ToInt16(textBox1.Text);
            valor2 = Convert.ToInt16(textBox2.Text);

            result = valor1 * valor2;
            label4.Text = Convert.ToString(result);
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            float valor1, valor2, result;

            valor1 = Convert.ToInt16(textBox1.Text);
            valor2 = Convert.ToInt16(textBox2.Text);

            result = valor1 / valor2;
            label4.Text = Convert.ToString(result);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}