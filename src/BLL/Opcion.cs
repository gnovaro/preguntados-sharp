using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Opcion
    {
        private int _id;
        private string _descripcion;
        private int _correcta;
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

        public int correcta
        {
            get { return _correcta; }
            set { _correcta = value; }
        }
        
        
    }
}
