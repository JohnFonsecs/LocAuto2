using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Locacoes.Migrations
{
    /// <inheritdoc />
    public partial class slamanofaltouidnaporradoveiculolocado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VeiculosLocados",
                table: "VeiculosLocados");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "VeiculosLocados",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VeiculosLocados",
                table: "VeiculosLocados",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_VeiculosLocados_LocacaoId",
                table: "VeiculosLocados",
                column: "LocacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VeiculosLocados",
                table: "VeiculosLocados");

            migrationBuilder.DropIndex(
                name: "IX_VeiculosLocados_LocacaoId",
                table: "VeiculosLocados");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "VeiculosLocados");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VeiculosLocados",
                table: "VeiculosLocados",
                columns: new[] { "LocacaoId", "VeiculoId" });
        }
    }
}
