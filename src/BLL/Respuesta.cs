using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Respuesta
    {
        private Usuario _usuario;
        private Pregunta _pregunta;
        private Opcion _opcion;
        private int _correcta;

        public Usuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        
        public Pregunta pregunta
        {
            get { return _pregunta; }
            set { _pregunta = value; }
        }

        
        public Opcion opcion
        {
            get { return _opcion; }
            set { _opcion = value; }
        }

        
        public int correcta
        {
            get { return _correcta; }
            set { _correcta = value; }
        }


        public void alta()
        {
            RespuestaDal objrespuestadal = new RespuestaDal();
            objrespuestadal.alta(this.usuario.id, this.pregunta.id, this.opcion.id, this.correcta);

        }
    }
}
