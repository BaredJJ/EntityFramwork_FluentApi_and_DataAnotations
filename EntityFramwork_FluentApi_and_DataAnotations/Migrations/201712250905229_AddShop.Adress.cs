namespace EntityFramwork_FluentApi_and_DataAnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShopAdress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shops", "Adress", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shops", "Adress");
        }
    }
}
