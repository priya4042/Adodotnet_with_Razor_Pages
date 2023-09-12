namespace WebApplication1_MVC_Register_City_State_country_rep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datainctrycitysta : DbMigration
    {
        public override void Up()
        {
            Sql("insert Countries values('India')");
            Sql("insert Countries values('Uk')");
            Sql("insert Countries values('USA')");

            Sql("insert States values('Hp',1)");
            Sql("insert States values('Up',1)");
            Sql("insert States values('Chd',1)");

            Sql("insert Cities values('Kangra',1)");
            Sql("insert Cities values('Mandi',1)");
            Sql("insert Cities values('Mohali',3)");
            Sql("insert Cities values('SASN',3)");
            Sql("insert Cities values('Ludh',3)");


        }
        
        public override void Down()
        {
        }
    }
}
