using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DataContext(DbContextOptions<DataContext> dbContextOptions)
            :base(dbContextOptions)
        {
                
        }
    }
}
