using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Request
{
    public class UsuarioBaneadoRequest
    {
        public string UserName { get; set; }
        public string UserAdmin_ID { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaDeBaneo { get; set; }
    }
}
