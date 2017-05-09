using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YM.Data.Models.Mapping
{
    public class AppLogMap : EntityTypeConfiguration<AppLog>
    {
        public AppLogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogID);

            // Properties
            this.Property(t => t.LogID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ApplicationID)
                .HasMaxLength(30);

            this.Property(t => t.Level)
                .HasMaxLength(50);

            this.Property(t => t.LogTitle)
                .HasMaxLength(100);

            this.Property(t => t.Message)
                .HasMaxLength(4000);

            this.Property(t => t.LoginUser)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("AppLogs");
            this.Property(t => t.LogID).HasColumnName("LogID");
            this.Property(t => t.ApplicationID).HasColumnName("ApplicationID");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.LogTitle).HasColumnName("LogTitle");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.LoginUser).HasColumnName("LoginUser");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDispose).HasColumnName("IsDispose");
            this.Property(t => t.LogType).HasColumnName("LogType");

            // Relationships
            this.HasOptional(t => t.Application)
                .WithMany(t => t.AppLogs)
                .HasForeignKey(d => d.ApplicationID);

        }
    }
}
