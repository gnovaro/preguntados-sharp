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
using Presentacion.Formularios;

namespace Presentacion
{
    public partial class Principal : Form
    {
        protected Usuario _usuario;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Al cargar el juego creo un usuario Anonimo / Invitado
            this._usuario = new Usuario();
        }

        private void btnAceptarIdioma_Click(object sender, EventArgs e)
        {
            if (radEspanol.Checked)
            {
                this._usuario.idiomaId = 1;
            }

            if (radEnglish.Checked)
            {
                this._usuario.idiomaId = 2;
            }

            MessageBox.Show(this._usuario.idiomaId.ToString());
            MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
            frmMenu.Show();
        }
    }
}
