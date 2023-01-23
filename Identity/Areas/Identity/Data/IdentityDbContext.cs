using Identity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Areas.Identity.Data;

public class IdentityDbContext : IdentityDbContext<AppIdentityUser>
{
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new AppIdentityUserEntityConfiguration());
    }
}
public class AppIdentityUserEntityConfiguration : IEntityTypeConfiguration<AppIdentityUser>
{
    public void Configure(EntityTypeBuilder<AppIdentityUser> builder)
    {
        throw new NotImplementedException();
    }
}