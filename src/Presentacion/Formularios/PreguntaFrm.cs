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
            Categoria objcategoria = new Categoria();
            cmbCategoria.DataSource = objcategoria.listarCategorias(user.idioma.id);
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "id";

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearpregunta_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbCategoria.SelectedValue.ToString());
            Pregunta unapregunta = new Pregunta();
            Idioma unidioma = new Idioma();
            Categoria unacategoria = new Categoria();

            unidioma.id = _usuario.idioma.id;
            unacategoria.id = Convert.ToInt32(cmbCategoria.SelectedValue);
            //Aca le seteo id del admin para probar 
            _usuario.id = 1;

            unapregunta.idioma = unidioma;
            unapregunta.categoria = unacategoria;
            unapregunta.creador = _usuario;
            unapregunta.descripcion = txtPregunta.Text;
            unapregunta.alta();

            Opcion op1 = new Opcion();
            Opcion op2 = new Opcion();
            Opcion op3 = new Opcion();
            Opcion op4 = new Opcion();

            op1.descripcion = txtRespuesta1.Text;
            op2.descripcion = txtRespuesta2.Text;
            op3.descripcion = txtRespuesta3.Text;
            op4.descripcion = txtRespuesta4.Text;

            //Alta opcion 1
            if (rdbRespuesta1.Checked)
            {
                op1.correcta = 1;
                op1.alta(unapregunta.id);
                unapregunta.altaOpcionCorrectaId(op1.id);
            }
            else 
            { 
               op1.correcta = 0;
               op1.alta(unapregunta.id);
            }

            //Alta opcion 2
            if (rdbRespuesta2.Checked)
            {
                op2.correcta = 1;
                op2.alta(unapregunta.id);
                unapregunta.altaOpcionCorrectaId(op2.id);
            }
            else 
            { 
                op2.correcta = 0;
                op2.alta(unapregunta.id);
            }

            //Alta opcion 3
            if (rdbRespuesta3.Checked)
            {
                op3.correcta = 1;
                op3.alta(unapregunta.id);
                unapregunta.altaOpcionCorrectaId(op3.id);
            }
            else 
            {
                op3.correcta = 0;
                op3.alta(unapregunta.id);
            }

            //alta opcion 4
            if (rdbRespuesta4.Checked)
            {
                op4.correcta = 1;
                op4.alta(unapregunta.id);
                unapregunta.altaOpcionCorrectaId(op4.id);
            }
            else 
            {
                op4.correcta = 0;
                op4.alta(unapregunta.id);
            }

            MessageBox.Show("Los datos se han guardado correctamente");
        }
    }
}
