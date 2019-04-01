namespace GestionDesTickets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class misUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Sexe", c => c.String());
            DropColumn("dbo.AspNetUsers", "UserSexe");
            DropColumn("dbo.AspNetUsers", "Groupe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Groupe", c => c.String());
            AddColumn("dbo.AspNetUsers", "UserSexe", c => c.String());
            DropColumn("dbo.AspNetUsers", "Sexe");
        }
    }
}
