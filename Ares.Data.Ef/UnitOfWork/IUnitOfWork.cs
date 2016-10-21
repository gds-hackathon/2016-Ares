using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Data.Ef.UnitOfWork
{
    public interface IUnitOfWork
    {
        IDbContext Context { get; set; }

        void RegisterAmended<T>(T entity) where T : class;

        void RegisterNew<T>(T entity) where T : class;

        void RegisterRemoved<T>(T entity) where T : class;

        void Commit();

        void Refresh();

        void Dispose();
    }
}
