using System.Collections.Generic;
using System.Threading.Tasks;
using TranslateGame.Desktop.Enums;
using TranslateGame.Desktop.Interfaces.Common;
using TranslateGame.Desktop.Models;

namespace TranslateGame.Desktop.Interfaces
{
    public interface IWordRepository
        : ICreatable<Word>
    {
        Word GetByWord(string word);

        Task<IList<Word>> GetConfigurated(int count, TestLevel level);

        bool Update(string word, Word obj);
    }
}
