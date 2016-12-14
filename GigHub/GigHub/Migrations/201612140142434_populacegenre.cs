namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populacegenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id, Name) Values (1, 'Jazz')");
            Sql("Insert into Genres (Id, Name) Values (2, 'BLues')");
            Sql("Insert into Genres (Id, Name) Values (3, 'Rock')");
            Sql("Insert into Genres (Id, Name) Values (4, 'Country')");
        }

        public override void Down()
        {
            Sql("Delete from Genres where Id in (1,2,3,4)");
        }
    }
}
