using System.Data.Entity;

namespace MVCC.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCC.Models.Client> Clients { get; set; }
    }
}