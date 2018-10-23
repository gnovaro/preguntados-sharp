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
        private int _idioma_id;
        private int _categoria_id;
        private string _descripcion;


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int idioma_id
        {
            get { return _idioma_id; }
            set { _idioma_id = value; }
        }

        public int categoria_id
        {
            get { return _categoria_id; }
            set { _categoria_id = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Pregunta obtenerPreguntaRandom(int idiomaId)
        {
            //Pregunta preguntaObj = new Pregunta();
            PreguntaDAL pregDal = new DAL.PreguntaDAL();
            DataRow row = pregDal.obtenerPreguntaRandom(idiomaId);
            this.id = Convert.ToInt32(row["id"].ToString());
            this.descripcion = row["descripcion"].ToString();
            return this;
        }
    }
}
