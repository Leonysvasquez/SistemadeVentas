﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SistemaVenta form = new SistemaVenta();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtContrasena.Text = "";
            txtNoDocumento.Text = "";

            this.Show();
        }

    }
}
