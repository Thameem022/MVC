namespace MVC_Training1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedStore : DbMigration
    {
        public override void Up()
        {
            {
                Sql("SET IDENTITY_INSERT StoreModels ON");
                Sql("INSERT INTO StoreModels (Id, Name, Url, Price) Values (2,'Mug','C:\\Users\\mthameem\\Pictures\\AWS-eRollcall\\Analysis.png',300)");
                Sql("INSERT INTO StoreModels (Id, Name, Url, Price) Values (3,'Kite','C:\\Users\\mthameem\\Pictures\\AWS-eRollcall\\Analysis.png',400)");

            }
        }
        
        public override void Down()
        {
        }
    }
}
