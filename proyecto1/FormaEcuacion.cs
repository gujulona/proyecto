using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormaEcuacion : Form
    {
        public FormaEcuacion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double valorA = double.Parse(textoValorA.Text);
                double valorB = double.Parse(textoValorB.Text);
                double valorC = double.Parse(textoValorC.Text);
                double cuadratica = (valorB * valorB) - (4 * valorA * valorC);

                if (cuadratica > 0)
                {
                    double xuno = (-valorB + Math.Sqrt(cuadratica)) / (2 * valorA);
                    double xdos = (-valorB - Math.Sqrt(cuadratica)) / (2 * valorA);

                    labelUno.Text = xuno.ToString();
                    labelDos.Text = xdos.ToString();

                }
                else
                {
                    MessageBox.Show("Error:no solucion");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ingresa valores validos");
            }
        }

        private void FormaEcuacion_Load(object sender, EventArgs e)
        {

        }

        private void labelDos_Click(object sender, EventArgs e)
        {

        }
    }
}
