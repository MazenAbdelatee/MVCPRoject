using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProject.Models;

namespace MVCProject.Data.Configurations
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.ToTable("Depatments");

            D.HasKey(D => D.Id);


            D.Property(D => D.Name)
                .HasMaxLength(60)
                .IsRequired();

            D.Property(D => D.MgrName)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
