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

namespace EscuelaApp.VistasCarrera
{
    public partial class IndexCarrera : Form
    {
        public IndexCarrera()
        {
            InitializeComponent();
        }
        CarreraBLL CBLL = new CarreraBLL();
        private void IndexCarrera_Load(object sender, EventArgs e)
        {
            ObtenerCarreras();
        }

        private void ObtenerCarreras()
        {
            dataGridView1.Rows.Clear();
            List<Carrera> carreras = new List<Carrera>();
            carreras = CBLL.ObtenerCarreraPorNombre();
            foreach(var carrera in carreras)
            {
                dataGridView1.Rows.Add(carrera.Id,carrera.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaNuevaCarrera objForm = new VistaNuevaCarrera();
            objForm.ShowDialog();
        }

        private void IndexCarrera_Activated(object sender, EventArgs e)
        {
            ObtenerCarreras();
        }

        private void BtnEditarCarrera_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                VistaEditarCarrera frmEditar = new VistaEditarCarrera(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), dataGridView1.SelectedRows[0].Cells[1].Value.ToString()); // SE CREA INSTANCIA DE FORM EDITAR CON PARÁMETROS
                frmEditar.ShowDialog();
            }
            else
            {
                Error frmError = new Error("NO HAY FILAS SELECCIONADAS");
                frmError.ShowDialog();
            }
        }

        private void BtnEliminarCarrera_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                VistaEliminarCarrera frmEliminar = new VistaEliminarCarrera(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), dataGridView1.SelectedRows[0].Cells[1].Value.ToString()); // SE CREA INSTANCIA DE FORM EDITAR CON PARÁMETROS
                frmEliminar.ShowDialog();
            }
            else
            {
                Error frmError = new Error("NO HAY FILAS SELECCIONADAS");
                frmError.ShowDialog();
            }
        }
    }
}
