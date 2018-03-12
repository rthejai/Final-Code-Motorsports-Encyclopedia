namespace MotorsportsEncyclopedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtest2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollment", "CarID", "dbo.Car");
            DropForeignKey("dbo.Enrollment", "TrackID", "dbo.Track");
            DropForeignKey("dbo.Company", "TeacherID", "dbo.Person");
            DropIndex("dbo.Enrollment", new[] { "TrackID" });
            DropIndex("dbo.Enrollment", new[] { "CarID" });
            DropIndex("dbo.Company", new[] { "TeacherID" });
            AlterColumn("dbo.Enrollment", "TrackID", c => c.Int(nullable: false));
            AlterColumn("dbo.Enrollment", "CarID", c => c.Int(nullable: false));
            AlterColumn("dbo.Company", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Company", "TeacherID", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollment", "TrackID");
            CreateIndex("dbo.Enrollment", "CarID");
            CreateIndex("dbo.Company", "TeacherID");
            AddForeignKey("dbo.Enrollment", "CarID", "dbo.Car", "CarID", cascadeDelete: true);
            AddForeignKey("dbo.Enrollment", "TrackID", "dbo.Track", "TrackID", cascadeDelete: true);
            AddForeignKey("dbo.Company", "TeacherID", "dbo.Person", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Company", "TeacherID", "dbo.Person");
            DropForeignKey("dbo.Enrollment", "TrackID", "dbo.Track");
            DropForeignKey("dbo.Enrollment", "CarID", "dbo.Car");
            DropIndex("dbo.Company", new[] { "TeacherID" });
            DropIndex("dbo.Enrollment", new[] { "CarID" });
            DropIndex("dbo.Enrollment", new[] { "TrackID" });
            AlterColumn("dbo.Company", "TeacherID", c => c.Int());
            AlterColumn("dbo.Company", "StartDate", c => c.DateTime());
            AlterColumn("dbo.Enrollment", "CarID", c => c.Int());
            AlterColumn("dbo.Enrollment", "TrackID", c => c.Int());
            CreateIndex("dbo.Company", "TeacherID");
            CreateIndex("dbo.Enrollment", "CarID");
            CreateIndex("dbo.Enrollment", "TrackID");
            AddForeignKey("dbo.Company", "TeacherID", "dbo.Person", "ID");
            AddForeignKey("dbo.Enrollment", "TrackID", "dbo.Track", "TrackID");
            AddForeignKey("dbo.Enrollment", "CarID", "dbo.Car", "CarID");
        }
    }
}
