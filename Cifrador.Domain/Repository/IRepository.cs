using System;
using System.Collections.Generic;
using System.Text;

namespace Cifrador.Domain.Repository
{
    public interface IRepository<TEntity, TId> where TEntity : class where TId : IComparable, IComparable<TId>
    {
        public TEntity FindById(string id);
    }
}
