using EscuelaApp.VistasAlumno;
using EscuelaApp.VistasCarrera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaApp
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndexCarrera FormNuevo = new IndexCarrera();
            FormNuevo.ShowDialog();
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            IndexAlumno AlumnoForm = new IndexAlumno();
            AlumnoForm.ShowDialog();
        }
    }
}
