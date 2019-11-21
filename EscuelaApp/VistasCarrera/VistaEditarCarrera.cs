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
    public partial class VistaEditarCarrera : Form
    {
        int id;
        public VistaEditarCarrera(int id, string nombre)
        {
            InitializeComponent();
            this.id = id;
            textBox1.Text = nombre;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CarreraBLL CBLL = new CarreraBLL();
            var carrera = CBLL.ObtenerCarrera(id);
            carrera.Nombre = textBox1.Text;
            CBLL.Actualizar(carrera);
            Close();
        }
    }
}
