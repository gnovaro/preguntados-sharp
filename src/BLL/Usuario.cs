using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        private int _idiomaId;
        private int _id;
        private string _nombre;
        private string _email;
        private DateTime _fechanac;
        private int _puntos;
        private string _contrasena;
        
        public int idiomaId
        {
            get { return _idiomaId; }
            set { _idiomaId = value; }
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

    }
}
