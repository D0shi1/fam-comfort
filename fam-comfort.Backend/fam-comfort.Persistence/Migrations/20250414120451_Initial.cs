using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fam_comfort.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    HexColor = table.Column<string>(type: "varchar(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacadeCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    PathToImage = table.Column<string>(type: "varchar(2048)", nullable: false, defaultValue: "images/template_image_facade_category.png")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacadeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    ShortName = table.Column<string>(type: "varchar(128)", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(1024)", nullable: false),
                    Materials = table.Column<string>(type: "varchar(256)", nullable: false),
                    PathToImage = table.Column<string>(type: "varchar(2048)", nullable: false, defaultValue: "images/template_image_facade.png"),
                    PathToImageSchema = table.Column<string>(type: "varchar(2048)", nullable: false, defaultValue: "images/template_image_facade.png"),
                    FacadeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facades_FacadeCategories_FacadeCategoryId",
                        column: x => x.FacadeCategoryId,
                        principalTable: "FacadeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColorFacade",
                columns: table => new
                {
                    ColorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacadesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorFacade", x => new { x.ColorsId, x.FacadesId });
                    table.ForeignKey(
                        name: "FK_ColorFacade_Colors_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorFacade_Facades_FacadesId",
                        column: x => x.FacadesId,
                        principalTable: "Facades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColorFacade_FacadesId",
                table: "ColorFacade",
                column: "FacadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Facades_FacadeCategoryId",
                table: "Facades",
                column: "FacadeCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorFacade");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Facades");

            migrationBuilder.DropTable(
                name: "FacadeCategories");
        }
    }
}
