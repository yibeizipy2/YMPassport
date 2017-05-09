using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class UserGroupMap : EntityTypeConfiguration<UserGroup>
    {
        public UserGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.UserGroupID);

            // Properties
            this.Property(t => t.UserGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CreateMan)
                .HasMaxLength(30);

            this.Property(t => t.Remark)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("UserGroup");
            this.Property(t => t.UserGroupID).HasColumnName("UserGroupID");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.CreateMan).HasColumnName("CreateMan");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
        }
    }
}
