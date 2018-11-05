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
    public partial class Login : Form
    {
        protected Usuario _usuario;
        public Login()
        {
            InitializeComponent();
        }

        public Login(Usuario user)
        {
            InitializeComponent();
            this._usuario = user;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //hacer la validacion de usuario

            MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
            frmMenu.MdiParent = this.MdiParent;
            frmMenu.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro frmRegistro = new Registro(this._usuario);
            frmRegistro.MdiParent = this.MdiParent;
            frmRegistro.Show();
            this.Hide();
        }
    }
}
