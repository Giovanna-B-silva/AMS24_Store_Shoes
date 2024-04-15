using AMST4StoreShoes.entities;
using Microsoft.EntityFrameworkCore;


/// <summary>
/// <author></author>
/// </summary>
public class ApplicationDataContextt : DbContext
{
    public ApplicationDataContextt(DbContextOptions<ApplicationDataContextt> opts) : base(opts)
    {
        
    }

    public DbSet<Color> Color { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Product> Product { get; set; }
}