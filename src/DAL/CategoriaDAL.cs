using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CategoriaDAL
    {
        public DataTable obtenerCategorias(int idiomaId) 
        {
            Conexion objConexion = new Conexion();
            string consultaSql = "SELECT * FROM categoria WHERE idioma_id=" + idiomaId + " AND estado = 1";
            DataTable cate = objConexion.LeerPorComando(consultaSql);

            return cate;
        }
    }
}
