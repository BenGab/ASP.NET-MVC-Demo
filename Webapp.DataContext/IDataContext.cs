using System;
using System.Collections.Generic;

namespace Webapp.DataContext
{
    public interface IDataContext<T> : IDisposable
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Add(int id, T data);
    }
}
