using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gifts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Origins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Year = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<string>(type: "text", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    CarType = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<decimal>(type: "numeric", nullable: true),
                    Leight_Width_height = table.Column<string>(type: "text", nullable: true),
                    SupplierId = table.Column<int>(type: "integer", nullable: true),
                    BrandId = table.Column<int>(type: "integer", nullable: true),
                    CarTypeId = table.Column<int>(type: "integer", nullable: true),
                    OriginId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Origins_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Origins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AddressToShips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressLine = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressToShips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressToShips_Accounts_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    ImageBlogId = table.Column<string>(type: "text", nullable: true),
                    CarId = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<string>(type: "text", nullable: true),
                    AccountId1 = table.Column<int>(type: "integer", nullable: true),
                    CarId1 = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Blogs_Cars_CarId1",
                        column: x => x.CarId1,
                        principalTable: "Cars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", nullable: true),
                    CustomerId = table.Column<int>(type: "integer", nullable: true),
                    CarId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Accounts_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cart_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GiftCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", nullable: true),
                    CarId = table.Column<int>(type: "integer", nullable: true),
                    GiftId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiftCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GiftCars_Gifts_GiftId",
                        column: x => x.GiftId,
                        principalTable: "Gifts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<int>(type: "integer", nullable: true),
                    AddressToShipId = table.Column<int>(type: "integer", nullable: true),
                    PaymentMethodId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Accounts_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_AddressToShips_AddressToShipId",
                        column: x => x.AddressToShipId,
                        principalTable: "AddressToShips",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImageBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImageLink = table.Column<string>(type: "text", nullable: true),
                    BlogId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageBlogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageBlogs_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImageCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImageLink = table.Column<string>(type: "text", nullable: true),
                    CarId = table.Column<int>(type: "integer", nullable: true),
                    StageId = table.Column<int>(type: "integer", nullable: false),
                    CartId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ImageCars_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ImageCars_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurrentPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: true),
                    Tax = table.Column<decimal>(type: "numeric", nullable: true),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    CarId = table.Column<int>(type: "integer", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificationBy = table.Column<int>(type: "integer", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeleteBy = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RoleId",
                table: "Accounts",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressToShips_CustomerId",
                table: "AddressToShips",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AccountId1",
                table: "Blogs",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CarId1",
                table: "Blogs",
                column: "CarId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_OriginId",
                table: "Cars",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_SupplierId",
                table: "Cars",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CarId",
                table: "Cart",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustomerId",
                table: "Cart",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GiftCars_CarId",
                table: "GiftCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_GiftCars_GiftId",
                table: "GiftCars",
                column: "GiftId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageBlogs_BlogId",
                table: "ImageBlogs",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCars_CarId",
                table: "ImageCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCars_CartId",
                table: "ImageCars",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCars_StageId",
                table: "ImageCars",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CarId",
                table: "OrderDetails",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressToShipId",
                table: "Orders",
                column: "AddressToShipId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiftCars");

            migrationBuilder.DropTable(
                name: "ImageBlogs");

            migrationBuilder.DropTable(
                name: "ImageCars");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Gifts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Stages");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "AddressToShips");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Origins");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
