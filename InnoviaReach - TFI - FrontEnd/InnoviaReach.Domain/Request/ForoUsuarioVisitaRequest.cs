using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Request
{
    public class ForoUsuarioVisitaRequest
    {
        public string? User_ID { get; set; }
        public int Foro_ID { get; set; }
    }
}
