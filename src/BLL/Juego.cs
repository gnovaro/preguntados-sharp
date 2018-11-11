using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Juego
    {
        protected List<Pregunta> _preguntas;
        protected Usuario _usuario;

        public DataTable obtenerRanking()
        {

            JuegoDAL juegoDAL = new DAL.JuegoDAL();
            return juegoDAL.obtenerRanking();
        }
    }
}
