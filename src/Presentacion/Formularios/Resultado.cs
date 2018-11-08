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
            this.ControlBox = false;
            txtPregunta.Text = this._preguntaRandom.descripcion;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
            frmMenu.MdiParent = this.MdiParent;
            frmMenu.Show();
            this.Close();
        }

        private void btnAburrida_Click(object sender, EventArgs e)
        {
            this._preguntaRandom.votosNegativos = this._preguntaRandom.votosNegativos + 1;
            this._preguntaRandom.guardarVotoNegativo();
            btnAburrida.BackColor = Color.Red;
            btnAburrida.Enabled = false;
            btnDivertida.Enabled = false;

        }

        private void btnDivertida_Click(object sender, EventArgs e)
        {
            this._preguntaRandom.votosPositivos = this._preguntaRandom.votosPositivos + 1;
            this._preguntaRandom.guardarVotoPositivo();
            btnDivertida.BackColor = Color.Green;
            btnAburrida.Enabled = false;
            btnDivertida.Enabled = false;
        }

        private void btnDenunciar_Click(object sender, EventArgs e)
        {
            Denuncia frmDenuncia = new Denuncia(this._usuario, this._preguntaRandom);
            frmDenuncia.MdiParent = this.MdiParent;
            frmDenuncia.Show();
            this.Close();
        }
    }
}
