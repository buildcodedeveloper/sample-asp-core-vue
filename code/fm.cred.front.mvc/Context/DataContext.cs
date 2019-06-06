using Microsoft.EntityFrameworkCore;

namespace fm.cred.front.mvc.Context {
    public class DataContext : DbContext {

        public DataContext (DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Blog> Blogs { get; set; }

    }
}