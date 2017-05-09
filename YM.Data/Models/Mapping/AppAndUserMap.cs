using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class AppAndUserMap : EntityTypeConfiguration<AppAndUser>
    {
        public AppAndUserMap()
        {
            // Primary Key
            this.HasKey(t => t.AppAndUserID);

            // Properties
            this.Property(t => t.AppAndUserID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ApplicationID)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("AppAndUser");
            this.Property(t => t.AppAndUserID).HasColumnName("AppAndUserID");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.Account).HasColumnName("Account");

            // Relationships
            this.HasRequired(t => t.Account1)
                .WithMany(t => t.AppAndUsers)
                .HasForeignKey(d => d.Account);
            this.HasRequired(t => t.Application)
                .WithMany(t => t.AppAndUsers)
                .HasForeignKey(d => d.ApplicationID);

        }
    }
}
