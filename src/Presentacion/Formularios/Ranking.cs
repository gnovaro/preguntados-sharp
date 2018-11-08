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
    public partial class Ranking : Form
    {

        protected Usuario _usuario;



        public Ranking(Usuario user)
        {

            this._usuario = user;

            InitializeComponent();

        }

        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
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
