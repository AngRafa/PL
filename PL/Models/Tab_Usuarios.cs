using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class Tab_Usuarios
    {
        public int IdUsuario { get; set; }
        public string UsuerName { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public short TipoUsuario { get; set; }
        public short Activo { get; set; }
        public List<object> Usuarios { get; set; }
    }
}