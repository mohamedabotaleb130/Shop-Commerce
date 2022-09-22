using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("	INSERT INTO [Identity].[UserRoles] (UserId, RoleId) SELECT 'b191a840-2fc5-4609-b279-f96037758940', Id FROM [Identity].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Identity].[UserRoles] WHERE UserId = 'b191a840-2fc5-4609-b279-f96037758940'");
        }
    }
}
