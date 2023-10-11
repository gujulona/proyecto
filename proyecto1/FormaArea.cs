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
    public partial class FormaArea : Form
    {
        public FormaArea()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void butonCalcular_Click(object sender, EventArgs e)
            
        {
            try
            {
                float baseT = float.Parse(textoBase.Text);
                float altura = float.Parse(textoAltura.Text);
                if (baseT < 0 || altura < 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    float area = (baseT * altura / 2);
                    labelArea.Text = area.ToString();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("ingresa valores validos");
            }
        }


        private void textoBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormaArea_Load(object sender, EventArgs e)
        {

        }
    }
}
