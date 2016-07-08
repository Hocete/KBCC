namespace KB.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_User", "CanGame2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_User", "CanGame2", c => c.String());
        }
    }
}
