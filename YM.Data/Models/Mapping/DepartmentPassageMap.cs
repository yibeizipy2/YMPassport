using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class DepartmentPassageMap : EntityTypeConfiguration<DepartmentPassage>
    {
        public DepartmentPassageMap()
        {
            // Primary Key
            this.HasKey(t => t.DepartmentPassageID);

            // Properties
            this.Property(t => t.DepartmentPassageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.DepartmentID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Names)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DepartmentPassages");
            this.Property(t => t.DepartmentPassageID).HasColumnName("DepartmentPassageID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.Names).HasColumnName("Names");
            this.Property(t => t.CommType).HasColumnName("CommType");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.DepartmentPassages)
                .HasForeignKey(d => d.UserID);

        }
    }
}
