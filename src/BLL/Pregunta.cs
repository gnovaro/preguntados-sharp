using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Pregunta
    {
        private int _id;
        private Idioma _idioma;
        private Categoria _categoria;
        private string _descripcion;
        private int _votosPositivos;
        private int _votosNegativos;
        private Usuario _creador;
        private int _denunciada;
        private int _estado;
        private List<Opcion> _opciones = new List<Opcion>();

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Idioma idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }

        public Categoria categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
 
        public int votosPositivos
        {
            get { return _votosPositivos; }
            set { _votosPositivos = value; }
        }

        public int votosNegativos
        {
            get { return _votosNegativos; }
            set { _votosNegativos = value; }
        }

        public Usuario creador
        {
            get { return _creador; }
            set { _creador = value; }
        }

        public int denunciada
        {
            get { return _denunciada; }
            set { _denunciada = value; }
        }

        public int estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public List<Opcion> opciones
        {
            get { return _opciones; }
            set { _opciones = value; }
        }

        /**
         * Obtener una pregunta en forma aleatorias segun el idioma
         * @param int idiomaId
         * @return Pregunta
         */
        public Pregunta obtenerPreguntaRandom(int idiomaId,int categoriaId)
        {
            //Pregunta preguntaObj = new Pregunta();
            PreguntaDAL pregDal = new DAL.PreguntaDAL();
            //OpcionDAL opcDal = new DAL.OpcionDAL();
            DataRow row = pregDal.obtenerPreguntaRandom(idiomaId,categoriaId);
            this.id = Convert.ToInt32(row["id"].ToString());
            this.descripcion = row["descripcion"].ToString();

            //Obtengo las opciones de la pregunta

            Opcion preguntaOpcion = new Opcion();
            this.opciones = new List<Opcion>();
            this.opciones = preguntaOpcion.listarOpciones(this.id);

            return this;
        }

        public List<Pregunta> listarPreguntas(int idiomaId)
        {
            List<Pregunta> lista = new List<Pregunta>();
            PreguntaDAL objpreguntadal = new PreguntaDAL();
            Pregunta unapregunta;
            Idioma unidioma;
            Categoria unacategoria;
            Usuario unusuario;
            Opcion opciones;

            foreach (DataRow fila in objpreguntadal.obtenerPreguntas(idiomaId).Rows)
            {
                unapregunta = new Pregunta();
                unidioma = new Idioma();
                unacategoria = new Categoria();
                unusuario = new Usuario();
                opciones = new Opcion();

                unapregunta._id = Convert.ToInt32(fila["id"]);
                unidioma.id = idiomaId;
                unapregunta._idioma = unidioma;
                unacategoria.id = Convert.ToInt32(fila["categoria_id"]);
                unapregunta._categoria = unacategoria;
                unapregunta._descripcion = fila["descripcion"].ToString();

                //Aca obtengo una lista con las opciones de esta pregunta
                unapregunta._opciones = opciones.listarOpciones(unapregunta._id);

                unapregunta._votosPositivos = Convert.ToInt32(fila["votos_positivos"]);
                unapregunta._votosNegativos = Convert.ToInt32(fila["votos_negativos"]);
                unusuario.id = Convert.ToInt32(fila["usuario_id"]);
                unapregunta._creador = unusuario;

                lista.Add(unapregunta);
            }

            return lista;
        }

        public void alta() 
        {
            int valor;
            PreguntaDAL objpreguntadal = new PreguntaDAL();

            valor = objpreguntadal.alta(this._idioma.id, this._categoria.id, this._descripcion, this._creador.id);

            if (valor != -1)
            {
                this._id = valor;
            }
        }

        public void altaOpcionCorrectaId(int opcionId) 
        {
            PreguntaDAL objpreguntadal = new PreguntaDAL();
            objpreguntadal.altaOpcionCorrectaId(this._id, opcionId);
        }

        public void desordenarOpciones()
        {
            List<Opcion> listaNueva = new List<Opcion>();
            Random randnum = new Random();

            while(this.opciones.Count > 0)
            {
                int val = randnum.Next(0,this.opciones.Count);
                listaNueva.Add(this.opciones[val]);
                this.opciones.RemoveAt(val);
            }

            this.opciones = listaNueva;
        }

        public void guardarVotoPositivo() 
        {
            PreguntaDAL objpreguntadal = new PreguntaDAL();
            objpreguntadal.guardarVotoPositivo(this._id, this._votosPositivos);
        }

        public void guardarVotoNegativo() 
        {
            PreguntaDAL objpreguntadal = new PreguntaDAL();
            objpreguntadal.guardarVotoNegativo(this._id, this._votosNegativos);
        }
    }
}
