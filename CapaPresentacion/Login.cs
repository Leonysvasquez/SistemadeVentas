﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

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

            List<Usuario> TEST = new CN_Usuario().Listar();


            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtNoDocumento.Text 
            &&  u.Clave == txtClave.Text).FirstOrDefault();

            

            if (ousuario != null)
            {
                SistemaVenta form = new SistemaVenta(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("no se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtClave.Text = "";
            txtNoDocumento.Text = "";

            this.Show();
        }

    }
}
