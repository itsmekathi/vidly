namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InsertedDataIntoGenreAndMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(Type) VALUES('Comedy')");
            Sql("Insert into Genres(Type) VALUES('Action')");
            Sql("Insert into Genres(Type) VALUES('Drama')");
            Sql("Insert into Genres(Type) VALUES('Tragedy')");
            Sql("Insert into Genres(Type) VALUES('Fantasy')");
            Sql("Insert into Genres(Type) VALUES('Mythology')");
            Sql("Insert into Genres(Type) VALUES('Adventure')");
            Sql("Insert into Genres(Type) VALUES('Mystery')");
            Sql("Insert into Genres(Type) VALUES('Science fiction')");
            Sql("Insert into Genres(Type) VALUES('Drama')");
            Sql("Insert into Genres(Type) VALUES('Romance')");
            Sql("Insert into Genres(Type) VALUES('Horror')");

            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreID) VALUES('Die Hard 1','2002-02-01','2008-01-01',10,2)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreID) VALUES('Avatar','2009-02-01','2010-01-01',5,7)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreID) VALUES('Armagedron','2001-02-01','2008-01-01',10,2)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreID) VALUES('Blood Diamond','2005-02-01','2011-01-01',25,2)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreID) VALUES('A walk to remember','2001-02-01','2008-01-01',20,2)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreID) VALUES('The Conjuring 1','2010-02-01','2015-01-01',10,12)");
        }
        public override void Down()
        {
        }
    }
}
