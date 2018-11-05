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
    public partial class Registro : Form
    {
        protected Usuario _usuario;
        public Registro()
        {
            InitializeComponent();
        }

        public Registro(Usuario user)
        {
            InitializeComponent();
            this._usuario = user;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                
                this._usuario.nombre = txtNombre.Text;
                this._usuario.email = txtEmail.Text;
                this._usuario.contrasena = txtContrasena.Text;
                this._usuario.fechanac = Convert.ToDateTime(dtpFechanac.Text);
                
                if (txtNombre.Text != "" && txtEmail.Text != "" && txtContrasena.Text != "")
                {
                    bool valor = this._usuario.alta();
                    
                    if (valor)
                    {
                        MessageBox.Show("Se creo el usuario correctamente");
                        MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
                        frmMenu.MdiParent = this.MdiParent;
                        frmMenu.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Oops! Hubo un error, intente nuevamente");
                    }
                }
                else 
                {
                    MessageBox.Show("Debe completar todos los campos");
                }

                
            
        }
    }
}
