using System.Threading.Tasks;
using TranslateGame.Desktop.Models;
using TranslateGame.Desktop.ViewModel;

namespace TranslateGame.Desktop.Interfaces.Services
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(UserCreateViewModel userCreateViewModel);

        Task<User> LoginAsync(string username, string password);
    }
}
