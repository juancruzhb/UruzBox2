using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.DoubleClick += frmMain_DoubleClick;

            this.WindowState = FormWindowState.Maximized;
        }


        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Alumnos_Main alumnos_Main = new Alumnos_Main();

            this.Enabled = false;

            if(alumnos_Main.ShowDialog() == DialogResult.OK) { }

            this.Enabled = true;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
