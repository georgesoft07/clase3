namespace Clase3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class terceramigracion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autor", "peso", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Autor", "peso");
        }
    }
}
