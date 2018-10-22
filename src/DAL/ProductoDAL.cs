using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class ProductoDAL
    {
        public int Alta(string pDescripcion, int pCodigoDeTipoDeProducto)
        {
            Conexion objConexion = new Conexion();

            string consultaDeInsert = "insert into tProducto (Descripcion, Tipo) values ('" 
                + pDescripcion + "'," 
                + pCodigoDeTipoDeProducto.ToString() + ")";


            int filasAfectadas = objConexion.EscribirPorComando(consultaDeInsert);

            return filasAfectadas;
        }

        public int Editar(string pDescripcion, int pCodigoDeTipoDeProducto, int pIdentificador)
        {
            Conexion objConexion = new Conexion();

            string consultaDeInsert = "update tProducto set descripcion = '" +
                pDescripcion + "', tipo = " + pCodigoDeTipoDeProducto.ToString() +
                " where identificador = " + pIdentificador;


            int filasAfectadas = objConexion.EscribirPorComando(consultaDeInsert);

            return filasAfectadas;
        }
        
        public DataTable Listar()
        {
            Conexion objConexion = new Conexion();
            string consultaSQL = "Select * from tProducto";
            DataTable objDT = objConexion.LeerPorComando(consultaSQL);

            return objDT;
        }

    }
}
