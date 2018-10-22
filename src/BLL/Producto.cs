using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public TipoDeProducto Tipo { get; set; }

        public void Alta() 
        {
            ProductoDAL objDAL = new ProductoDAL();

            objDAL.Alta(this.Descripcion, this.Tipo.Codigo);

            
        }

        public void Editar()
        {
            ProductoDAL objProductoDAL = new ProductoDAL();

            objProductoDAL.Editar(this.Descripcion, this.Tipo.Codigo, this.Codigo);
            
        }


        public List<Producto> Listar()
        {
            return null;
        }

        public DataTable ListarTabla() 
        {
            ProductoDAL objDAL = new ProductoDAL();
            return objDAL.Listar();
        }
        
    }
}
