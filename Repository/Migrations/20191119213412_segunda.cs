using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pessoas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Pessoas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Pessoas");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
