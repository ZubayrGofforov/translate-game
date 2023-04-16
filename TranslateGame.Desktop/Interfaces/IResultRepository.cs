using TranslateGame.Desktop.Interfaces.Common;
using TranslateGame.Desktop.Models;

namespace TranslateGame.Desktop.Interfaces
{
    public interface IResultRepository
        : ICreatable<Result>, IUpdateable<Result>,
          IReadable<Result>
    {
    }
}
