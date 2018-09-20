using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC.Infrastructure.Migrations
{
    public partial class AlteracaoDoModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Profissao",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Profissao",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CBO",
                table: "Profissao",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Referencia",
                table: "Endereco",
                type: "varchar(300)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Endereco",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Profissao",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Profissao",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "CBO",
                table: "Profissao",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Referencia",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");
        }
    }
}
