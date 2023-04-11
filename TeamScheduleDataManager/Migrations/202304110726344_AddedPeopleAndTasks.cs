namespace TeamScheduleDataManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPeopleAndTasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false),
                        LName = c.String(nullable: false),
                        PinCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        DeadLine = c.DateTime(nullable: false),
                        IsDone = c.Boolean(nullable: false),
                        Description = c.String(),
                        NextPerformer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.NextPerformer_Id)
                .Index(t => t.NextPerformer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "NextPerformer_Id", "dbo.People");
            DropIndex("dbo.Tasks", new[] { "NextPerformer_Id" });
            DropTable("dbo.Tasks");
            DropTable("dbo.People");
        }
    }
}
