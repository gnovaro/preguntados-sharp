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
    public partial class MenuPrincipal : Form
    {
        protected Usuario _usuario;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(Usuario user)
        {
            InitializeComponent();
            this._usuario = user;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            //Ingles
            if (this._usuario.idioma.id == 2)
            {
                btnJugar.Text = "Play";
            }                                
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            JuegoFrm frmJuego = new JuegoFrm(this._usuario);
            frmJuego.MdiParent = this.MdiParent;
            frmJuego.Show();
            this.Hide();

        }

        private void btnPreguntaAgregar_Click(object sender, EventArgs e)
        {
            PreguntaFrm frmAgregarpregunta = new PreguntaFrm(this._usuario);
            frmAgregarpregunta.MdiParent = this.MdiParent;
            frmAgregarpregunta.Show();
            this.Close();

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil frmPerfil = new Perfil(this._usuario);
            frmPerfil.MdiParent = this.MdiParent;
            frmPerfil.Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            IdiomaFrm frmIdioma = new IdiomaFrm(this._usuario);
            frmIdioma.MdiParent = this.MdiParent;
            frmIdioma.Show();
            this.Close();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            Ranking frmRanking = new Ranking(this._usuario);
            frmRanking.MdiParent = this.MdiParent;
            frmRanking.Show();
            this.Close();
        }
    }
}
