using System;
using System.Collections.Generic;
using System.Text;

namespace InnoviaReach.Domain.Response
{
    public class LoginTokenResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string RoleName { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Suscripcion { get; set; }
    }
}
