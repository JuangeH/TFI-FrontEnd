using System.ComponentModel.DataAnnotations;

namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression(@"\A[\w|.|-]+@[\w|.|-]+\Z", ErrorMessage = "El formato no corresponde al de una dirección de correo")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "La contraseña debe contener al menos {2} caracteres", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Idioma { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Estilo_preferido { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Genero_preferido { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public bool Actualizaciones { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public bool Descuentos { get; set; }
    }
}
