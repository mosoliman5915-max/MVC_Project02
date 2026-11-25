using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project02.Entities;

namespace MVC_Project02.Configuration
{
    public class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(m => m.Id);
           
            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
            builder.HasOne(m => m.Plan)
                .WithMany(p => p.PlanSubscriptions)
                .HasForeignKey(m => m.PlanId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
