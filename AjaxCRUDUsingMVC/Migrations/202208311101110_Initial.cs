namespace AjaxCRUDUsingMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.emp",
                c => new
                    {
                        empid = c.Int(nullable: false, identity: true),
                        empname = c.String(nullable: false),
                        email = c.String(nullable: false),
                        salary = c.Int(nullable: false),
                        managername = c.String(nullable: false),
                        telephonenumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.empid);
            
        }
        
        public override void Down()
        {
            DropTable("public.emp");
        }
    }
}
