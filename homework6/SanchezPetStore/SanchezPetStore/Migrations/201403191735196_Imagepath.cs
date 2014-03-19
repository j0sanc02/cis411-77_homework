namespace SanchezPetStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Imagepath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Imagepath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "Imagepath");
        }
    }
}
