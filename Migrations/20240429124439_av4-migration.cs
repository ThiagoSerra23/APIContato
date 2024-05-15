using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi_Funcionario.Migrations
{
    /// <inheritdoc />
    public partial class av4migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Menssagem",
                table: "Contatos",
                newName: "Mensagem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mensagem",
                table: "Contatos",
                newName: "Menssagem");
        }
    }
}
