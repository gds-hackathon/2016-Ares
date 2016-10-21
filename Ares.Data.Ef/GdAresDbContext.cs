using System.Linq;
using Ares.Core.Domain;
//using Ares.Data.Ef.Mapping;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef
{
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public class GdAresDbContext: System.Data.Entity.DbContext, IGdAresDbContext, IDbContext
    {
        static GdAresDbContext()
        {
            System.Data.Entity.Database.SetInitializer<GdAresDbContext>(null);
        }

        public GdAresDbContext()
            : base("Name=GDAres")
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }



        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            return modelBuilder;
        }
        public System.Linq.IQueryable<T> Find<T>() where T : class
        {
            return this.Set<T>();
        }

    }
}
