namespace VSTDA.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoes",
                c => new
                    {
                        ToDoEntryId = c.Int(nullable: false, identity: true),
                        ToDoItem = c.String(),
                        Priority = c.String(),
                    })
                .PrimaryKey(t => t.ToDoEntryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoes");
        }
    }
}
