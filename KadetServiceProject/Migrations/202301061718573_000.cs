namespace KadetServiceProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _000 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pracownicy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Numer = c.String(),
                        Email = c.String(),
                        Haslo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pracownicy");
        }
    }
}
