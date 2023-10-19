using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartSchool.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Alunos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "Alunos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 15, 6, 40, 666, DateTimeKind.Local).AddTicks(1647));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 10, 18, 10, 19, 23, 146, DateTimeKind.Local).AddTicks(2965));
        }
    }
}
