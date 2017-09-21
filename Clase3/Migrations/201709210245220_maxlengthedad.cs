namespace Clase3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maxlengthedad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Autor", "edad", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Autor", "edad", c => c.String());
        }
    }
}
