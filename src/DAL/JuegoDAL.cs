using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class JuegoDAL
    {
        public DataTable obtenerRanking()
        {
            Conexion objConexion = new Conexion();
            string consultaSQL = "SELECT TOP 10 nombre,puntos FROM usuario ORDER BY puntos DESC, nombre ASC";
            DataTable objDT = objConexion.LeerPorComando(consultaSQL);
            return objDT;
        }
    }
}
