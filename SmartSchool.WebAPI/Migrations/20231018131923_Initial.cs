using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartSchool.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Matricula = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Registro = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    DataNasc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunoCurso",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Nota = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoCurso", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    CargaHoraria = table.Column<int>(type: "INTEGER", nullable: false),
                    PrerequisitoId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProfessorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Disciplinas_PrerequisitoId",
                        column: x => x.PrerequisitoId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplinaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Nota = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataIni", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3218), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Marta", "Kent", "33225555" },
                    { 2, true, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3228), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Paula", "Isabela", "3354288" },
                    { 3, true, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3232), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Laura", "Antonia", "55668899" },
                    { 4, true, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3236), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Luiza", "Maria", "6565659" },
                    { 5, true, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3240), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Lucas", "Machado", "565685415" },
                    { 6, true, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3245), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Pedro", "Alvares", "456454545" },
                    { 7, true, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3248), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Paulo", "José", "9874512" }
                });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Tecnologia da Informação" },
                    { 2, "Sistemas de Informação" },
                    { 3, "Ciência da Computação" }
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "DataFim", "DataIni", "DataNasc", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2949), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauro", 1, "Oliveira", null },
                    { 2, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2962), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", 2, "Soares", null },
                    { 3, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2964), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ronaldo", 3, "Marconi", null },
                    { 4, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2965), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodrigo", 4, "Carvalho", null },
                    { 5, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2965), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandre", 5, "Montanha", null }
                });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[,]
                {
                    { 1, 0, 1, "Matemática", null, 1 },
                    { 2, 0, 3, "Matemática", null, 1 },
                    { 3, 0, 3, "Física", null, 2 },
                    { 4, 0, 1, "Português", null, 3 },
                    { 5, 0, 1, "Inglês", null, 4 },
                    { 6, 0, 2, "Inglês", null, 4 },
                    { 7, 0, 3, "Inglês", null, 4 },
                    { 8, 0, 1, "Programação", null, 5 },
                    { 9, 0, 2, "Programação", null, 5 },
                    { 10, 0, 3, "Programação", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[,]
                {
                    { 1, 2, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3266), null },
                    { 1, 4, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3270), null },
                    { 1, 5, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3270), null },
                    { 2, 1, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3271), null },
                    { 2, 2, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3272), null },
                    { 2, 5, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3273), null },
                    { 3, 1, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3274), null },
                    { 3, 2, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3275), null },
                    { 3, 3, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3276), null },
                    { 4, 1, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3277), null },
                    { 4, 4, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3278), null },
                    { 4, 5, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3279), null },
                    { 5, 4, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3280), null },
                    { 5, 5, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3280), null },
                    { 6, 1, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3281), null },
                    { 6, 2, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3282), null },
                    { 6, 3, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3282), null },
                    { 6, 4, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3284), null },
                    { 7, 1, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3285), null },
                    { 7, 2, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3286), null },
                    { 7, 3, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3286), null },
                    { 7, 4, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3287), null },
                    { 7, 5, null, new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3288), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoCurso_CursoId",
                table: "AlunoCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_PrerequisitoId",
                table: "Disciplinas",
                column: "PrerequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoCurso");

            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
