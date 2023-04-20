using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class SistemaVenta : Form
    {



        private static Usuario usuarioActual;
        public SistemaVenta(Usuario objusuario)
        {
            usuarioActual= objusuario;

            InitializeComponent();
        }

        private void SistemaVenta_Load(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual.NombreCompleto;
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

        }
        private void menuUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
