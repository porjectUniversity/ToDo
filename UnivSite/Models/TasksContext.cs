using System.Data.Entity;

namespace UnivSite.Models
{
    public class TasksContext : DbContext
    {
        public DbSet<Tasks> tasks { get; set; }
    }
}