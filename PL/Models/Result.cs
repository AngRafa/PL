using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class Result
    {
        public bool Correct { get; set; }

        public string Message { get; set; }//Enviara un Mensaje

        public Exception Ex { get; set; } //Captura las Excepciones

        public object Object { get; set; }

        public List<object> Objects { get; set; }//Lista de Objetos
    }
}