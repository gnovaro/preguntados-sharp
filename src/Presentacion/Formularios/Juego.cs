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
    public partial class Juego : Form
    {
        protected Usuario _usuario;

        public Juego()
        {
            InitializeComponent();
        }

        public Juego(Usuario user)
        {            
            InitializeComponent();
            this._usuario = user;
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            Pregunta preguntaRandom = new BLL.Pregunta();
            preguntaRandom = preguntaRandom.obtenerPreguntaRandom(this._usuario.idiomaId);
            txtPregunta.Text = preguntaRandom.descripcion;
        }
    }
}
