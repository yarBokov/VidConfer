using System.ComponentModel.DataAnnotations;

namespace ConferApp.Shared.Authentication.Requests
{
    public class LoginUserRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Password { get; set; } = string.Empty;
    }
}
