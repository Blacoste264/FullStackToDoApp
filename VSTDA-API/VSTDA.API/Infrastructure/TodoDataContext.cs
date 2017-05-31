using System.Data.Entity;
using VSTDA.Models;

namespace VSTDA.Infrastructure
{
    public class TodoDataContext : DbContext
    {
        public TodoDataContext() : base("VSTDA")
        {

        }
        public DbSet<ToDo> ToDoes { get; set; }
    }
}