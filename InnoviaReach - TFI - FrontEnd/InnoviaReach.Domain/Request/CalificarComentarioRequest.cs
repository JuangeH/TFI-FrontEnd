using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Request
{
    public class CalificarComentarioRequest
    {
        public int Comentario_ID { get; set; }
        public string User_ID { get; set; }
        public int Puntaje { get; set; }
    }
}
