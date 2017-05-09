using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using YM.Data.Models.Mapping;

namespace YM.Data.Models
{
    public partial class YMPassportContext : DbContext
    {
        static YMPassportContext()
        {
            Database.SetInitializer<YMPassportContext>(null);
        }

        public YMPassportContext()
            : base("Name=YMPassportContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountOrGroup> AccountOrGroups { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<AppAndUser> AppAndUsers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<AppLog> AppLogs { get; set; }
        public DbSet<DepartmentPassage> DepartmentPassages { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FunctionMemu> FunctionMemus { get; set; }
        public DbSet<GroupPermission> GroupPermissions { get; set; }
        public DbSet<RapidFunction> RapidFunctions { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<UserAndAccount> UserAndAccounts { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserPassage> UserPassages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AccountOrGroupMap());
            modelBuilder.Configurations.Add(new AccountTypeMap());
            modelBuilder.Configurations.Add(new AppAndUserMap());
            modelBuilder.Configurations.Add(new ApplicationMap());
            modelBuilder.Configurations.Add(new AppLogMap());
            modelBuilder.Configurations.Add(new DepartmentPassageMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new FunctionMemuMap());
            modelBuilder.Configurations.Add(new GroupPermissionMap());
            modelBuilder.Configurations.Add(new RapidFunctionMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new UserAndAccountMap());

            modelBuilder.Configurations.Add(new UserGroupMap());
            modelBuilder.Configurations.Add(new UserPassageMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
