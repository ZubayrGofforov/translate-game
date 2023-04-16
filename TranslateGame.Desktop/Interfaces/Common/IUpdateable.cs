using System;

namespace TranslateGame.Desktop.Interfaces.Common
{
    public interface IUpdateable<T>
    {
        bool Update(Guid id, T obj);
    }
}
