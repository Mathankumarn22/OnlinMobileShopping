namespace OnlineMobileShop.Respository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mobilev3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mobiles", "BrandID", c => c.Int(nullable: false));
            CreateIndex("dbo.Mobiles", "BrandID");
            AddForeignKey("dbo.Mobiles", "BrandID", "dbo.Brands", "BrandID", cascadeDelete: true);
            DropColumn("dbo.Mobiles", "Brand");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mobiles", "Brand", c => c.String());
            DropForeignKey("dbo.Mobiles", "BrandID", "dbo.Brands");
            DropIndex("dbo.Mobiles", new[] { "BrandID" });
            DropColumn("dbo.Mobiles", "BrandID");
        }
    }
}
