using System.Collections.Generic;
using Webapp.DataContext;

namespace WebApp.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IDataContext<T> dataContext;

        public Repository(IDataContext<T> dataContext)
        {
            this.dataContext = dataContext;
        }

        public T Add(int id, T data)
        {
            return dataContext.Add(id, data);
        }

        public T Get(int id)
        {
            return dataContext.Get(id);
        }

        public IEnumerable<T> GetAll()
        {
            return dataContext.GetAll();
        }
    }
}
