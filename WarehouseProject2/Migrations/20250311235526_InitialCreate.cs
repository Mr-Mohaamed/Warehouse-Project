using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseProject2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    C_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Site = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.C_ID);
                });

            migrationBuilder.CreateTable(
                name: "MeasuringUnits",
                columns: table => new
                {
                    MU_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MU_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MU_ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MU_Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasuringUnits", x => x.MU_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    P_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_Type = table.Column<int>(type: "int", nullable: false),
                    P_MU = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.P_ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    S_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Site = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.S_ID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    W_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    W_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    W_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.W_ID);
                });

            migrationBuilder.CreateTable(
                name: "Product_MeasuringUnits",
                columns: table => new
                {
                    P_ID = table.Column<int>(type: "int", nullable: false),
                    MU_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_MeasuringUnits", x => new { x.P_ID, x.MU_ID });
                    table.ForeignKey(
                        name: "FK_Product_MeasuringUnits_MeasuringUnits_MU_ID",
                        column: x => x.MU_ID,
                        principalTable: "MeasuringUnits",
                        principalColumn: "MU_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_MeasuringUnits_Products_P_ID",
                        column: x => x.P_ID,
                        principalTable: "Products",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderIns",
                columns: table => new
                {
                    O_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_ID = table.Column<int>(type: "int", nullable: false),
                    W_ID = table.Column<int>(type: "int", nullable: false),
                    O_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderIns", x => x.O_ID);
                    table.ForeignKey(
                        name: "FK_OrderIns_Suppliers_S_ID",
                        column: x => x.S_ID,
                        principalTable: "Suppliers",
                        principalColumn: "S_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderIns_Warehouses_W_ID",
                        column: x => x.W_ID,
                        principalTable: "Warehouses",
                        principalColumn: "W_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderOuts",
                columns: table => new
                {
                    O_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    O_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C_ID = table.Column<int>(type: "int", nullable: false),
                    W_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderOuts", x => x.O_ID);
                    table.ForeignKey(
                        name: "FK_OrderOuts_Customers_C_ID",
                        column: x => x.C_ID,
                        principalTable: "Customers",
                        principalColumn: "C_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderOuts_Warehouses_W_ID",
                        column: x => x.W_ID,
                        principalTable: "Warehouses",
                        principalColumn: "W_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_Warehouses",
                columns: table => new
                {
                    P_ID = table.Column<int>(type: "int", nullable: false),
                    W_ID = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Warehouses", x => new { x.W_ID, x.P_ID, x.ExpiryDate });
                    table.ForeignKey(
                        name: "FK_Product_Warehouses_Products_P_ID",
                        column: x => x.P_ID,
                        principalTable: "Products",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Warehouses_Warehouses_W_ID",
                        column: x => x.W_ID,
                        principalTable: "Warehouses",
                        principalColumn: "W_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransferOrderIns",
                columns: table => new
                {
                    O_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    O_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceWarehouse_ID = table.Column<int>(type: "int", nullable: false),
                    TargetWarehouse_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferOrderIns", x => x.O_ID);
                    table.ForeignKey(
                        name: "FK_TransferOrderIns_Warehouses_SourceWarehouse_ID",
                        column: x => x.SourceWarehouse_ID,
                        principalTable: "Warehouses",
                        principalColumn: "W_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferOrderIns_Warehouses_TargetWarehouse_ID",
                        column: x => x.TargetWarehouse_ID,
                        principalTable: "Warehouses",
                        principalColumn: "W_ID");
                });

            migrationBuilder.CreateTable(
                name: "TransferOrderOuts",
                columns: table => new
                {
                    O_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    O_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceWarehouse_ID = table.Column<int>(type: "int", nullable: false),
                    TargetWarehouse_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferOrderOuts", x => x.O_ID);
                    table.ForeignKey(
                        name: "FK_TransferOrderOuts_Warehouses_SourceWarehouse_ID",
                        column: x => x.SourceWarehouse_ID,
                        principalTable: "Warehouses",
                        principalColumn: "W_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferOrderOuts_Warehouses_TargetWarehouse_ID",
                        column: x => x.TargetWarehouse_ID,
                        principalTable: "Warehouses",
                        principalColumn: "W_ID");
                });

            migrationBuilder.CreateTable(
                name: "Product_OrderIns",
                columns: table => new
                {
                    P_ID = table.Column<int>(type: "int", nullable: false),
                    O_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_OrderIns", x => new { x.O_ID, x.P_ID });
                    table.ForeignKey(
                        name: "FK_Product_OrderIns_OrderIns_O_ID",
                        column: x => x.O_ID,
                        principalTable: "OrderIns",
                        principalColumn: "O_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_OrderIns_Products_P_ID",
                        column: x => x.P_ID,
                        principalTable: "Products",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_OrderOuts",
                columns: table => new
                {
                    O_ID = table.Column<int>(type: "int", nullable: false),
                    P_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_OrderOuts", x => new { x.O_ID, x.P_ID });
                    table.ForeignKey(
                        name: "FK_Product_OrderOuts_OrderOuts_O_ID",
                        column: x => x.O_ID,
                        principalTable: "OrderOuts",
                        principalColumn: "O_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_OrderOuts_Products_P_ID",
                        column: x => x.P_ID,
                        principalTable: "Products",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_TransferOrderIns",
                columns: table => new
                {
                    O_ID = table.Column<int>(type: "int", nullable: false),
                    P_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_TransferOrderIns", x => new { x.O_ID, x.P_ID });
                    table.ForeignKey(
                        name: "FK_Product_TransferOrderIns_Products_P_ID",
                        column: x => x.P_ID,
                        principalTable: "Products",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_TransferOrderIns_TransferOrderIns_O_ID",
                        column: x => x.O_ID,
                        principalTable: "TransferOrderIns",
                        principalColumn: "O_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_TransferOrderOuts",
                columns: table => new
                {
                    P_ID = table.Column<int>(type: "int", nullable: false),
                    O_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_TransferOrderOuts", x => new { x.O_ID, x.P_ID });
                    table.ForeignKey(
                        name: "FK_Product_TransferOrderOuts_Products_P_ID",
                        column: x => x.P_ID,
                        principalTable: "Products",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_TransferOrderOuts_TransferOrderOuts_O_ID",
                        column: x => x.O_ID,
                        principalTable: "TransferOrderOuts",
                        principalColumn: "O_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderIns_S_ID",
                table: "OrderIns",
                column: "S_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderIns_W_ID",
                table: "OrderIns",
                column: "W_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderOuts_C_ID",
                table: "OrderOuts",
                column: "C_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderOuts_W_ID",
                table: "OrderOuts",
                column: "W_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MeasuringUnits_MU_ID",
                table: "Product_MeasuringUnits",
                column: "MU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderIns_P_ID",
                table: "Product_OrderIns",
                column: "P_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderOuts_P_ID",
                table: "Product_OrderOuts",
                column: "P_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_TransferOrderIns_P_ID",
                table: "Product_TransferOrderIns",
                column: "P_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_TransferOrderOuts_P_ID",
                table: "Product_TransferOrderOuts",
                column: "P_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Warehouses_P_ID",
                table: "Product_Warehouses",
                column: "P_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TransferOrderIns_SourceWarehouse_ID",
                table: "TransferOrderIns",
                column: "SourceWarehouse_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TransferOrderIns_TargetWarehouse_ID",
                table: "TransferOrderIns",
                column: "TargetWarehouse_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TransferOrderOuts_SourceWarehouse_ID",
                table: "TransferOrderOuts",
                column: "SourceWarehouse_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TransferOrderOuts_TargetWarehouse_ID",
                table: "TransferOrderOuts",
                column: "TargetWarehouse_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_MeasuringUnits");

            migrationBuilder.DropTable(
                name: "Product_OrderIns");

            migrationBuilder.DropTable(
                name: "Product_OrderOuts");

            migrationBuilder.DropTable(
                name: "Product_TransferOrderIns");

            migrationBuilder.DropTable(
                name: "Product_TransferOrderOuts");

            migrationBuilder.DropTable(
                name: "Product_Warehouses");

            migrationBuilder.DropTable(
                name: "MeasuringUnits");

            migrationBuilder.DropTable(
                name: "OrderIns");

            migrationBuilder.DropTable(
                name: "OrderOuts");

            migrationBuilder.DropTable(
                name: "TransferOrderIns");

            migrationBuilder.DropTable(
                name: "TransferOrderOuts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
