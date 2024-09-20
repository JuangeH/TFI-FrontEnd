using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Response
{
    public class PaginationResponse<T>
    {
        public int TotalRecords { get; set; }
        public List<T> Videojuegos { get; set; }
    }
}
