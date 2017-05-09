using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Properties
            this.Property(t => t.RegionID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Names)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Spell)
                .HasMaxLength(30);

            this.Property(t => t.Parent)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ZipCode)
                .HasMaxLength(10);

            this.Property(t => t.AreaCode)
                .HasMaxLength(6);

            this.Property(t => t.OtNames)
                .HasMaxLength(30);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Regions");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.Names).HasColumnName("Names");
            this.Property(t => t.Spell).HasColumnName("Spell");
            this.Property(t => t.Parent).HasColumnName("Parent");
            this.Property(t => t.Depth).HasColumnName("Depth");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.AreaCode).HasColumnName("AreaCode");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.OtNames).HasColumnName("OtNames");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
