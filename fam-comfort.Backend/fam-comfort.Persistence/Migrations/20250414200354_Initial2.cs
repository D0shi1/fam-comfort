using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fam_comfort.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorFacade");

            migrationBuilder.DropColumn(
                name: "PathToImage",
                table: "Facades");

            migrationBuilder.DropColumn(
                name: "HexColor",
                table: "Colors");

            migrationBuilder.AddColumn<Guid>(
                name: "FacadeID",
                table: "Colors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "PathToImage",
                table: "Colors",
                type: "varchar(2048)",
                nullable: false,
                defaultValue: "images/template_image_facade.png");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_FacadeID",
                table: "Colors",
                column: "FacadeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Facades_FacadeID",
                table: "Colors",
                column: "FacadeID",
                principalTable: "Facades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Facades_FacadeID",
                table: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Colors_FacadeID",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "FacadeID",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "PathToImage",
                table: "Colors");

            migrationBuilder.AddColumn<string>(
                name: "PathToImage",
                table: "Facades",
                type: "varchar(2048)",
                nullable: false,
                defaultValue: "images/template_image_facade.png");

            migrationBuilder.AddColumn<string>(
                name: "HexColor",
                table: "Colors",
                type: "varchar(8)",
                nullable: false,
                defaultValue: "");

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
        }
    }
}
