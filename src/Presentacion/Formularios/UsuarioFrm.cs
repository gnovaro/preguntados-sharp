using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Presentacion.Formularios
{
    public partial class UsuarioFrm : Form
    {
        public UsuarioFrm()
        {
            InitializeComponent();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            Usuario unUsuario = new Usuario();

            unUsuario.nombre = txtNombre.Text;
            unUsuario.email = txtEmail.Text;
            unUsuario.contrasena = txtContrasena.Text;
            //traer idioma
            unUsuario.alta();

        }

        private void UsuarioFrm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
