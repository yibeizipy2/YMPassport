using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountID);

            // Properties
            this.Property(t => t.AccountID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccountTypeID)
                .HasMaxLength(18);

            this.Property(t => t.Names)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Remark)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("Account");
            this.Property(t => t.AccountID).HasColumnName("AccountID");
            this.Property(t => t.AccountTypeID).HasColumnName("AccountTypeID");
            this.Property(t => t.Names).HasColumnName("Names");
            this.Property(t => t.AccountType).HasColumnName("AccountType");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsShow).HasColumnName("IsShow");

            // Relationships
            this.HasOptional(t => t.AccountType1)
                .WithMany(t => t.Accounts)
                .HasForeignKey(d => d.AccountTypeID);

        }
    }
}
