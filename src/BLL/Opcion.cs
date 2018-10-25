using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Opcion
    {
        private int _id;
        private string _descripcion;
        private int _correcta;
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

        public int correcta
        {
            get { return _correcta; }
            set { _correcta = value; }
        }

        public void alta(int preguntaId) 
        {
            OpcionDAL objopciondal = new OpcionDAL();

            objopciondal.alta(preguntaId,this._descripcion,this._correcta);
        }

        public void altaCorrecta(int preguntaId)
        {
            OpcionDAL objopciondal = new OpcionDAL();
            int valor;

            valor = objopciondal.altaCorrecta(preguntaId, this._descripcion , this._correcta);

            //En valor obtengo el id luego de hacer el insert y se lo paso al objeto
            if (valor != -1)
            {
                this._id = valor;
            }
            //si es -1 es porque fallo el insert, quiza deberia retornar algo este alta
        }
    }
}
