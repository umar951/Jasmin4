using Jasmin.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jasmin.Infrastructure.Ef.Configurations;

public class FitnessclasConfiguration:IEntityTypeConfiguration<Fitnessclass>
{
    public void Configure(EntityTypeBuilder<Fitnessclass> builder)
    {
        builder.ToTable("Fitnessclass");
    }
}