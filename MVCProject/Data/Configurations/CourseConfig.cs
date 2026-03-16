using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProject.Models;

namespace MVCProject.Data.Configurations
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.ToTable("Courses");

            C.HasKey(C => C.Id);


            C.Property(C => C.Name)
                .HasMaxLength(49)
                .IsRequired();


            C.Property(C => C.Degree).IsRequired();

            C.Property(C => C.MinDegree).IsRequired();


           // wiht dept 

            C.HasOne(C=> C.Department)
                .WithMany(D => D.Courses)
                .HasForeignKey(C => C.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
