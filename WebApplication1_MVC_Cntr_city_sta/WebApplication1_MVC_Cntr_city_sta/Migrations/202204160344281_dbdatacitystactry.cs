namespace WebApplication1_MVC_Cntr_city_sta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbdatacitystactry : DbMigration
    {
        public override void Up()
        {
            Sql("insert Countries values('India')");
            Sql("insert Countries values('UK')");
            Sql("insert Countries values('US')");

            Sql("insert States values('HP',1)");
            Sql("insert States values('Punjab',1)");
            Sql("insert States values('UP',1)");

            Sql("insert Cities values('Kangra',1)");
            Sql("insert Cities values('Shimla',1)");
            Sql("insert Cities values('Mandi',1)");
            Sql("insert Cities values ('Palampur',1)");

            Sql("insert Cities values('Chandighar',2) ");
            Sql("insert Cities values('Ludhiana',2)");

        }
        
        public override void Down()
        {
        }
    }
}
