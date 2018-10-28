using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
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
            IdiomaFrm frm = new IdiomaFrm(this._usuario);
            
            frm.MdiParent = this;
            //Se setea al primer formulario hijo en maximizado
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
 
    }
}
