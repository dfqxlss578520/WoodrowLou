using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodrowLuo.Common.Core.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public IQueryable<T> Table
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity, object modKeys)
        {
            throw new NotImplementedException();
        }
    }
}
