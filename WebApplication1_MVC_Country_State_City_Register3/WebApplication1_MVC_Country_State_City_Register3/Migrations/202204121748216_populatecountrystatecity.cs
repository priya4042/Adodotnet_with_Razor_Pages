namespace WebApplication1_MVC_Country_State_City_Register3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatecountrystatecity : DbMigration
    {
        public override void Up()
        {
            Sql("insert Countries values('India')");
            Sql("insert Countries values('UK')");
            Sql("insert Countries values('US')");

            Sql("insert States values('Punjab',1)");
            Sql("insert States values('Hp',1)");
            Sql("insert States values('UP',1)");

            Sql("insert Cities values('Mohali',1)");
            Sql("insert Cities values('SASN',1)");
            Sql("insert Cities values('chd',1)");
            Sql("insert Cities values('kangra',2)");
            Sql("insert Cities values('Shimla',2)");
            Sql("insert Cities values('Una',2)");

        }
        
        public override void Down()
        {
        }
    }
}
