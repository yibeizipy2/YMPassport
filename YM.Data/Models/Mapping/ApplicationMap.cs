using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class ApplicationMap : EntityTypeConfiguration<Application>
    {
        public ApplicationMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplicationID);

            // Properties
            this.Property(t => t.ApplicationID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Names)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ApplicationCode)
                .HasMaxLength(30);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Applications");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.Names).HasColumnName("Names");
            this.Property(t => t.ApplicationCode).HasColumnName("ApplicationCode");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.MenuDepth).HasColumnName("MenuDepth");
        }
    }
}
