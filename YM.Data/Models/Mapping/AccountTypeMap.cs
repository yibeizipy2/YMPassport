using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class AccountTypeMap : EntityTypeConfiguration<AccountType>
    {
        public AccountTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountTypeID);

            // Properties
            this.Property(t => t.AccountTypeID)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.ApplicationID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Names)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Remark)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("AccountType");
            this.Property(t => t.AccountTypeID).HasColumnName("AccountTypeID");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.Names).HasColumnName("Names");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.DType).HasColumnName("DType");
        }
    }
}
