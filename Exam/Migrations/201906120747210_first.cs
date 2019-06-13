namespace Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sagird",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nomre = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Class = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Imtahan",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MyProperty = c.Int(nullable: false),
                        Kod = c.Int(nullable: false),
                        studentCode = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Result = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Kod = c.String(),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                        TeacherName = c.String(),
                        TeacherSurname = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ders");
            DropTable("dbo.Imtahan");
            DropTable("dbo.Sagird");
        }
    }
}
