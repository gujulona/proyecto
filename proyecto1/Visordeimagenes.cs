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
    public partial class FormaVisor : Form
    {
        public FormaVisor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Muestra el cuadro de diálogo Abrir archivo. Si el usuario hace clic en Aceptar, carga el
            // imagen que eligió el usuario. 
            if ( openFileDialog1.ShowDialog() == DialogResult.OK)
            {           
                    pictureBox1.Load(openFileDialog1.FileName);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Borara la imagen 
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Muestra el cuadro de diálogo de color. Si el usuario hace clic en Aceptar, cambie el
            // Fondo del control PictureBox al color elegido por el usuario.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Si el usuario selecciona la casilla de verificación Strech,
            // cambiar el PictureBox
            // Propiedad SizeMode para "Strech". Si el usuario borra
            // la casilla de verificación, cámbiela a "Normal"

            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
