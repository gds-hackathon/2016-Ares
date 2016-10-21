using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Ares.Data.Ef.UnitOfWork
{
    public interface IDbContext
    {
        DbChangeTracker ChangeTracker { get; }

        DbSet<T> Set<T>() where T : class;

        IQueryable<T> Find<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();

        void Dispose();
    }
}
