namespace KadetServiceProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pracownicy", "Pesel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pracownicy", "Pesel");
        }
    }
}
