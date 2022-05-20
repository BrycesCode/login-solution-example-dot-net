namespace LoginSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfoModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        userName = c.String(nullable: false),
                        password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserInfoModels");
        }
    }
}
