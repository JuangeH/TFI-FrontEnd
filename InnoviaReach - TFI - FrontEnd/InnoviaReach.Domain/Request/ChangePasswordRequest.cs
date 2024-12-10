using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoviaReach.Domain.Request
{
    public class ChangePasswordRequest
    {
        [Required(ErrorMessage = "Campo requerido")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string NewPassword { get; set; }
    }
}
