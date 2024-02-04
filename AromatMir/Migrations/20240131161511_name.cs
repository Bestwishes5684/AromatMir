using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AromatMir.Migrations
{
    public partial class name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PickupPoint",
                columns: table => new
                {
                    Id_PickupPoint = table.Column<int>(nullable: false),
                    MailIndex_PickupPoint = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    City_PickupPoint = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Street_PickupPoint = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    NumberHouse_PickupPoint = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PikupPoint_1", x => x.Id_PickupPoint);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductArticleNumber = table.Column<string>(maxLength: 100, nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: false),
                    ProductCategory = table.Column<string>(nullable: false),
                    ProductPhoto = table.Column<byte[]>(type: "image", nullable: false),
                    ProductManufacturer = table.Column<string>(nullable: false),
                    ProductCost = table.Column<decimal>(type: "decimal(19, 4)", nullable: false),
                    ProductDiscountAmount = table.Column<decimal>(nullable: true),
                    ProductQuantityInStock = table.Column<int>(nullable: false),
                    ProductStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product__2EA7DCD544241CD6", x => x.ProductArticleNumber);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheOrder = table.Column<string>(nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrderDeliveryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrderPickupPoint = table.Column<int>(nullable: false),
                    FioClient = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Code_Give = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    OrderStatus = table.Column<bool>(unicode: false, maxLength: 50, nullable: false),
                    CountOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_PikupPoint",
                        column: x => x.OrderPickupPoint,
                        principalTable: "PickupPoint",
                        principalColumn: "Id_PickupPoint",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserSurname = table.Column<string>(maxLength: 100, nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    UserPatronymic = table.Column<string>(maxLength: 100, nullable: false),
                    UserLogin = table.Column<string>(nullable: false),
                    UserPassword = table.Column<string>(nullable: false),
                    UserRole = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__User__UserRole__4316F928",
                        column: x => x.UserRole,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    ProductArticleNumber = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderPro__817A26627323D1E6", x => new { x.OrderID, x.ProductArticleNumber });
                    table.ForeignKey(
                        name: "FK__OrderProd__Order__2D27B809",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__OrderProd__Produ__4222D4EF",
                        column: x => x.ProductArticleNumber,
                        principalTable: "Product",
                        principalColumn: "ProductArticleNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderPickupPoint",
                table: "Order",
                column: "OrderPickupPoint");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductArticleNumber",
                table: "OrderProduct",
                column: "ProductArticleNumber");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserRole",
                table: "User",
                column: "UserRole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "PickupPoint");
        }
    }
}
