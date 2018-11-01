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
    public partial class JuegoFrm : Form
    {
        protected Usuario _usuario;
        protected Pregunta preguntaRandom;
        protected List<Categoria> _categorias;

        public JuegoFrm()
        {
            InitializeComponent();
        }

        public JuegoFrm(Usuario user)
        {            
            InitializeComponent();
            this._usuario = user;
            Categoria categoria = new Categoria();
            this._categorias = categoria.listarCategorias(this._usuario.idioma.id);
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int categoriaIndice = rnd.Next(0,4); //Hacemos un random de categoria
            string categoriaNombre = this._categorias.ElementAt(categoriaIndice).nombre;

            lblCategoria.Text = categoriaNombre;
            this.preguntaRandom = new BLL.Pregunta();
            this.preguntaRandom = this.preguntaRandom.obtenerPreguntaRandom(this._usuario.idioma.id, this._categorias.ElementAt(categoriaIndice).id);
            txtPregunta.Text = this.preguntaRandom.descripcion;
            //desordeno la lista de opciones
            this.preguntaRandom.desordenarOpciones();
            //Cargamos las opciones
            radOpcion1.Text = this.preguntaRandom.opciones.ElementAt(0).descripcion;
            radOpcion2.Text = this.preguntaRandom.opciones.ElementAt(1).descripcion;
            radOpcion3.Text = this.preguntaRandom.opciones.ElementAt(2).descripcion;
            radOpcion4.Text = this.preguntaRandom.opciones.ElementAt(3).descripcion;
        }

        private void btnResponderPregunta_Click(object sender, EventArgs e)
        {
            Boolean respuesta = false;

            if (radOpcion1.Checked && this.preguntaRandom.opciones.ElementAt(0).correcta == 1)
            {
                respuesta = true;
            }

            if (radOpcion2.Checked && this.preguntaRandom.opciones.ElementAt(1).correcta == 1)
            {
                respuesta = true;
            }

            if (radOpcion3.Checked && this.preguntaRandom.opciones.ElementAt(2).correcta == 1)
            {
                respuesta = true;
            }

            if (radOpcion4.Checked && this.preguntaRandom.opciones.ElementAt(3).correcta == 1)
            {
                respuesta = true;
            }

            if (respuesta) {
                MessageBox.Show("Es correcta");
            } else
            {
                MessageBox.Show("Su respuesta es incorrecta");
            }
            
            //@TODO guardar la respuesta
        }
    }
}
