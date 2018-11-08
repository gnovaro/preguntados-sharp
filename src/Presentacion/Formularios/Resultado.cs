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
    public partial class Resultado : Form
    {
        protected Usuario _usuario;
        protected Pregunta _preguntaRandom;
        public Resultado()
        {
            InitializeComponent();
        }

        public Resultado(Usuario user, Pregunta pregunta)
        {
            InitializeComponent();
            this._usuario = user;
            this._preguntaRandom = pregunta;
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            txtPregunta.Text = this._preguntaRandom.descripcion;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
            frmMenu.MdiParent = this.MdiParent;
            frmMenu.Show();
            this.Close();
        }
    }
}
