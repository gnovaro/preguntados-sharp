using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Categoria
    {
        private int _id;
        private Idioma _idioma;
        private string _nombre;
        private int _estado;
        
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

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
