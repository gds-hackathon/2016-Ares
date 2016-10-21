using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;
using Ares.Core.Domain;
using Ares.Infrastructure.Logging;
using Ares.Infrastructure.EFExtensions;
using Webdiyer.WebControls.Mvc;


namespace Ares.Data.Ef.Repositories
{
    public abstract class Repository<T, EntityKey> : IRepository<T, EntityKey>
        where T : class, IAggregateRoot
    {
        private IUnitOfWork unitOfWork;
        //private IDatabaseFactory databaseFactory;
        private GdAresDbContext dataContext;

        public Repository(IUnitOfWork unitOfWork)
        {
            // this.databaseFactory = new DatabaseFactory();
            this.unitOfWork = unitOfWork;

        }

        public GdAresDbContext ActiveContext
        {
            get
            {
                return dataContext ?? (dataContext = this.unitOfWork.Context as GdAresDbContext);

            }

        }

        private DbSet<T> set = null;

        public DbSet<T> Set
        {
            get
            {
                if (set == null)
                {
                    set = this.unitOfWork.Context.Set<T>();
                }
                return set;
            }
        }

        #region IRepository
        public void Save(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }
            try
            {
                this.unitOfWork.RegisterAmended(entity);
                this.unitOfWork.Commit();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbex)
            {
                foreach (var entityError in dbex.EntityValidationErrors)
                {
                    foreach (var item in entityError.ValidationErrors)
                    {
                        LoggingFactory.GetLogger().Error(string.Format("Entity property {0} is invalidate.Error message is {1}", item.PropertyName, item.ErrorMessage), dbex);
                    }
                }
                throw;
            }
            catch (Exception ex)
            {

                LoggingFactory.GetLogger().Log(ex.Message);
                throw;
            }

        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }
            try
            {
                this.unitOfWork.RegisterNew(entity);
                this.unitOfWork.Commit();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbex)
            {
                foreach (var entityError in dbex.EntityValidationErrors)
                {
                    foreach (var item in entityError.ValidationErrors)
                    {
                        LoggingFactory.GetLogger().Error(string.Format("Entity property {0} is invalidate.Error message is {1}", item.PropertyName, item.ErrorMessage), dbex);
                    }
                }
                throw;
            }
            catch (Exception ex)
            {
                LoggingFactory.GetLogger().Error(ex.Message, ex);
                throw;
            }

        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }
            try
            {
                this.unitOfWork.RegisterRemoved(entity);
                this.unitOfWork.Commit();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbex)
            {
                foreach (var entityError in dbex.EntityValidationErrors)
                {
                    foreach (var item in entityError.ValidationErrors)
                    {
                        LoggingFactory.GetLogger().Error(string.Format("Entity property {0} is invalidate.Error message is {1}", item.PropertyName, item.ErrorMessage), dbex);
                    }
                }
                throw;
            }
            catch (InvalidOperationException ioe)
            {
                LoggingFactory.GetLogger().Error(ioe.Message, ioe);
            }
            catch (Exception ex)
            {
                LoggingFactory.GetLogger().Error(ex.Message, ex);
                throw;
            }
        }

        public T FindBy(EntityKey id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Entity key cannot be null!");
            }
            return this.Set.Find(id);

        }

        public virtual IEnumerable<T> FindAll()
        {
            return this.Set.AsNoTracking().ToList();

        }

        public virtual IEnumerable<T> FindAll(int pageIndex, int pageSize)
        {
            if (pageIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Index cannot be negative!");
            }
            return this.Set.AsNoTracking().ToPagedList(pageIndex, pageSize);
        }

        public virtual IEnumerable<T> FindAll(Expression<Func<T, bool>> query)
        {
            return this.Set.Where(query).AsNoTracking().ToList();

        }

        public virtual IEnumerable<T> FindAll(Expression<Func<T, bool>> query, int index, int count)
        {
            return this.Set.AsNoTracking().Where(query).ToPagedList(index, count);

        }

        public virtual IEnumerable<T> FindAll(Expression<Func<T, bool>> query, string sortName, int index, int count)
        {
            return this.Set.AsNoTracking().Where(query).OrderByDescending(sortName).ToPagedList(index, count);
        }

        public IQueryable<T> Include(Expression<Func<T, object>> query)
        {
            return this.Set.Include(query);
        }

        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            return this.Set.AsEnumerable().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of IQueryable

        public Type ElementType
        {
            get
            {
                return (this.Set as IQueryable).ElementType;
            }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get
            {
                return (this.Set as IQueryable).Expression;
            }
        }

        public IQueryProvider Provider
        {
            get
            {
                return (this.Set as IQueryable).Provider;
            }
        }

        #endregion

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }
        /*
        #region Unit of work
        public void PersistCreationOf(IAggregateRoot entity)
        {
            var tmpEntity = entity as T;
            if (tmpEntity == null)
            {
                throw new ArgumentException("Entity's type invalidate!");
            }
            try
            {
                this.Set.Add(tmpEntity);
                this.ActiveContext.SaveChanges();

            }
            catch (Exception ex)
            {
                LoggingFactory.GetLogger().Log(ex.Message);
                throw;
            }

        }

        public void PersistUpdateOf(IAggregateRoot entity)
        {
            var tmpEntity = entity as T;
            if (tmpEntity == null)
            {
                throw new ArgumentException("Entity's type invalidate!");
            }
            try
            {
                //this.Set.Attach(tmpEntity);
                //this.ActiveContext.Entry(tmpEntity).State = System.Data.EntityState.Modified;
                //this.ActiveContext.Entry<T>(tmpEntity).OriginalValues.SetValues(tmpEntity);

                this.ActiveContext.SaveChanges();
            }
            catch (Exception ex)
            {
                LoggingFactory.GetLogger().Log(ex.Message);
                throw;
            }

        }

        public void PersistDeletionOf(IAggregateRoot entity)
        {
            var tmpEntity = entity as T;
            if (tmpEntity == null)
            {
                throw new ArgumentException("Entity's type invalidate!");
            }
            try
            {
                this.Set.Remove(tmpEntity);
                this.ActiveContext.SaveChanges();

            }
            catch (Exception ex)
            {
                LoggingFactory.GetLogger().Log(ex.Message);
                throw;
            }

        }
        #endregion
       */



    }
}
