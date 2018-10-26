using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Denuncia
    {
        private int _id;
        private string _descripcion;
        private DateTime _fecha;
        private Usuario _usuario;
        private Pregunta _pregunta;


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        
        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        
        public Usuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        
        public Pregunta pregunta
        {
            get { return _pregunta; }
            set { _pregunta = value; }
        }
        
    }
}
