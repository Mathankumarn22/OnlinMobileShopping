namespace OnlineMobileShop.Respository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mobilev2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.Long(nullable: false),
                        Gender = c.String(nullable: false),
                        MailID = c.String(nullable: false, maxLength: 35),
                        Password = c.String(nullable: false, maxLength: 15),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .Index(t => t.MailID, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Accounts", new[] { "MailID" });
            DropTable("dbo.Accounts");
        }
    }
}
