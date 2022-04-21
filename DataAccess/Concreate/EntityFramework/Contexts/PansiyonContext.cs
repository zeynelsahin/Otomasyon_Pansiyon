using System.Data.Entity;
using Entity.Concreate.Entities;

namespace DataAccess.Concreate.EntityFramework.Contexts
{
    public class PansiyonContext : DbContext
    {
        public PansiyonContext() : base("PansiyonContext")
        {
           
        }

        public DbSet<Konaklama> Konaklamalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Oda> Odalar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}