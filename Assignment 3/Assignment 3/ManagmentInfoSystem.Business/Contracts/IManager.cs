using System.Collections.Generic;

namespace ManagmentInfoSystem.Business.Contracts
{
    public interface IManager<T> where T : class
    {
        IEnumerable<T> Get();
        T Get(int id);
        string Delete(int id);
        string Update(T item);
        int Insert(T item);
    }
}
