namespace OnlineMobileShop.Respository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mobilev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.BrandID)
                .Index(t => t.BrandName, unique: true);
            
            CreateTable(
                "dbo.Mobiles",
                c => new
                    {
                        MobileID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        Battery = c.Int(nullable: false),
                        RAM = c.Int(nullable: false),
                        ROM = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MobileID);
            
            CreateStoredProcedure(
                "dbo.Brand_Insert",
                p => new
                    {
                        BrandName = p.String(maxLength: 15),
                    },
                body:
                    @"INSERT [dbo].[Brands]([BrandName])
                      VALUES (@BrandName)
                      
                      DECLARE @BrandID int
                      SELECT @BrandID = [BrandID]
                      FROM [dbo].[Brands]
                      WHERE @@ROWCOUNT > 0 AND [BrandID] = scope_identity()
                      
                      SELECT t0.[BrandID]
                      FROM [dbo].[Brands] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[BrandID] = @BrandID"
            );
            
            CreateStoredProcedure(
                "dbo.Brand_Update",
                p => new
                    {
                        BrandID = p.Int(),
                        BrandName = p.String(maxLength: 15),
                    },
                body:
                    @"UPDATE [dbo].[Brands]
                      SET [BrandName] = @BrandName
                      WHERE ([BrandID] = @BrandID)"
            );
            
            CreateStoredProcedure(
                "dbo.Brand_Delete",
                p => new
                    {
                        BrandID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Brands]
                      WHERE ([BrandID] = @BrandID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Brand_Delete");
            DropStoredProcedure("dbo.Brand_Update");
            DropStoredProcedure("dbo.Brand_Insert");
            DropIndex("dbo.Brands", new[] { "BrandName" });
            DropTable("dbo.Mobiles");
            DropTable("dbo.Brands");
        }
    }
}
