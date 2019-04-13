using System.Collections.Generic;

namespace NetCoreApi.Core.Interface
{
    public interface IRepository
    {
        T GetById<T>(int id);
        IEnumerable<T> ListAll<T>();
        T Add<T>(T entity);
        void Update<T>(T entity);
        void Delete<T>(T entity);
    }
}
