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
        public ForoRequest()
        {
            comentarios = new List<ComentarioRequest>();
        }

        public List<ComentarioRequest> comentarios { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string NombreVideoJuego { get; set; }
        public string NombreUsuarioCreador { get; set; }
        public DateTime FechaCreado { get; set; }
        public int Visitas { get; set; }
        public decimal Calificacion { get; set; }
    }
}
