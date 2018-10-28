using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    //Singleton de la clase Juego
    public class Juego
    {
        private static Juego _instance;
        private int _idiomaId;

        public int idiomaId
        {
            get { return _idiomaId; }
            set { _idiomaId = value; }
        }

        //Constructor proteted
        protected Juego()
        {

        }

        public static Juego instancia()
        {
            if (_instance == null)
            {
                _instance = new Juego();
            }
            return _instance;
        }

        
    }
}
