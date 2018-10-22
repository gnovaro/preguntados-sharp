using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class TipoDeProducto
    {

        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public DataTable ListarTabla() 
        {
            TipoDeProductoDAL dal = new TipoDeProductoDAL();

            return dal.Listar();
        }

        public List<TipoDeProducto> Listar()
        {
            List<TipoDeProducto> lista = new List<TipoDeProducto>();

            TipoDeProductoDAL dal = new TipoDeProductoDAL();

            TipoDeProducto unTipo; // = new TipoDeProducto();

            foreach (DataRow fila in dal.Listar().Rows)
            {
                unTipo = new TipoDeProducto();

                unTipo.Codigo = int.Parse(fila["ID"].ToString());
                unTipo.Descripcion = fila["NOMBRE"].ToString();

                lista.Add(unTipo);
            }


            return lista;
        }
    }
}
