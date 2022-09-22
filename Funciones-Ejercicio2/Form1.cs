using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Text = sumar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();

                double sumar(double numero1, double numero2)
                {
                    double suma = numero1 + numero2;
                    return suma;
                }
            }

            if (checkBox2.Checked == true)
            {
                textBox3.Text = restar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();

                double restar(double numero1, double numero2)
                {
                    double resta = numero1 - numero2;
                    return resta;
                }
            }

            if (checkBox3.Checked == true)
            {
                textBox3.Text = multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();

                double multiplicar(double numero1, double numero2)
                {
                    double multiplicacion = numero1 * numero2;
                    return multiplicacion;
                }
            }

            if (checkBox4.Checked == true)
            {
                textBox3.Text = dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();

                double dividir(double numero1, double numero2)
                {
                    double division = numero1 / numero2;
                    return division;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }
    }
}
