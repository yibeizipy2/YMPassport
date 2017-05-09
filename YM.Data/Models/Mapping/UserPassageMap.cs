using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class UserPassageMap : EntityTypeConfiguration<UserPassage>
    {
        public UserPassageMap()
        {
            // Primary Key
            this.HasKey(t => t.UserPassageID);

            // Properties
            this.Property(t => t.UserPassageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.PassageUserID)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("UserPassages");
            this.Property(t => t.UserPassageID).HasColumnName("UserPassageID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.PassageUserID).HasColumnName("PassageUserID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.CommType).HasColumnName("CommType");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserPassages)
                .HasForeignKey(d => d.UserID);

        }
    }
}
