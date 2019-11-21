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
    public partial class VistaNuevaCarrera : Form
    {
        public VistaNuevaCarrera()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        CarreraBLL CBLL = new CarreraBLL();

        private void button1_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            carrera.Nombre = textBox1.Text;
            CBLL.CrearCarrera(carrera);
            Close();
        }
    }
}
