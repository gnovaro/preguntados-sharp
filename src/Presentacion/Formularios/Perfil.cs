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
    public partial class Perfil : Form
    {
        protected Usuario _usuario;


        public Perfil(Usuario user)
        {

            this._usuario = user;

            InitializeComponent();
        }

        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txtPoints.Text = this._usuario.puntos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
            frmMenu.MdiParent = this.MdiParent;
            frmMenu.Show();
            this.Close();
        }
    }
}
