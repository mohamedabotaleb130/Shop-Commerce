using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class CartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shoppingcart",
                schema: "Identity",
                columns: table => new
                {
                    shoppingCartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    shoppingcartItemId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingcart", x => x.shoppingCartId);
                    table.ForeignKey(
                        name: "FK_shoppingcart_products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Identity",
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shoppingcart_ProductId",
                schema: "Identity",
                table: "shoppingcart",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoppingcart",
                schema: "Identity");
        }
    }
}
