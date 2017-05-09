using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class AccountOrGroupMap : EntityTypeConfiguration<AccountOrGroup>
    {
        public AccountOrGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountOrGroup1);

            // Properties
            this.Property(t => t.AccountOrGroup1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AccountOrGroup");
            this.Property(t => t.AccountOrGroup1).HasColumnName("AccountOrGroup");
            this.Property(t => t.UserGroupID).HasColumnName("UserGroupID");
            this.Property(t => t.AccountID).HasColumnName("AccountID");

            // Relationships
            this.HasOptional(t => t.Account)
                .WithMany(t => t.AccountOrGroups)
                .HasForeignKey(d => d.AccountID);
            this.HasOptional(t => t.UserGroup)
                .WithMany(t => t.AccountOrGroups)
                .HasForeignKey(d => d.UserGroupID);

        }
    }
}
