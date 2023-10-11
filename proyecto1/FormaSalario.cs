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
    public partial class FormaSalario : Form
    {
        public FormaSalario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               
                double salario = double.Parse(textSalario.Text);
                if (salario <= 0)
                {
                    MessageBox.Show("Error");
                }

                else
                {
                    double incremento = (salario * 0.25) + salario;

                    labelincremeto.Text = incremento.ToString();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingresa Valores Validos");
            }

        }
    }
}
