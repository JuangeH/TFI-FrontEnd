using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Request
{
    public class ComentarioRequest
    {
        public DateTime FechaCreacion { get; set; }
        public string Contenido { get; set; }
        public int? ComentarioPadre_Codigo { get; set; }
        public int Foro_Codigo { get; set; }
        public string User_ID { get; set; }
    }
}

