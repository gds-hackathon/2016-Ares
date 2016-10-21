using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Ares.Core.Domain;
using System.Data.Entity.Infrastructure;

namespace Ares.Data.Ef.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        public IDbContext Context
        {
            get;
            set;
        }

        public UnitOfWork(IDbContext context)
        {
            this.Context = context;
        }

        public void RegisterAmended<T>(T entity) where T : class
        {
            if (this.Context.Entry<T>(entity).State == EntityState.Detached)
            {
                this.Context.Set<T>().Attach(entity);
            }
            this.Context.Entry<T>(entity).State = EntityState.Modified;
        }

        public void RegisterNew<T>(T entity) where T : class
        {
            this.Context.Set<T>().Add(entity);
        }

        public void RegisterRemoved<T>(T entity) where T : class
        {
            this.Context.Set<T>().Remove(entity);
        }

        public void Commit()
        {
            this.Context.SaveChanges();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.Context.Dispose();
                }
            }
            this.disposed = true;
        }


        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
