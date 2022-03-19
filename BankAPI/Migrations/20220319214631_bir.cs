using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankAPI.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddressDetail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    AddressID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_AddressID1",
                        column: x => x.AddressID1,
                        principalTable: "Addresses",
                        principalColumn: "AddressID");
                });

            migrationBuilder.CreateTable(
                name: "CustumerOrders",
                columns: table => new
                {
                    CustomerOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustumerOrders", x => x.CustomerOrderId);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustumerOrders_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "AddressDetail", "AddressName", "CustomerID" },
                values: new object[,]
                {
                    { 1, "Menekşe Mah. Petek Sk. No:31 Kat:3 Daire:5", "Home", 1 },
                    { 3, "Eskiler Cad. Fırın Sk. No:38 Pendik", "Work", 2 },
                    { 4, "Yedi İklim Mah. Güngören Cad. Lacivert Sk. No:45 Kat:3 Daire:7", "Work2", 3 },
                    { 5, "Çakmak Cad. Turgut Özal Sk. No:16 Kat:1 Daire:13", "MomHome", 4 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "AddressID", "AddressID1", "Name" },
                values: new object[,]
                {
                    { 1, 1, null, "Ahmet" },
                    { 2, 3, null, "Veli" },
                    { 3, 4, null, "Efe" },
                    { 4, 5, null, "Orhan" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Barcode", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "11122233344", "Toy", 33, "teddy bear" },
                    { 2, "21295395534", "Home equipment", 26, "lamp" },
                    { 3, "21278000004", "Garden equipment", 13, "fork" },
                    { 4, "53501612766", "Bathroom equipment", 15, "toilet paper" }
                });

            migrationBuilder.InsertData(
                table: "CustumerOrders",
                columns: new[] { "CustomerOrderId", "CustomerID", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 3 },
                    { 2, 3, 4, 5 },
                    { 3, 4, 4, 2 },
                    { 4, 1, 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressID1",
                table: "Customers",
                column: "AddressID1");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_CustomerID",
                table: "CustumerOrders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustumerOrders_ProductID",
                table: "CustumerOrders",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustumerOrders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
