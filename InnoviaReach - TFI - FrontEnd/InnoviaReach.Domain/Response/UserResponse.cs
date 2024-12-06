using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Response
{
    public class UserResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
