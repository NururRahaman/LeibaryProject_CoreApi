using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.CoreApi.Migrations
{
    public partial class s1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(maxLength: 30, nullable: false),
                    DoB = table.Column<DateTime>(type: "date", nullable: false),
                    ContectNo = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    AuthorInfo = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(maxLength: 50, nullable: false),
                    ContectNo = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false),
                    Descrition = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Edition = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(maxLength: 50, nullable: true),
                    NumberOfPage = table.Column<int>(nullable: false),
                    Language = table.Column<string>(maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Address", "AuthorInfo", "AuthorName", "ContectNo", "DoB", "Email", "ImageUrl", "IsActive" },
                values: new object[,]
                {
                    { 1, "Chittagorm", "Sample Information", "Lema", "123456789", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lema@gmail.comn", "", true },
                    { 2, "Dhaka", "Sample Information", "Anware", "123455789", new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anwar@gmail.comn", "", true },
                    { 3, "Chittagorm", "Sample Information", "Ekram", "127756789", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ekram@gmail.comn", "", true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Noval", true },
                    { 2, "History", true },
                    { 3, "Jokes", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
