using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class UserTeamMap : BaseEntityMap<UserTeam>
    {
        public UserTeamMap() : base("tb_user_team") { }

        public override void Configure(EntityTypeBuilder<UserTeam> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.IdUser).HasColumnName("id_user");
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.IdUser);
            builder.Property(x => x.IdTeam).HasColumnName("id_team");
            builder.HasOne(x => x.Team).WithMany(x => x.Members).HasForeignKey(x => x.IdTeam);



        }
    }
}