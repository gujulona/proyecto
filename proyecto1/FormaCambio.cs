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
    public partial class FormaCambio : Form
    {
        public FormaCambio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double mexicano = double.Parse(textoMexicano.Text);
                if (mexicano <= 0)
                {
                    MessageBox.Show("Ingresa numero valido");
                }
                else
                {
                    double dolares = (mexicano / 2) * 0.056;
                    double euros = (mexicano / 2) * 0.053;

                    labelEuro.Text = euros.ToString();
                    labelDolar.Text = dolares.ToString();
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Ingresa validos");
            }
            
        }

        private void FormaCambio_Load(object sender, EventArgs e)
        {

        }
    }
}
