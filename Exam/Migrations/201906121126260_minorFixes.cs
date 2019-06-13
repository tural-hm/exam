namespace Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class minorFixes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ders", "Kod", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Ders", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Ders", "TeacherName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Ders", "TeacherSurname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Imtahan", "Kod", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Sagird", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Sagird", "Surname", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sagird", "Surname", c => c.String());
            AlterColumn("dbo.Sagird", "Name", c => c.String());
            AlterColumn("dbo.Imtahan", "Kod", c => c.Int(nullable: false));
            AlterColumn("dbo.Ders", "TeacherSurname", c => c.String());
            AlterColumn("dbo.Ders", "TeacherName", c => c.String());
            AlterColumn("dbo.Ders", "Name", c => c.String());
            AlterColumn("dbo.Ders", "Kod", c => c.String());
        }
    }
}
