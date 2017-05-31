namespace VSTDA.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ToDoes", "Priority", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ToDoes", "Priority", c => c.String());
        }
    }
}
