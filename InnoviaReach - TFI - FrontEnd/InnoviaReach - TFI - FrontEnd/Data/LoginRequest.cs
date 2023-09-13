using System.ComponentModel.DataAnnotations;

namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Campo requerido")]
        [EmailAddress]
        public string username { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string password { get; set; }
    }
}
