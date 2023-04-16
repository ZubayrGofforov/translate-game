using System;
using System.Collections.Generic;

namespace TranslateGame.Desktop.Interfaces.Common
{
    public interface IReadable<T>
    {
        T Get(Guid id);

        IList<T> GetAll();
    }
}
