namespace TakeTwoVideo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Hangover', '2005-07-05', '2005-07-06', 100, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Die Hard', '1995-12-25', '1995-12-25', 6, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Pulp Fiction', '1996-06-01', '1996-07-05', 2, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Best of Times', '1981-05-01', '1991-11-11', 1, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('RomCom', '2005-07-05', '2005-07-06', 100, 4)");
        }

        public override void Down()
        {
        }
    }
}
