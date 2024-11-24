using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Response
{
    public class UserConfigResponse
    {
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Idioma { get; set; }
        public string Contraseña { get; set; }
        public bool Estado { get; set; }
    }
}
