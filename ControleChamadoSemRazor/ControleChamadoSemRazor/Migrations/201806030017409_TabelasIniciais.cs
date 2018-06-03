namespace ControleChamadoSemRazor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chamadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeDoSistema = c.String(),
                        ModuloDoSistema = c.String(),
                        DescricaoDoSistema = c.String(),
                        Criticidade = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chamadoes", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Chamadoes", new[] { "UsuarioId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Chamadoes");
        }
    }
}
