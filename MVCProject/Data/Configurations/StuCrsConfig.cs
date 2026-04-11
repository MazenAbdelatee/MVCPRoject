using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProject.Models;

namespace MVCProject.Data.Configurations
{
    public class StuCrsConfig : IEntityTypeConfiguration<StuCrs>
    {
        public void Configure(EntityTypeBuilder<StuCrs> SC)
        {
            SC.ToTable("Students_Courses");


            SC.HasKey(SC => new { SC.StudentId, SC.CourseId });


            SC.Property(SC => SC.Grade);

            // Relations 
            // with Student 

            SC.HasOne(Sc => Sc.Student)
                .WithMany(S => S.StuCrses)
                .HasForeignKey(S => S.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            SC.HasOne(Sc => Sc.Course)
                .WithMany(S => S.StuCrses)
                .HasForeignKey(SC => SC.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
