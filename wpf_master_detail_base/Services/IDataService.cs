using System.Collections.Generic;

namespace wpf_ex_final.Services
{
    public interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }
}
