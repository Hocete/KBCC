using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KB.Models;
using System.Data.Entity;

namespace KB.DAL
{
    public class KBDbContext :DbContext
    {
        public DbSet<tb_User> User { get; set; }
        public DbSet<tb_Root> Root { get; set; }
        public DbSet<tb_Admin> Admin { get; set; }
        public DbSet<tb_Game> Game { get; set; }
        public DbSet<tb_FirstPage> FirstPage { get; set; }
        public DbSet<tb_Transfer> Transfer { get; set; }
        public DbSet<tb_SpendText> SpendText { get; set; }
        public DbSet<tb_EditCent> EditCent { get; set; }
        public DbSet<tb_KkkwNum> KkkwNum { get; set; }
        public DbSet<tb_KkkwOrder> KkkwOrder { get; set; }
        public DbSet<tb_KkkwSet> KkkwSet { get; set; }
        public KBDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<KBDbContext, Migrations.Configuration>());

        }
    }
}
