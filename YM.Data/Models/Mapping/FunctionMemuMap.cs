using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class FunctionMemuMap : EntityTypeConfiguration<FunctionMemu>
    {
        public FunctionMemuMap()
        {
            // Primary Key
            this.HasKey(t => t.FunctionMemu1);

            // Properties
            this.Property(t => t.FunctionMemu1)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ApplicationID)
                .HasMaxLength(30);

            this.Property(t => t.Parent)
                .HasMaxLength(20);

            this.Property(t => t.Path)
                .HasMaxLength(200);

            this.Property(t => t.FunctionCode)
                .HasMaxLength(100);

            this.Property(t => t.Url)
                .HasMaxLength(150);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FunctionMemus");
            this.Property(t => t.FunctionMemu1).HasColumnName("FunctionMemu");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.Parent).HasColumnName("Parent");
            this.Property(t => t.Depth).HasColumnName("Depth");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.FunctionCode).HasColumnName("FunctionCode");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.Sort).HasColumnName("Sort");

            // Relationships
            this.HasOptional(t => t.Application)
                .WithMany(t => t.FunctionMemus)
                .HasForeignKey(d => d.ApplicationID);

        }
    }
}
