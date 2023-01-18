namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixaviondenominacion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Avion", "LineaAerea_IdLinea", "dbo.LineaAereas");
            DropIndex("dbo.Avion", new[] { "LineaAerea_IdLinea" });
            AlterColumn("dbo.Avion", "Denominacion", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Avion", "LineaAerea_IdLinea", c => c.Int());
            CreateIndex("dbo.Avion", "LineaAerea_IdLinea");
            AddForeignKey("dbo.Avion", "LineaAerea_IdLinea", "dbo.LineaAereas", "IdLinea");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "LineaAerea_IdLinea", "dbo.LineaAereas");
            DropIndex("dbo.Avion", new[] { "LineaAerea_IdLinea" });
            AlterColumn("dbo.Avion", "LineaAerea_IdLinea", c => c.Int(nullable: false));
            AlterColumn("dbo.Avion", "Denominacion", c => c.String());
            CreateIndex("dbo.Avion", "LineaAerea_IdLinea");
            AddForeignKey("dbo.Avion", "LineaAerea_IdLinea", "dbo.LineaAereas", "IdLinea", cascadeDelete: true);
        }
    }
}
