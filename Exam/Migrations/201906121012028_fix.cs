namespace Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Imtahan", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imtahan", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
