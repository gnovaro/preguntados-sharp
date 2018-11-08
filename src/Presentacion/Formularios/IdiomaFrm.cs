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
    public partial class IdiomaFrm : Form
    {
        protected Usuario _usuario;
        public IdiomaFrm()
        {
            InitializeComponent();
        }

        public IdiomaFrm(Usuario user)
        {
            InitializeComponent();
            this._usuario = user;
        }
        private void btnAceptarIdioma_Click(object sender, EventArgs e)
        {
            Idioma lang = new Idioma();
            if (radEspanol.Checked)
            {
                lang.id = 1;
            }

            if (radEnglish.Checked)
            {
                lang.id = 2;

            }

            //Si no selecciona
            if(radEspanol.Checked == false && radEnglish.Checked == false)
            {
                MessageBox.Show("Por favor seleccione un idioma / Please choose a language");
            } else {
                this._usuario.idioma = lang;
                /*
                MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
                frmMenu.MdiParent = this.MdiParent;
                frmMenu.Show();
                this.Hide(); */

                //Esta parte para lanzar el login
                 
                Login frmLogin = new Login(this._usuario);
                frmLogin.MdiParent = this.MdiParent;
                frmLogin.Show();
                this.Close(); 
            }

        }

        private void IdiomaFrm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
