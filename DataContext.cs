global using Microsoft.EntityFrameworkCore;

namespace MinimalBookApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Server=localhost;User Id=root;Password=axaya5;Database=leonardo
        //server=localhost;port=3306;database=booksgit;user=root;password=axaya5

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;port=3306;database=books;user=root;password=axaya5", new MySqlServerVersion(new Version(10, 10, 2)));
        }

        public DbSet<Book> Books => Set<Book>();
    }
}
