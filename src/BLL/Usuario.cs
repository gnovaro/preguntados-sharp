﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Usuario
    {
        private Idioma _idioma;
        private int _id;
        private string _nombre;
        private string _email;
        private DateTime _fechanac;
        private int _puntos;
        private string _contrasena;
        private List<Pregunta> _preguntas = new List<Pregunta>();
        public Idioma idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }
            
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DateTime fechanac
        {
            get { return _fechanac; }
            set { _fechanac = value; }
        }

        public int puntos
        {
            get { return _puntos; }
            set { _puntos = value; }
        }

        public string contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        public List<Pregunta> preguntas
        {
            get { return _preguntas; }
            set { _preguntas = value; }
        }

        public String alta() 
        {
            String mensaje = "";
            int valor;
            UsuarioDAL objusuarioDal = new UsuarioDAL();

            if (this._nombre != "" && this.email != "" && this.contrasena != "" && this._idioma.id != 0)
            {
                valor = objusuarioDal.alta(this._nombre, this._email, this._idioma.id, this._fechanac, this._contrasena);

                //En valor obtengo el id luego de hacer el insert y se lo paso al objeto
                if (valor != -1)
                {
                    this._id = valor;
                    mensaje = "Se creo el usuario correctamente.";
                }
            }
            else
            {
                mensaje = "Los campos nombre, email, contraseña e idioma son obligatorios";
            }

            //si es -1 es porque fallo el insert, quiza deberia retornar algo este alta
            return mensaje;
        }
    }
}
