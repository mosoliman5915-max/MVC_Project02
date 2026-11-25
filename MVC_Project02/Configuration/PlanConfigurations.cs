using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project02.Entities;

namespace MVC_Project02.Configuration
{
    public class PlanConfigurations :IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("PlanCheckDuration", "[DurationDays] BETWEEN 1 AND 365");


            });

        }
    }
}
