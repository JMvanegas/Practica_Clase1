using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox4.Text = "0";
            textBox5.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string Datos;
            a = int.Parse(textBox4.Text);
            b = int.Parse(textBox5.Text);
            r = a + b;
            Datos = "Resultado: " + r.ToString();
            label1.Text = Datos;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string Datos;
            a = int.Parse(textBox4.Text);
            b = int.Parse(textBox5.Text);
            r = a / b;
            Datos = "Resultado: " + r.ToString();
            label1.Text = Datos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string Datos;
            a = int.Parse(textBox4.Text);
            b = int.Parse(textBox5.Text);
            r = a - b;
            Datos = "Resultado: " + r.ToString();
            label1.Text = Datos;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string Datos;
            a = int.Parse(textBox4.Text);
            b = int.Parse(textBox5.Text);
            r = a * b;
            Datos = "Resultado: " + r.ToString();
            label1.Text = Datos;
        }
    }
}
