using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Ares.Core.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Ares.Core.Repositories
{
    public interface IRepositoryAsync<T,TId> : IQueryable<T> where T : IAggregateRoot
    {
        Task<T> FindAsync(params object[] keyValues);
        Task<T> FindAsync(CancellationToken cancellationToken, params object[] keyValues);
        Task<bool> DeleteAsync(params object[] keyValues);
        Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues);
    }
}
