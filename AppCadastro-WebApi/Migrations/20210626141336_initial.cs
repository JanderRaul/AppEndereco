using Microsoft.EntityFrameworkCore.Migrations;

namespace AppCadastro_WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tratamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataNasc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataInc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ClienteEnd",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteEnd", x => new { x.ClienteId, x.EnderecoId });
                    table.ForeignKey(
                        name: "FK_ClienteEnd_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteEnd_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "id", "cpf", "dataInc", "dataNasc", "nome", "status", "tipo", "tratamento" },
                values: new object[,]
                {
                    { 1, "111.222.333-44", "19/06/2021 10:21", "01/01/1990", "Jander", "Ativo", "Pessoa Fisica", "Jander Raul" },
                    { 2, "222.333.444-55", "19/06/2021 10:22", "02/02/1991", "Raul", "Ativo", "Pessoa Fisica", "Raul Raul" }
                });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "id", "bairro", "cep", "cidade", "complemento", "endereco", "estado", "numero", "status" },
                values: new object[,]
                {
                    { 1, "Pinheiros", "14.000-000", "Ribeirão Preto", "Casa", "Rua Numero 1", "São Paulo", "100", "Ativo" },
                    { 2, "Palmas", "14.000-010", "Ribeirão Preto", "Ap-32, 3° Andar", "Rua Numero 2", "São Paulo", "120", "Ativo" }
                });

            migrationBuilder.InsertData(
                table: "ClienteEnd",
                columns: new[] { "ClienteId", "EnderecoId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ClienteEnd",
                columns: new[] { "ClienteId", "EnderecoId" },
                values: new object[] { 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteEnd_EnderecoId",
                table: "ClienteEnd",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteEnd");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
