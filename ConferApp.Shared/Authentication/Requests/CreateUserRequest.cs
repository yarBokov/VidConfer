﻿namespace ConferApp.Shared.Authentication.Requests
{
    public class CreateUserRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PasswordConfirmation {  get; set; } = string.Empty;
    }
}
