using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CellphoneStore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    brand_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.brand_ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categories_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categories_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categories_ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_Name = table.Column<string>(nullable: false),
                    customer_PhoneNumber = table.Column<string>(nullable: false),
                    customer_Email = table.Column<string>(nullable: false),
                    customer_AddressShip1 = table.Column<string>(nullable: false),
                    customer_AddressShip2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryCosts",
                columns: table => new
                {
                    deliverycost_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deliverycost_AreaName = table.Column<string>(nullable: false),
                    deliverycost_Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryCosts", x => x.deliverycost_ID);
                });

            migrationBuilder.CreateTable(
                name: "HeDieuHanhs",
                columns: table => new
                {
                    hdh_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hdh_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeDieuHanhs", x => x.hdh_ID);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    promotion_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    promotion_Name = table.Column<string>(nullable: true),
                    promotion_Percent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.promotion_ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    supplier_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplier_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.supplier_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    order_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_CreateOnDay = table.Column<DateTime>(nullable: false),
                    order_Total = table.Column<decimal>(nullable: false),
                    order_PaymentDate = table.Column<DateTime>(nullable: false),
                    order_PaymentMethod = table.Column<string>(nullable: true),
                    customer_ID = table.Column<int>(nullable: true),
                    deliverycost_ID = table.Column<int>(nullable: true),
                    promotion_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.order_ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_customer_ID",
                        column: x => x.customer_ID,
                        principalTable: "Customers",
                        principalColumn: "customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_DeliveryCosts_deliverycost_ID",
                        column: x => x.deliverycost_ID,
                        principalTable: "DeliveryCosts",
                        principalColumn: "deliverycost_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Promotions_promotion_ID",
                        column: x => x.promotion_ID,
                        principalTable: "Promotions",
                        principalColumn: "promotion_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_Name = table.Column<string>(nullable: false),
                    product_Price = table.Column<decimal>(nullable: false),
                    product_Quantity = table.Column<int>(nullable: false),
                    product_Image = table.Column<string>(nullable: true),
                    product_Description = table.Column<string>(nullable: true),
                    brand_ID = table.Column<int>(nullable: true),
                    hdh_ID = table.Column<int>(nullable: true),
                    supplier_ID = table.Column<int>(nullable: true),
                    categories_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_ID);
                    table.ForeignKey(
                        name: "FK_Products_Brands_brand_ID",
                        column: x => x.brand_ID,
                        principalTable: "Brands",
                        principalColumn: "brand_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_categories_ID",
                        column: x => x.categories_ID,
                        principalTable: "Categories",
                        principalColumn: "categories_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_HeDieuHanhs_hdh_ID",
                        column: x => x.hdh_ID,
                        principalTable: "HeDieuHanhs",
                        principalColumn: "hdh_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_supplier_ID",
                        column: x => x.supplier_ID,
                        principalTable: "Suppliers",
                        principalColumn: "supplier_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    comment_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment_Content = table.Column<string>(nullable: true),
                    comment_CreateOnDay = table.Column<DateTime>(nullable: false),
                    product_ID = table.Column<int>(nullable: true),
                    customer_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.comment_ID);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_customer_ID",
                        column: x => x.customer_ID,
                        principalTable: "Customers",
                        principalColumn: "customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Products_product_ID",
                        column: x => x.product_ID,
                        principalTable: "Products",
                        principalColumn: "product_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    order_ID = table.Column<int>(nullable: false),
                    product_ID = table.Column<int>(nullable: false),
                    orderdetail_Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.order_ID, x.product_ID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_order_ID",
                        column: x => x.order_ID,
                        principalTable: "Orders",
                        principalColumn: "order_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_product_ID",
                        column: x => x.product_ID,
                        principalTable: "Products",
                        principalColumn: "product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "brand_ID", "brand_Name" },
                values: new object[,]
                {
                    { 1, "Apple" },
                    { 2, "Samsung" },
                    { 3, "Xiaomi" },
                    { 4, "Oppo" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categories_ID", "categories_Name" },
                values: new object[,]
                {
                    { 1, "Điện thoại" },
                    { 2, "Phụ kiện" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryCosts",
                columns: new[] { "deliverycost_ID", "deliverycost_AreaName", "deliverycost_Cost" },
                values: new object[,]
                {
                    { 6, "Miền Bắc", 100000m },
                    { 5, "Ngoại thành", 50000m },
                    { 4, "Quận 4", 30000m },
                    { 2, "Quận 2", 15000m },
                    { 1, "Quận 1", 15000m },
                    { 3, "Quận 3", 10000m }
                });

            migrationBuilder.InsertData(
                table: "HeDieuHanhs",
                columns: new[] { "hdh_ID", "hdh_Name" },
                values: new object[,]
                {
                    { 1, "iOS" },
                    { 2, "Android" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "promotion_ID", "promotion_Name", "promotion_Percent" },
                values: new object[,]
                {
                    { 1, "Giảm 10% cho sản phẩm", 10 },
                    { 2, "Giảm 15% đơn hàng", 15 },
                    { 3, "Giảm 50% cho mỗi đơn hàng", 50 }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "supplier_ID", "supplier_Name" },
                values: new object[,]
                {
                    { 1, "FPT Telecom" },
                    { 2, "Thế Giới Di Động" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_ID", "brand_ID", "categories_ID", "hdh_ID", "product_Description", "product_Image", "product_Name", "product_Price", "product_Quantity", "supplier_ID" },
                values: new object[,]
                {
                    { 1, 1, null, 1, "iPhone 11 - 64GB", "iphone-11.png", "iPhone 11", 1200m, 100, 1 },
                    { 2, 1, null, 1, "iPhone 12 - 64GB", "iphone-12.png", "iPhone 12", 1290m, 100, 1 },
                    { 3, 1, null, 1, "iPhone 12 - 64GB", "iphone-12-pro.png", "iPhone 12 Pro", 1400m, 100, 1 },
                    { 6, 3, null, 2, "Xiaomi Mi 10T Pro 64GB - New 100% fullbox", "xiaomi-mi-10t-pro.png", "Xiaomi Mi 10T Pro", 1100m, 100, 1 },
                    { 4, 2, null, 2, "Samsung Galaxy S20 - New 100% fullbox", "samsung-galaxy-s20.png", "Samsung Galaxy S20", 1350m, 100, 2 },
                    { 5, 4, null, 2, "Oppo A93 - New 100% fullbox", "oppo-a93.png", "Oppo A93", 1000m, 100, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_customer_ID",
                table: "Comments",
                column: "customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_product_ID",
                table: "Comments",
                column: "product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_product_ID",
                table: "OrderDetails",
                column: "product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customer_ID",
                table: "Orders",
                column: "customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_deliverycost_ID",
                table: "Orders",
                column: "deliverycost_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_promotion_ID",
                table: "Orders",
                column: "promotion_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_brand_ID",
                table: "Products",
                column: "brand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categories_ID",
                table: "Products",
                column: "categories_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_hdh_ID",
                table: "Products",
                column: "hdh_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_supplier_ID",
                table: "Products",
                column: "supplier_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DeliveryCosts");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "HeDieuHanhs");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
