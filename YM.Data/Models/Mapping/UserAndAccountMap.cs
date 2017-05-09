using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class UserAndAccountMap : EntityTypeConfiguration<UserAndAccount>
    {
        public UserAndAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.UserAndAccountID);

            // Properties
            this.Property(t => t.UserAndAccountID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("UserAndAccount");
            this.Property(t => t.UserAndAccountID).HasColumnName("UserAndAccountID");
            this.Property(t => t.Account).HasColumnName("Account");
            this.Property(t => t.UserID).HasColumnName("UserID");

            // Relationships
            this.HasRequired(t => t.Account1)
                .WithMany(t => t.UserAndAccounts)
                .HasForeignKey(d => d.Account);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserAndAccounts)
                .HasForeignKey(d => d.UserID);

        }
    }
}
