using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaApp.VistasAlumno
{
    public partial class IndexAlumno : Form
    {
        AlumnoBLL ABLL = new AlumnoBLL();
        public IndexAlumno()
        {
            InitializeComponent();
        }

        private void IndexAlumno_Load(object sender, EventArgs e)
        {

        }

        public void ObtenerAlumno()
        {
            dataGridView1.Rows.Clear();
            List<Alumno> alumnos = new List<Alumno>();
            alumnos = ABLL.ObtenerAlumnoPorNombre();
            foreach(var alumno in alumnos)
            {
                dataGridView1.Rows.Add(alumno.Id, alumno.Nombre, alumno.ApellidoPaterno, alumno.ApellidoMaterno, alumno.Email, alumno.CarreraId);
            }
        }

        private void IndexAlumno_Activated(object sender, EventArgs e)
        {
            ObtenerAlumno();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoAlumno nuevoForm = new NuevoAlumno();
            nuevoForm.ShowDialog();
        }
    }
}
