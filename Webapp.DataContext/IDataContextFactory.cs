using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapp.DataContext
{
    public interface IDataContextFactory<T>
    {
        //DbContext
        IDataContext<T> Create();
    }
}
