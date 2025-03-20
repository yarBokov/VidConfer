using System.ComponentModel.DataAnnotations;

namespace ConferApp.Shared.Authentication.Requests
{
    public class CreateUserRequest
    {
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Password { get; set; } = string.Empty;

        [Required, Compare(nameof(Password))]
        public string PasswordConfirmation {  get; set; } = string.Empty;
    }
}
