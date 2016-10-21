using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Ares.Core.Domain;

namespace Ares.Core.Repositories
{
    public interface IRepository<T, TId> : IReadOnlyRepository<T, TId> where T : IAggregateRoot
    {
        void Save(T entity);

        void Add(T entity);

        void Remove(T entity);

        IQueryable<T> Include(Expression<Func<T, object>> query);
    }
}
