using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.DepartmenID);

            // Properties
            this.Property(t => t.DepartmenID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RegionID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Names)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Parent)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Address)
                .HasMaxLength(80);

            this.Property(t => t.LeaderName)
                .HasMaxLength(20);

            this.Property(t => t.Tel)
                .HasMaxLength(18);

            this.Property(t => t.TypeName)
                .HasMaxLength(20);

            this.Property(t => t.MapX)
                .HasMaxLength(20);

            this.Property(t => t.MapY)
                .HasMaxLength(20);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            this.Property(t => t.PingYinSx)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Departments");
            this.Property(t => t.DepartmenID).HasColumnName("DepartmenID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.Names).HasColumnName("Names");
            this.Property(t => t.Parent).HasColumnName("Parent");
            this.Property(t => t.Depth).HasColumnName("Depth");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.LeaderName).HasColumnName("LeaderName");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Introduce).HasColumnName("Introduce");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.MapX).HasColumnName("MapX");
            this.Property(t => t.MapY).HasColumnName("MapY");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.PingYinSx).HasColumnName("PingYinSx");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.Departments)
                .HasForeignKey(d => d.RegionID);

        }
    }
}
