using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Response
{
    public class RecomendacionUsuarioResponse
    {
        public string VideojuegoRecomendado { get; set; }
        public string VideojuegoRecomendadoImagen { get; set; }
        public string TipoRecomendacion { get; set; }
    }
}
