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
    public partial class DenunciaFrm : Form
    {

        protected Usuario _usuario;

        protected Pregunta _pregunta;

        public DenunciaFrm(Usuario user, Pregunta unapregunta)
        {

            this._usuario = user;
            this._pregunta = unapregunta;


            InitializeComponent();
        }

        public DenunciaFrm()
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtdenuncia.Text != "")
            {
                Denuncia unaDenuncia = new Denuncia();
                unaDenuncia.descripcion = txtdenuncia.Text;
                unaDenuncia.usuario = this._usuario;
                unaDenuncia.pregunta = this._pregunta;
                unaDenuncia.fecha = DateTime.Today;

                unaDenuncia.alta();
                MessageBox.Show("Se ha guardado su denuncia");
               
                MenuPrincipal frmMenu = new MenuPrincipal(this._usuario);
                frmMenu.MdiParent = this.MdiParent;
                frmMenu.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Debe ingresar su denuncia");
            }
        }
    }
}
