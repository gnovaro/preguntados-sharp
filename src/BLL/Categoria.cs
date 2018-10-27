using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

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

        public List<Categoria> listarCategorias(int idiomaId) 
        {
            List<Categoria> lista = new List<Categoria>();
            CategoriaDAL objcategoriadal = new CategoriaDAL();
            Categoria unacategoria;
            Idioma unidioma = new Idioma();
            unidioma.id = idiomaId;

            foreach (DataRow fila in objcategoriadal.obtenerCategorias(idiomaId).Rows)
            {
                unacategoria = new Categoria();

                unacategoria._idioma = unidioma;
                unacategoria._id = Convert.ToInt32(fila["id"]);
                unacategoria._nombre = fila["nombre"].ToString();
                lista.Add(unacategoria);
            }

            return lista;
        }
    }
}
