namespace Clase3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categorias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoriaLibro",
                c => new
                    {
                        Categoria_Id = c.Int(nullable: false),
                        Libro_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Categoria_Id, t.Libro_Id })
                .ForeignKey("dbo.Categoria", t => t.Categoria_Id, cascadeDelete: true)
                .ForeignKey("dbo.Libro", t => t.Libro_Id, cascadeDelete: true)
                .Index(t => t.Categoria_Id)
                .Index(t => t.Libro_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoriaLibro", "Libro_Id", "dbo.Libro");
            DropForeignKey("dbo.CategoriaLibro", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.CategoriaLibro", new[] { "Libro_Id" });
            DropIndex("dbo.CategoriaLibro", new[] { "Categoria_Id" });
            DropTable("dbo.CategoriaLibro");
            DropTable("dbo.Categoria");
        }
    }
}
