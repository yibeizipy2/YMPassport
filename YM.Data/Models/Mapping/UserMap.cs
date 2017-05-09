using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.DepartmenID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UPassword)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Names)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.PassportNo)
                .HasMaxLength(18);

            this.Property(t => t.Tel)
                .HasMaxLength(20);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.DepartmenID).HasColumnName("DepartmenID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.UPassword).HasColumnName("UPassword");
            this.Property(t => t.Names).HasColumnName("Names");
            this.Property(t => t.PassportNo).HasColumnName("PassportNo");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.Department)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.DepartmenID);

        }
    }
}
