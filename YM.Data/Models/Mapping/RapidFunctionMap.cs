using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class RapidFunctionMap : EntityTypeConfiguration<RapidFunction>
    {
        public RapidFunctionMap()
        {
            // Primary Key
            this.HasKey(t => t.RapidFunctionID);

            // Properties
            this.Property(t => t.RapidFunctionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FunctionCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Remark)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("RapidFunction");
            this.Property(t => t.RapidFunctionID).HasColumnName("RapidFunctionID");
            this.Property(t => t.FunctionCode).HasColumnName("FunctionCode");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.IsOften).HasColumnName("IsOften");
            this.Property(t => t.ClickCount).HasColumnName("ClickCount");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
