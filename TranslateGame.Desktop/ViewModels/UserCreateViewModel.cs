using System;
using TranslateGame.Desktop.Models;

namespace TranslateGame.Desktop.ViewModel
{
    public class UserCreateViewModel
    {
        public string Name { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string DateOfBirth { get; set; }

        public static implicit operator User(UserCreateViewModel userCreateViewModel)
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                Name = userCreateViewModel.Name,
                Username = userCreateViewModel.Username,
                DateOfBirth = userCreateViewModel.DateOfBirth
            };
        }
    }
}
