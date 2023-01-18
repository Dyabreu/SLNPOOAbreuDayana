namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avion",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Denominacion = c.String(),
                        LineaAerea_IdLinea = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAvion)
                .ForeignKey("dbo.LineaAereas", t => t.LineaAerea_IdLinea, cascadeDelete: true)
                .Index(t => t.LineaAerea_IdLinea);
            
            CreateTable(
                "dbo.LineaAereas",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "LineaAerea_IdLinea", "dbo.LineaAereas");
            DropIndex("dbo.Avion", new[] { "LineaAerea_IdLinea" });
            DropTable("dbo.LineaAereas");
            DropTable("dbo.Avion");
        }
    }
}
