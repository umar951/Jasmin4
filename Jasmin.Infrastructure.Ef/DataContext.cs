using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Jasmin.Infrastructure.Ef;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(DataContext)) ?? throw new InvalidOperationException());
    }
}