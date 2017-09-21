namespace Clase3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segundamigracion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autor", "edad", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Autor", "edad");
        }
    }
}
