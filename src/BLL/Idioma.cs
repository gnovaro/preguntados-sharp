using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Idioma
    {
        private int _id;
        private string _descripcion;
        private string _iso;

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

        public string iso
        {
            get { return _iso; }
            set { _iso = value; }
        }

        public List<Idioma> obtenerIdiomas()
        {
            List<Idioma> idiomasList = new List<Idioma>();
            IdiomaDAL idiomaDalInstancia = new IdiomaDAL();
            DataTable dataIdioma = new DataTable();

            dataIdioma = idiomaDalInstancia.obtenerIdiomas();
            foreach(DataRow fila in dataIdioma.Rows)
            {
                Idioma unIdioma = new Idioma();
                unIdioma.id = int.Parse(fila["id"].ToString());
                unIdioma.descripcion = fila["descripcion"].ToString();
                unIdioma.iso = fila["iso"].ToString();
                idiomasList.Add(unIdioma);
            }

            return idiomasList;
         
        }
    }
}
