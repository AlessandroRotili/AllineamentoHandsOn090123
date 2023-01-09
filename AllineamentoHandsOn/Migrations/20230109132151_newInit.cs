using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllineamentoHandsOn.Migrations
{
    /// <inheritdoc />
    public partial class newInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LogoId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pic = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LogoId",
                table: "Companies",
                column: "LogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Images_LogoId",
                table: "Companies",
                column: "LogoId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Images_LogoId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Companies_LogoId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "LogoId",
                table: "Companies");
        }
    }
}
