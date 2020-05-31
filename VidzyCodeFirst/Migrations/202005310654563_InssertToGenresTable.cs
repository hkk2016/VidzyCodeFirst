namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InssertToGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql(
            "INSERT[dbo].[Genres] ([Id], [Name]) VALUES (1, N'Comedy')" +
            "INSERT[dbo].[Genres]([Id], [Name]) VALUES(2, N'Action')" +
            "INSERT[dbo].[Genres]([Id], [Name]) VALUES(3, N'Horror')" +
            "INSERT[dbo].[Genres]([Id], [Name]) VALUES(4, N'Thriller')" +
            "INSERT[dbo].[Genres]([Id], [Name]) VALUES(5, N'Family')" +
            "INSERT[dbo].[Genres]([Id], [Name]) VALUES(6, N'Romance')");
        }   
        public override void Down()
        {

        }
    }
}
