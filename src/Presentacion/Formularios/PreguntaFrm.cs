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
    public partial class PreguntaFrm : Form
    {
        protected Usuario _usuario;
        public PreguntaFrm()
        {
            InitializeComponent();
        }
        public PreguntaFrm(Usuario user)
        {
            InitializeComponent();
            this._usuario = user;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearpregunta_Click(object sender, EventArgs e)
        {

        }
    }
}
