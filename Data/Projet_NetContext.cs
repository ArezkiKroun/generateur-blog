using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Projet_.Net.Data;

public class Projet_NetContext : IdentityDbContext<User>
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Role> Roles { get; set; }

    public Projet_NetContext(DbContextOptions<Projet_NetContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
