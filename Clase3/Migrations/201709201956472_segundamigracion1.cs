namespace Clase3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segundamigracion1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Autor", "edad", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Autor", "edad", c => c.String());
        }
    }
}
