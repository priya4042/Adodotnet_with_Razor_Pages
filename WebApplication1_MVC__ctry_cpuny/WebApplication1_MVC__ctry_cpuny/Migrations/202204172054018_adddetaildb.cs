namespace WebApplication1_MVC__ctry_cpuny.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddetaildb : DbMigration
    {
        public override void Up()
        {
            Sql("insert Countries values('India')");
            Sql("insert Countries values('US')");
            Sql("insert Countries values('UK')");
            Sql("insert States values('HP',1)");
            Sql("insert States values('Punjab',1)");
            Sql("insert States values('UP',1)");
            Sql("insert Cities values('Kangra',1)");
            Sql("insert Cities values('Shimla',1)");
            Sql("insert Cities values('Chd',2)");
            Sql("insert Cities values('Mohali',2)");
            Sql("insert Cities values('SASN',2)");

        }
        
        public override void Down()
        {
        }
    }
}
