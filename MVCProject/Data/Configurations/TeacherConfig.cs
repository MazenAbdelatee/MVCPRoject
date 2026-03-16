using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProject.Models;

namespace MVCProject.Data.Configurations
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> T)
        {
            T.ToTable("Teachers");

            T.HasKey(T => T.Id);

            T.Property(T => T.Name)
                .HasMaxLength(50)
                .IsRequired();

            T.Property(T => T.Address)
                .HasMaxLength(100)
                .IsRequired();

            T.Property(T => T.Salary)
                .HasColumnType("decimal(18,2)")
                .IsRequired();


            //with Department 
            T.HasOne(T => T.Department)
                .WithMany(D => D.Teachers)
                .HasForeignKey(T=> T.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);


            // with course 

            T.HasOne(T => T.Course)
                .WithMany(C => C.Teachers)
                .HasForeignKey(T => T.CoursetId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
