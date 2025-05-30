using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Pet> Pets => Set<Pet>();

    public DbSet<Tutor> Tutores => Set<Tutor>();
}