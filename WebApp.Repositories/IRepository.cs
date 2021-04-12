using System.Collections.Generic;

namespace WebApp.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Add(int id, T data);
    }
}
