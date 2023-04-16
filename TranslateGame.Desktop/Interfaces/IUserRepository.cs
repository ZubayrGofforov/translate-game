using TranslateGame.Desktop.Interfaces.Common;
using TranslateGame.Desktop.Models;

namespace TranslateGame.Desktop.Interfaces
{
    public interface IUserRepository
        : ICreatable<User>, IReadable<User>,
          IUpdateable<User>
    {
        User GetByUsername(string username);
    }
}
