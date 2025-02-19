using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETCORE_Lesson05.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CATEGORY__3214EC27BE3D03F0", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TOTAL_PRICE = table.Column<double>(type: "float", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PHONE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ORDERS__3214EC2764DF8320", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRICE = table.Column<double>(type: "float", nullable: true),
                    IMAGES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CATEGORY_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCT__3214EC27EC2555FB", x => x.ID);
                    table.ForeignKey(
                        name: "FK__PRODUCT__CATEGOR__1273C1CD",
                        column: x => x.CATEGORY_ID,
                        principalTable: "CATEGORY",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ORDERS_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDERS_ID = table.Column<int>(type: "int", nullable: true),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: true),
                    PRICE = table.Column<double>(type: "float", nullable: true),
                    QUANTITY = table.Column<int>(type: "int", nullable: true),
                    TOTAL_PRICE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ORDERS_D__3214EC27C9125678", x => x.ID);
                    table.ForeignKey(
                        name: "FK__ORDERS_DE__ORDER__1BFD2C07",
                        column: x => x.ORDERS_ID,
                        principalTable: "ORDERS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__ORDERS_DE__PRODU__1CF15040",
                        column: x => x.PRODUCT_ID,
                        principalTable: "PRODUCT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_DETAIL_ORDERS_ID",
                table: "ORDERS_DETAIL",
                column: "ORDERS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_DETAIL_PRODUCT_ID",
                table: "ORDERS_DETAIL",
                column: "PRODUCT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CATEGORY_ID",
                table: "PRODUCT",
                column: "CATEGORY_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDERS_DETAIL");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "CATEGORY");
        }
    }
}
