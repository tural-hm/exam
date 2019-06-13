namespace Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imtahan", "Sagird_id", c => c.Int());
            CreateIndex("dbo.Imtahan", "Sagird_id");
            AddForeignKey("dbo.Imtahan", "Sagird_id", "dbo.Sagird", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Imtahan", "Sagird_id", "dbo.Sagird");
            DropIndex("dbo.Imtahan", new[] { "Sagird_id" });
            DropColumn("dbo.Imtahan", "Sagird_id");
        }
    }
}
