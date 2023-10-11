using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1.Formu
{
    public partial class FormaVideo : Form
    {
        public FormaVideo()
        {
            InitializeComponent();
        }

        private void FormaVideo_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\panqe\Downloads\videoplayback.mp4";
        }
    }
}
