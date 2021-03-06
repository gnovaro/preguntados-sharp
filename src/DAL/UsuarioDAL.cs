﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        

        public int alta(string nombre, string email, int idiomaId, DateTime fecha, string contrasena ) 
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "usuario_alta";
            int filavalor;
            string variable = "@id";
            SqlParameter[] parametros = new SqlParameter[6];

            parametros[0] = objconexion.crearParametro("@nombre", nombre);
            parametros[1] = objconexion.crearParametro("@email", email);
            parametros[2] = objconexion.crearParametro("@idioma_id", idiomaId);
            parametros[3] = objconexion.crearParametro("@fechanac", fecha);
            parametros[4] = objconexion.crearParametro("@contrasena", contrasena);
            parametros[5] = objconexion.crearParametroDeSalida("@id");

            filavalor = objconexion.EscribiryObtenerValorSP(procedimiento,parametros,variable);
            //Aca devuelvo el valor del id despues de hacer el insert y si fallo devuelve -1
            return filavalor;
        }

        public DataTable obtenerUsuario(string email, string contrasena) 
        {
            Conexion objConexion = new Conexion();
            string procedimiento = "ingreso";

            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = objConexion.crearParametro("@email", email);
            parametros[1] = objConexion.crearParametro("@contrasena", contrasena);

            DataTable datausuario = objConexion.LeerPorStoreProcedure(procedimiento,parametros); ;

            return datausuario;
        }

        public int guardarPuntos(int id, int puntos) 
        {
            Conexion objConexion = new Conexion();
            string procedimiento = "usuario_guardarPuntos";
            int filasafectadas;
            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = objConexion.crearParametro("@id", id);
            parametros[1] = objConexion.crearParametro("@puntos", puntos);

            filasafectadas = objConexion.EscribirPorStoreProcedure(procedimiento, parametros);

            return filasafectadas;
        }
    }
}
