using System;
using System.Collections.Generic;
using System.Text;

namespace Cifrador.Domain.Entity
{
    public abstract class Entity<TEntity> where TEntity : IComparable, IComparable<TEntity>
    {
        public TEntity Id { get; set; }
    }
}
