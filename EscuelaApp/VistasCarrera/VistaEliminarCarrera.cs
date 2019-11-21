using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaApp.VistasCarrera
{
    public partial class VistaEliminarCarrera : Form
    {
        int id;
        public VistaEliminarCarrera(int id, string nombre)
        {
            InitializeComponent();
            this.id = id;
            label2.Text = nombre;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CarreraBLL CBLL = new CarreraBLL();
            var carrera = CBLL.ObtenerCarrera(id);
            CBLL.Eliminar(carrera);
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
