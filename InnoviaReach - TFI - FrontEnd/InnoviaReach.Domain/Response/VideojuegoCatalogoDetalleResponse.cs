using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Response
{
    public class VideojuegoCatalogoDetalleResponse
    {
        public VideojuegoCatalogoDetalleResponse()
        {
            Tags = new HashSet<string>();
            Generos = new HashSet<string>();
            Plataformas = new HashSet<string>();
            Tiendas = new HashSet<string>();
        }

        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaSalida { get; set; }
        public ICollection<string> Tags { get; set; }
        public ICollection<string> Generos { get; set; }
        public ICollection<string> Plataformas { get; set; }
        public ICollection<string> Tiendas { get; set; }
    }
}
