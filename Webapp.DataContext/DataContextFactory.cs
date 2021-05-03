namespace Webapp.DataContext
{
    public class DataContextFactory<T> : IDataContextFactory<T>
    {
        public IDataContext<T> Create()
        {
            return new DataContext<T>();
        }
    }
}
