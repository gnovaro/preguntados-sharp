using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Usuario
    {
        private Idioma _idioma;
        private int _id;
        private string _nombre;
        private string _email;
        private DateTime _fechanac;
        private int _puntos;
        private string _contrasena;
        private List<Pregunta> _preguntas = new List<Pregunta>();
        public Idioma idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }
            
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DateTime fechanac
        {
            get { return _fechanac; }
            set { _fechanac = value; }
        }

        public int puntos
        {
            get { return _puntos; }
            set { _puntos = value; }
        }

        public string contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        public List<Pregunta> preguntas
        {
            get { return _preguntas; }
            set { _preguntas = value; }
        }

        public bool alta() 
        {
            bool resultado = false;
            int valor;
            UsuarioDAL objusuarioDal = new UsuarioDAL();

            
            valor = objusuarioDal.alta(this._nombre, this._email, this._idioma.id, this._fechanac, this._contrasena);

            //En valor obtengo el id luego de hacer el insert y se lo paso al objeto
            if (valor != -1)
            {
                this._id = valor;
                resultado = true;
            }
            
            return resultado;
        }

        public bool obtenerUsuario() 
        {
            bool valor = false;
            UsuarioDAL objusuariodal = new UsuarioDAL();
            DataTable datausuario = objusuariodal.obtenerUsuario(this._email);

            if (datausuario.Rows.Count > 0) 
            {
                valor = true;
                DataRow rowusuario = datausuario.Rows[0];
                this._id = Convert.ToInt32(rowusuario["id"]);
                this._nombre = rowusuario["nombre"].ToString();
                this._fechanac = Convert.ToDateTime(rowusuario["fecha_nac"]);
                Idioma userIdioma = new Idioma();
                userIdioma.id = Convert.ToInt32(rowusuario["idioma_id"]);
                this._idioma = userIdioma;
                this._puntos = Convert.ToInt32(rowusuario["puntos"]);
                this._contrasena = rowusuario["contrasena"].ToString();

            }
            //devuelve false si el email que ingreso no trajo ningun usuario
            return valor;

        }
    }
}
