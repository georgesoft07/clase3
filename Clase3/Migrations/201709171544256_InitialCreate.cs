namespace Clase3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        FechaNacimiento = c.DateTime(),
                        Nacionalidad = c.String(),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Edicion = c.Int(nullable: false),
                        Genero = c.String(),
                        AutorId = c.Int(nullable: false),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Autor", t => t.AutorId, cascadeDelete: true)
                .Index(t => t.AutorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Libro", "AutorId", "dbo.Autor");
            DropIndex("dbo.Libro", new[] { "AutorId" });
            DropTable("dbo.Libro");
            DropTable("dbo.Autor");
        }
    }
}
