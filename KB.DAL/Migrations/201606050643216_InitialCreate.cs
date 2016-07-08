namespace KB.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Admin",
                c => new
                    {
                        AdID = c.Int(nullable: false, identity: true),
                        AdName = c.String(nullable: false, maxLength: 20),
                        AdPwd = c.String(nullable: false, maxLength: 20),
                        CentName = c.String(nullable: false, maxLength: 20),
                        GetGame = c.String(),
                    })
                .PrimaryKey(t => t.AdID);
            
            CreateTable(
                "dbo.tb_EditCent",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdID = c.Int(nullable: false),
                        BeforeCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AfterCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_FirstPage",
                c => new
                    {
                        FID = c.Int(nullable: false, identity: true),
                        AdID = c.Int(nullable: false),
                        FTile = c.String(),
                        RowUrl = c.String(),
                        ChatUrl = c.String(),
                    })
                .PrimaryKey(t => t.FID);
            
            CreateTable(
                "dbo.tb_Game",
                c => new
                    {
                        GID = c.Int(nullable: false, identity: true),
                        GName = c.String(nullable: false),
                        GTable = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GID);
            
            CreateTable(
                "dbo.tb_KkkwNum",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdID = c.Int(nullable: false),
                        KKDate = c.String(),
                        OpenNum = c.String(),
                        OpenType = c.Int(nullable: false),
                        OpenNote = c.String(),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_KkkwOrder",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdID = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        KKDate = c.String(),
                        Num = c.String(),
                        UsID = c.Int(nullable: false),
                        Odds = c.Single(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Zhu = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        WinCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WinNotes = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_KkkwSet",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Logo = c.String(),
                        AdID = c.Int(nullable: false),
                        Note = c.String(),
                        OpenType = c.Int(nullable: false),
                        Odds = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        AllCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LiveImage = c.String(),
                        LiveText = c.String(),
                        State = c.Int(nullable: false),
                        KKDate = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_Root",
                c => new
                    {
                        RoID = c.Int(nullable: false, identity: true),
                        RoName = c.String(nullable: false, maxLength: 20),
                        RoPwd = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.RoID);
            
            CreateTable(
                "dbo.tb_SpendText",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdID = c.Int(nullable: false),
                        UsID = c.Int(nullable: false),
                        AcCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AfterCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GameID = c.Int(nullable: false),
                        Content = c.String(),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_Transfer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdID = c.Int(nullable: false),
                        UsID = c.Int(nullable: false),
                        AfterCent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Content = c.String(),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_User",
                c => new
                    {
                        UsID = c.Int(nullable: false, identity: true),
                        UsName = c.String(nullable: false, maxLength: 20),
                        UsPwd = c.String(nullable: false, maxLength: 20),
                        AdID = c.Int(nullable: false),
                        Cent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MarkName = c.String(),
                        Content = c.String(),
                        CanGame = c.String(),
                    })
                .PrimaryKey(t => t.UsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_User");
            DropTable("dbo.tb_Transfer");
            DropTable("dbo.tb_SpendText");
            DropTable("dbo.tb_Root");
            DropTable("dbo.tb_KkkwSet");
            DropTable("dbo.tb_KkkwOrder");
            DropTable("dbo.tb_KkkwNum");
            DropTable("dbo.tb_Game");
            DropTable("dbo.tb_FirstPage");
            DropTable("dbo.tb_EditCent");
            DropTable("dbo.tb_Admin");
        }
    }
}
