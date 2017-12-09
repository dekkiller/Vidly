namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Romantic')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Anime')");
        }
        
        public override void Down()
        {
        }
    }
}
