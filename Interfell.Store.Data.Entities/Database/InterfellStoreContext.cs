
#region Usings

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfell.Store.Data.Entities.Entity;

#endregion

namespace Interfell.Store.Data.Entities.Database
{
    public class InterfellStoreContext: DbContext
    {
        public InterfellStoreContext():base("name=InterfellStore")
        {
           System.Data.Entity.Database.SetInitializer(new CreateDatabaseIfNotExists<InterfellStoreContext>());
        }

        public DbSet<Stores> Stores { get; set; }
        public DbSet<Articles> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
