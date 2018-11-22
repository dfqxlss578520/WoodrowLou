using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodrowLuo.Common.Core.Data
{
    public interface IRepository<T> where T :class
    {
        T GetById(object id);
        T Insert(T entity);
        bool Update(T entity);
        bool Update(T entity, object modKeys);
        //public bool Update(T entity, System.Linq.Expressions.Expression<Action<T>> fieldsAction);
        bool Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
