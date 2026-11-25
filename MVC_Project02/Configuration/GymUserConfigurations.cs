using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Project02.Entities;

namespace MVC_Project02.Configuration
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);


            builder.Property(x => x.Phone)
               .HasColumnType("varchar")
               .HasMaxLength(11);


            builder.ComplexProperty(x => x.Address);

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();

            builder.ToTable(T =>
            {

                T.HasCheckConstraint("GymUser_EmailCheck", "Email Like '_%@_%._%'");
                T.HasCheckConstraint("GymUser_PhoneCheck", "lEN(Phone)=11 And (Phone Like '010%' Or Phone LIKE'011%' OR Phone LIKE'012%' OR Phone LIKE'015%') ");

            });


        }
    }
}
