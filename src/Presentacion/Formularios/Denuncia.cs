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
    public partial class Denuncia : Form
    {

        protected Usuario _usuario;

        protected Pregunta _pregunta;

        public Denuncia(Usuario user, Pregunta unapregunta)
        {

            this._usuario = user;
            this._pregunta = unapregunta;


            InitializeComponent();
        }

        public Denuncia()
        {
            InitializeComponent();
        }

        private void Denuncia_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
            frmMenu.MdiParent = this.MdiParent;
            frmMenu.Show();
            this.Close();
        }
    }
}
