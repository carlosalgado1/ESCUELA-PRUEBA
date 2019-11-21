﻿using System;
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
    public partial class Error : Form
    {
        public Error(string error)
        {
            InitializeComponent();
            label1.Text = error;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
