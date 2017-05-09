using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class GroupPermissionMap : EntityTypeConfiguration<GroupPermission>
    {
        public GroupPermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupPermissionGroupID);

            // Properties
            this.Property(t => t.GroupPermissionGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FunctionMemu)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GroupPermission");
            this.Property(t => t.GroupPermissionGroupID).HasColumnName("GroupPermissionGroupID");
            this.Property(t => t.UserGroupID).HasColumnName("UserGroupID");
            this.Property(t => t.FunctionMemu).HasColumnName("FunctionMemu");

            // Relationships
            this.HasOptional(t => t.FunctionMemu1)
                .WithMany(t => t.GroupPermissions)
                .HasForeignKey(d => d.FunctionMemu);
            this.HasOptional(t => t.UserGroup)
                .WithMany(t => t.GroupPermissions)
                .HasForeignKey(d => d.UserGroupID);

        }
    }
}
