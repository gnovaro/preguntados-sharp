using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class TipoDeProductoDAL
    {
        public DataTable Listar()
        {
            Conexion objConexion = new Conexion();
            return objConexion.LeerPorComando("select * from ttipodeproducto");
        }
    }
}
