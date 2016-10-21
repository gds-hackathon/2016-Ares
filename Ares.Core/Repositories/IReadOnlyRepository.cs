using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Ares.Core.Domain;

namespace Ares.Core.Repositories
{
    public interface IReadOnlyRepository<T, TId> : IQueryable<T> where T : IAggregateRoot
    {
        T FindBy(TId id);

        IEnumerable<T> FindAll();

        IEnumerable<T> FindAll(int pageIndex, int pageSize);

        IEnumerable<T> FindAll(Expression<Func<T, bool>> query);

        IEnumerable<T> FindAll(Expression<Func<T, bool>> query, int index, int count);

        IEnumerable<T> FindAll(Expression<Func<T, bool>> query, string sortName, int index, int count);
    }
}
