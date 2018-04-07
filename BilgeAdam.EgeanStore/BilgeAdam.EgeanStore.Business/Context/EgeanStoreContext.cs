using BilgeAdam.EgeanStore.Business.Entities;
using System.Data.Entity;

namespace BilgeAdam.EgeanStore.Business.Context
{
    public class EgeanStoreContext : DbContext
    {
        public EgeanStoreContext() : base("edbconnstr")
        {
            //TODO:Performans şu an yavaş

            //Otomatik context ve modellerin oluşması için Add New Item -> ADO.NET Entity Data Model oluşturarak kullanılabilir
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
