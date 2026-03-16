using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProject.Models;

namespace MVCProject.Data.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.ToTable("Students");

            S.HasKey(S => S.Id);

            S.Property(S=> S.Name)
                .IsRequired()
                .HasMaxLength(50);

            S.Property(S => S.Age);


            // With StuCrs
            S.HasMany(S => S.StuCrses)
                .WithOne(Sc => Sc.Student)
                .HasForeignKey(Sc => Sc.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // With Depatrement 
            S.HasOne(S => S.Department)
                .WithMany(D => D.Students)
                .HasForeignKey(S => S.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
