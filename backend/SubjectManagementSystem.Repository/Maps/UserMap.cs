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
            builder.Property(x => x.Type).HasColumnName("type");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.Birthday).HasColumnName("birthday");
            builder.Property(x => x.City).HasColumnName("city");
            builder.Property(x => x.State).HasColumnName("state");
            builder.Property(x => x.IdInstitution).HasColumnName("id_institution");
            builder.Property(x => x.ProfilePicture).HasColumnName("profile_picture");



            //foreign keys from another tables
            builder.HasOne(x => x.Team).WithOne(x => x.Mentor).HasForeignKey<Team>(x => x.IdMentor);
            builder.HasOne(x => x.ChallengeInCharge).WithOne(x => x.InCharge).HasForeignKey<Challenge>(x => x.IdInCharge);
            builder.HasOne(x => x.ChallengeCreator).WithOne(x => x.Creator).HasForeignKey<Challenge>(x => x.IdCreator);
            
        }
    }
}