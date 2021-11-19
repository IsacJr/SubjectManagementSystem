using SubjectManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SubjectManagementSystem.Repository
{
    public class ChallengeMap : BaseEntityMap<Challenge>
    {
        public ChallengeMap() : base("tb_challenge") { }

        public override void Configure(EntityTypeBuilder<Challenge> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Code).HasColumnName("name");
            builder.Property(x => x.Title).HasColumnName("title");
            builder.Property(x => x.Caption).HasColumnName("caption");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.Status).HasColumnName("status");

            builder.Property(x => x.IdField).HasColumnName("id_field");
            builder.Property(x => x.IdInCharge).HasColumnName("id_in_charge");
            builder.Property(x => x.IdInstitution).HasColumnName("id_institution");


            //foreign keys from another tables
            
            
        }
    }
}