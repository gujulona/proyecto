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
    public partial class FormaLPM : Form
    {
        public FormaLPM()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double cardiaco = double.Parse(textoEdad.Text);

                if (cardiaco <= 0 || cardiaco >= 105)
                {
                    MessageBox.Show("Edad Invalida");
                }
                else
                {
                    double resultado = (220 - cardiaco);

                    labelLatidos.Text = resultado.ToString();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingresa valores validos");
            }
        }

        private void labelLatidos_Click(object sender, EventArgs e)
        {

        }
    }
}
