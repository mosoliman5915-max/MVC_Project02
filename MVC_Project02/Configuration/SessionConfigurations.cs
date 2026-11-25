using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project02.Entities;

namespace MVC_Project02.Configuration
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
        builder.Property(x => x.CreatedAt)
        .HasDefaultValueSql("GETDATE()");

            builder.HasOne(x => x.Trainer)
                .WithMany(x => x.Sessions)
                .OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityConstrains", "Capacity between 1 and 25");
                T.HasCheckConstraint("SessionEndDateAfterStartDate", "EndDate>startDate");
            });
    }
    }
}
