using NetCoreApi.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreApi.Infrastructure.Data
{
    public class Repository : IRepository
    {
        public Repository()
        {

        }
        public T Add<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ListAll<T>()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
