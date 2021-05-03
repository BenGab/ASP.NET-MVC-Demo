using System.Collections.Generic;
using Webapp.DataContext;

namespace WebApp.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IDataContextFactory<T> dataContextFactory;

        public Repository(IDataContextFactory<T> dataContextFactory)
        {
            this.dataContextFactory = dataContextFactory;
        }

        public T Add(int id, T data)
        {
            using (var dataContext = dataContextFactory.Create())
            {
                return dataContext.Add(id, data);
            }
        }

        public T Get(int id)
        {
            using (var dataContext = dataContextFactory.Create())
            {
                return dataContext.Get(id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var dataContext = dataContextFactory.Create())
            {
                return dataContext.GetAll();
            }
        }
    }
}
