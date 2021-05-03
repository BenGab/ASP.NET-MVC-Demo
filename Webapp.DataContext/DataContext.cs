using System.Collections.Generic;

namespace Webapp.DataContext
{
    internal class DataContext<T> : IDataContext<T>
    {
        private readonly IDictionary<int, T> db;

        public DataContext()
        {
            db  = new Dictionary<int, T>();
        }

        public T Add(int id, T data)
        {
            if(db.ContainsKey(id))
            {
                return data;
            }

            db.Add(id, data);
            return data;
        }

        public void Dispose()
        {
            //Do Nothing, Just example for factory base solution
        }

        public T Get(int id)
        {
            return db[id];
        }
        public IEnumerable<T> GetAll()
        {
            return db.Values;
        }
    }
}
