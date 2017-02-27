namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("insert into membershiptypes (id,signupfee,durationinmonths,discountrate) values (1,0,0,0)");
            Sql("insert into membershiptypes (id,signupfee,durationinmonths,discountrate) values (2,30,1,10)");
            Sql("insert into membershiptypes (id,signupfee,durationinmonths,discountrate) values (3,90,3,15)");
            Sql("insert into membershiptypes (id,signupfee,durationinmonths,discountrate) values (4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
