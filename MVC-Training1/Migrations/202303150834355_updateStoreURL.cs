namespace MVC_Training1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateStoreURL : DbMigration
    {
        public override void Up()
        {
            Sql("Update StoreModels set Url = '~/Content/images/jar.png' where Id = 1");
            Sql("Update StoreModels set Url = '~/Content/images/mug.png' where Id = 2");
            Sql("Update StoreModels set Url = '~/Content/images/kite.png' where Id = 3");

        }

        public override void Down()
        {
        }
    }
}
