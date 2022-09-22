using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Identity].[Users] ([Id], [FirstName], [LastName], [UsernameChangeLimit], [ProfilePicture], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b191a840-2fc5-4609-b279-f96037758940', N'Mohamed', N'Abotaleb', 10, NULL, N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 1, N'AQAAAAEAACcQAAAAEPvk48VxxgXMaS8wX/NJ4uihv7oRPA2lBwmX9BG5ooJYwru4MqyFKz7ZkPki/Ku78w==', N'YNFY23IGDDJA7KG2NELAJSNMCM3YAFNN', N'acf6f75b-e544-4c7b-aa6e-06a62eeef3b6', NULL, 0, 0, NULL, 1, 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Identity].[Users] WHERE Id = 'b191a840-2fc5-4609-b279-f96037758940'");
        }
    }
}
