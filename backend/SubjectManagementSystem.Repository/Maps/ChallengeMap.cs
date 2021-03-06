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
            builder.Property(x => x.Material).HasColumnName("material");

            builder.Property(x => x.IdField).HasColumnName("id_field");
            builder.HasOne(x => x.Field).WithMany().HasForeignKey(x => x.IdField);
            builder.Property(x => x.IdCreator).HasColumnName("id_creator");
            builder.HasOne(x => x.Creator).WithMany().HasForeignKey(x => x.IdCreator);
            
            builder.Property(x => x.IdInCharge).HasColumnName("id_in_charge");
            builder.HasOne(x => x.InCharge).WithMany().HasForeignKey(x => x.IdInCharge);
            builder.Property(x => x.IdInstitution).HasColumnName("id_institution");
            builder.HasOne(x => x.Institution).WithMany().HasForeignKey(x => x.IdInstitution);

            builder.Property(x => x.IdClassroom).HasColumnName("id_classroom");
            builder.HasOne(x => x.Classroom).WithMany().HasForeignKey(x => x.IdClassroom);



            //foreign keys from another tables
            builder.HasOne(x => x.Contract).WithOne(x => x.Challenge).HasForeignKey<Contract>(x => x.IdChallenge);
            
        }
    }
}