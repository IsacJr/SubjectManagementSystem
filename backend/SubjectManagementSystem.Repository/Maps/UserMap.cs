using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class UserMap : BaseEntityMap<User>
    {
        public UserMap() : base("tb_user") { }

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Email).HasColumnName("code");
            builder.Property(x => x.Birthday).HasColumnName("syllabus");
            builder.Property(x => x.City).HasColumnName("city");
            builder.Property(x => x.State).HasColumnName("state");
            builder.Property(x => x.ProfilePicture).HasColumnName("profile_picture");

            builder.Property(x => x.idTeam).HasColumnName("id_team");
            builder.HasOne(x => x.Team).WithMany().HasForeignKey(x => x.idTeam);

            //foreign keys relations from another tables
            // builder.HasOne(x => x.Classroom).WithOne(x => x.Professor).HasForeignKey<Classroom>(x => x.IdProfessor);
            builder.HasOne(x => x.Challenge).WithOne(x => x.InCharge).HasForeignKey<Challenge>(x => x.IdInCharge);
            //foreign keys from another tables
            builder.HasOne(x => x.Team).WithOne(x => x.Mentor).HasForeignKey<Team>(x => x.IdMentor);
            
        }
    }
}