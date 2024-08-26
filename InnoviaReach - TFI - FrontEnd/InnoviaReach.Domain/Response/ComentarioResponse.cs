using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Response
{
    public class ComentarioResponse
    {
        public ComentarioResponse()
        {
            Respuestas = new HashSet<ComentarioResponse>();
        }
        public int Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Contenido { get; set; }
        public string Creador { get; set; }
        public int? ComentarioPadre_Codigo { get; set; }
        public double PromedioPuntaje { get; set; }
        public int CantidadVotos { get; set; }

        public ICollection<ComentarioResponse> Respuestas;
    }
}
