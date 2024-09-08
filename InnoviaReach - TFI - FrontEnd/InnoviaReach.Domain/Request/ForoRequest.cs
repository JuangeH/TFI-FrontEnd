using InnoviaReach.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Request
{
    public class ForoRequest
    {
        public string Descripcion { get; set; }
        public int Videojuego_Codigo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreado { get; set; }
        public string Titulo { get; set; }
        public string User_ID { get; set; }
    }
}
