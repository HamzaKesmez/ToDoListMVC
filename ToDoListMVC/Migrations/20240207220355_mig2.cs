using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListMVC.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_lists",
                table: "lists");

            migrationBuilder.RenameTable(
                name: "lists",
                newName: "Lists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lists",
                table: "Lists",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lists",
                table: "Lists");

            migrationBuilder.RenameTable(
                name: "Lists",
                newName: "lists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lists",
                table: "lists",
                column: "id");
        }
    }
}
