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
    public partial class NuevoAlumno : Form
    {
        public class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }
        public NuevoAlumno()
        {
            InitializeComponent();
        }

        AlumnoBLL ABLL = new AlumnoBLL();
        Alumno alumnoNuevo = new Alumno();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevoAlumno_Load(object sender, EventArgs e)
        {
            CarreraBLL CBLL = new CarreraBLL();
            List<Carrera> carreras = CBLL.ObtenerCarreraPorNombre();
            foreach(var carrera in carreras)
            {
                comboBox1.Items.Add(new Item(carrera.Nombre, Int32.Parse(carrera.Id.ToString())));
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            alumnoNuevo.Nombre = txtNombre.Text;
            alumnoNuevo.ApellidoPaterno = txtApePat.Text;
            alumnoNuevo.ApellidoMaterno = txtApeMat.Text;
            alumnoNuevo.Email = txtEmail.Text;
            Item item = null;
            item = (Item)comboBox1.SelectedItem;
            alumnoNuevo.CarreraId = item.Value;

            ABLL.CrearAlumno(alumnoNuevo);
            Close();
        }
    }
}
