namespace WebApplication1_MVC_country_city_state_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbdatacityctst : DbMigration
    {
        public override void Up()
        {
            Sql("insert Countries values('India')");
            Sql("insert Countries values('UK')");
            Sql("insert Countries values('UP')");

            Sql("insert States values('HP',1)");
            Sql("insert States values('Punjab',1)");
            Sql("insert States values('Mandi',1)");

            Sql("insert Cities values('Kangra',1)");
            Sql("insert Cities values('Dharamshal',1)");
            Sql("insert cities values('Mohali',2)");
            Sql("insert Cities values('chd',2)");
            Sql("insert Cities values('Kharar',2)");
            Sql("insert Cities values('SASN',2)");

        }
        
        public override void Down()
        {
        }
    }
}
