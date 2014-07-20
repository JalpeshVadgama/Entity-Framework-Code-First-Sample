using System.Data.Entity.Migrations;

namespace EntityCodeFirstMigrations.Migration
{
    public partial class AddCompanyField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Company", c => c.String());
        }
        public override void Down()
        {
            DropColumn("dbo.Customers", "Company");
            base.Down();
        }
    }
}
