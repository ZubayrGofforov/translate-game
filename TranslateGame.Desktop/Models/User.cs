using System;

namespace TranslateGame.Desktop.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Salt { get; set; } = string.Empty;

        public string DateOfBirth { get; set; }
    }
}
