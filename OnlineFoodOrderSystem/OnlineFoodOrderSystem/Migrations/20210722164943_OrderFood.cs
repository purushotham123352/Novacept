using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineFoodOrderSystem.Migrations
{
    public partial class OrderFood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    FirstName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Mobile = table.Column<long>(type: "Bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Userid);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customerid = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    lastName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<long>(type: "Bigint", nullable: false),
                    Password = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customerid);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Menuid = table.Column<int>(type: "int", nullable: false),
                    MenuName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal", nullable: false),
                    FoodCategory = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Menuid);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Orderid = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal", nullable: false),
                    Customerid = table.Column<int>(type: "int", nullable: false),
                    OrderStatus = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Orderid);
                    table.ForeignKey(
                        name: "FK_Order_Customer_Customerid",
                        column: x => x.Customerid,
                        principalTable: "Customer",
                        principalColumn: "Customerid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Orderid = table.Column<int>(type: "int", nullable: false),
                    Menuid = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal", nullable: false),
                    NoofServing = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Orderid);
                    table.ForeignKey(
                        name: "FK_OrderItem_Menu_Menuid",
                        column: x => x.Menuid,
                        principalTable: "Menu",
                        principalColumn: "Menuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_Orderid",
                        column: x => x.Orderid,
                        principalTable: "Order",
                        principalColumn: "Orderid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Paymentid = table.Column<int>(type: "int", nullable: false),
                    Orderid = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal", nullable: false),
                    PaidBy = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Paymentid);
                    table.ForeignKey(
                        name: "FK_Payment_Order_Orderid",
                        column: x => x.Orderid,
                        principalTable: "Order",
                        principalColumn: "Orderid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Customerid",
                table: "Order",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_Menuid",
                table: "OrderItem",
                column: "Menuid");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Orderid",
                table: "Payment",
                column: "Orderid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
