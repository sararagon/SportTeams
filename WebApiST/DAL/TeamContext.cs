using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ModelsST;
using ServicesST;

namespace WebApiST.DAL
{
    public class TeamContext: DbContext
    {
        public TeamContext() : base("TeamContext")
        {
        }

        public TeamContext(DbConnection dbConnection, bool contextOwnsConnection) : base(dbConnection,
            contextOwnsConnection)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
