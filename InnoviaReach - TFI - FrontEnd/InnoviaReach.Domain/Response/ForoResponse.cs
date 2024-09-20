using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Response
{
    public class ForoResponse
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string NombreVideoJuego { get; set; }
        public string NombreUsuarioCreador { get; set; }
        public DateTime FechaCreado { get; set; }
        public int Visitas { get; set; }
        public decimal Calificacion { get; set; }
        public int CantidadComentarios { get; set; }
        public bool favorito { get; set; }
    }
}
