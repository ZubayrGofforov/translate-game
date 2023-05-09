using System;
using System.Threading.Tasks;
using TranslateGame.Desktop.Interfaces;
using TranslateGame.Desktop.Interfaces.Services;
using TranslateGame.Desktop.Models;
using TranslateGame.Desktop.Repositories;
using TranslateGame.Desktop.ViewModel;

namespace TranslateGame.Desktop.Services
{
    public class UserServices : IUserService
    {
        private IUserRepository _userRepository;

        public UserServices()
        {
            this._userRepository = new UserRepository();
        }

        // login
        public async Task<User> LoginAsync(string username, string password)
        {
            var user = await Task.Run(() => _userRepository.GetByUsername(username));
            if (user == null) return null;
            else
            {
                var hasherResult = BCrypt.Net.BCrypt.Verify(password + user.Salt, user.PasswordHash);
                if (hasherResult) return user;
                else return null;
            }
        }

        // register
        public async Task<bool> RegisterAsync(UserCreateViewModel userCreateViewModel)
        {
            try
            {
                var user = (User)userCreateViewModel;
                string salt = Guid.NewGuid().ToString();
                string hash = BCrypt.Net.BCrypt.HashPassword(userCreateViewModel.Password + salt);
                user.PasswordHash = hash;
                user.Salt = salt;
                await Task.Run(() => _userRepository.Create(user));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
