using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.WebAPI.Migrations
{
    public partial class NOMEQUALQUER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2023, 11, 12, 15, 33, 36, 168, DateTimeKind.Local).AddTicks(8159), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2023, 11, 12, 15, 33, 36, 168, DateTimeKind.Local).AddTicks(9733), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2023, 11, 12, 15, 33, 36, 168, DateTimeKind.Local).AddTicks(9778), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2023, 11, 12, 15, 33, 36, 168, DateTimeKind.Local).AddTicks(9783), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2023, 11, 12, 15, 33, 36, 168, DateTimeKind.Local).AddTicks(9787), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2023, 11, 12, 15, 33, 36, 168, DateTimeKind.Local).AddTicks(9793), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2023, 11, 12, 15, 33, 36, 168, DateTimeKind.Local).AddTicks(9798), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 169, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 166, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 166, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 166, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 166, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 11, 12, 15, 33, 36, 166, DateTimeKind.Local).AddTicks(6106));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2020, 10, 5, 15, 56, 31, 871, DateTimeKind.Local).AddTicks(4940), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2020, 10, 5, 15, 56, 31, 871, DateTimeKind.Local).AddTicks(7970), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2020, 10, 5, 15, 56, 31, 871, DateTimeKind.Local).AddTicks(8040), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2020, 10, 5, 15, 56, 31, 871, DateTimeKind.Local).AddTicks(8050), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2020, 10, 5, 15, 56, 31, 871, DateTimeKind.Local).AddTicks(8060), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2020, 10, 5, 15, 56, 31, 871, DateTimeKind.Local).AddTicks(8080), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataIni", "DataNasc" },
                values: new object[] { new DateTime(2020, 10, 5, 15, 56, 31, 871, DateTimeKind.Local).AddTicks(8080), new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 871, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 872, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 849, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 868, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 868, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 868, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2020, 10, 5, 15, 56, 31, 868, DateTimeKind.Local).AddTicks(6390));
        }
    }
}
