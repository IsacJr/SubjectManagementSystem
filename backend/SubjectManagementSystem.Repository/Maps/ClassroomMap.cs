using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class ClassroomMap : BaseEntityMap<Classroom>
    {
        public ClassroomMap() : base("tb_classroom") { }

        public override void Configure(EntityTypeBuilder<Classroom> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Code).HasColumnName("code");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.StartDate).HasColumnName("start_date");
            builder.Property(x => x.EndDate).HasColumnName("end_date");
            builder.Property(x => x.Schedule).HasColumnName("schedule");
            builder.Property(x => x.Room).HasColumnName("room");
            builder.Property(x => x.Professor).HasColumnName("professor");
            builder.Property(x => x.Year).HasColumnName("year");
            builder.Property(x => x.Spot).HasColumnName("spot");
            builder.Property(x => x.ClassPlan).HasColumnName("class_plan");

            builder.Property(x => x.IdProfessor).HasColumnName("id_professor");
            builder.HasOne(x => x.Professor).WithMany().HasForeignKey(x => x.IdProfessor);
            builder.Property(x => x.IdSubject).HasColumnName("id_subject");
            builder.HasOne(x => x.Subject).WithMany().HasForeignKey(x => x.IdSubject);
            builder.Property(x => x.IdChallenge).HasColumnName("id_challenge");
            builder.HasOne(x => x.Challenge).WithMany().HasForeignKey(x => x.IdChallenge);

            
        }
    }
}