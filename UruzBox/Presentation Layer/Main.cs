using Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentation_Layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.DoubleClick += frmMain_DoubleClick;

            this.WindowState = FormWindowState.Maximized;
            WindowState = FormWindowState.Maximized;
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
            panelButtons.Visible = false;
            panelAgregarAlumno.Visible = false;
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            panelButtons.Width = this.Width;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoginEntrar_Click(object sender, EventArgs e)
        {
            string user = txtLoginPass.Text;
            string pass = txtLoginPass.Text;

            if(user == "admin" &&  pass == "admin")
            {
                panelButtons.Visible = true;
                panelLogin.Visible = false;
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            panelAgregarAlumno.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelAgregarAlumno.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoBusiness alumnoBusiness = new AlumnoBusiness();
            string nombre = txtAgregarNombre.Text;
            string apellido = txtAgregarApellido.Text;
            string celular = txtAgregarCelular.Text;
            string email = txtAgregarEmail.Text;
            Alumno alumno = new Alumno(nombre, apellido, celular, email);

            alumnoBusiness.AgregarNuevoAlumno(alumno);
        }
    }
}
