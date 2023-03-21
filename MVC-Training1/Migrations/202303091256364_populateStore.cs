namespace MVC_Training1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateStore : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT StoreModels ON");
            Sql("INSERT INTO StoreModels (id, name, url, price) Values (1,'Jar','C:\\Users\\mthameem\\Pictures\\AWS-eRollcall\\Analysis.png',200)");
            Sql("DELETE FROM StoreModels WHERE id=1;");

        }

        public override void Down()
        {
        }
    }
}
