using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto1.Formu;

namespace proyecto1.Formu
{
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaVideo video = new FormaVideo();
            video.Show();
        }

        private void menuRegistroUsuario_Click(object sender, EventArgs e)
        {
            //hecho por Edna
            FormaRegistro registro = new FormaRegistro();
            registro.Show();
            
        }

        private void contactanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaContactanos Forma = new FormaContactanos();
            Forma.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormaCambio cambio = new FormaCambio();
            cambio.Show();
        }

        private void menuCalculadora_Click(object sender, EventArgs e)
        {
           
        }

        private void áreaDelTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaArea area = new FormaArea();
            area.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormaLPM forma = new FormaLPM();
            forma.Show();
            
        }

        private void ecuacionCuadraticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormaSalario salario = new FormaSalario();
            salario.Show();
        }

        private void latidosPorMinutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormaEcuacion ecuacion = new FormaEcuacion();
            ecuacion.Show();
        }

        private void visorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaVisor formaVisor = new FormaVisor();
            formaVisor.Show();

        }
    }
}
