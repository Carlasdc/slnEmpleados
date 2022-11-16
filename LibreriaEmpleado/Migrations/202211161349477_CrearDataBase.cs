namespace LibreriaEmpleado.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        Legajo = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Departamento_DepartamentoId = c.Int(),
                    })
                .PrimaryKey(t => t.EmpleadoId)
                .ForeignKey("dbo.Departamentoes", t => t.Departamento_DepartamentoId)
                .Index(t => t.Departamento_DepartamentoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleadoes", "Departamento_DepartamentoId", "dbo.Departamentoes");
            DropIndex("dbo.Empleadoes", new[] { "Departamento_DepartamentoId" });
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Departamentoes");
        }
    }
}
