using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial1.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(nullable: true),
                    vencimiento = table.Column<DateTime>(nullable: false),
                    estimacion = table.Column<DateTime>(nullable: false),
                    responsableid = table.Column<int>(nullable: true),
                    estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_responsableid",
                        column: x => x.responsableid,
                        principalTable: "Recurso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(nullable: false),
                    tiempo = table.Column<DateTime>(nullable: false),
                    Recursoid = table.Column<int>(nullable: true),
                    Tareaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.id);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_Recursoid",
                        column: x => x.Recursoid,
                        principalTable: "Recurso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_Tareaid",
                        column: x => x.Tareaid,
                        principalTable: "Tarea",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Recursoid",
                table: "Detalle",
                column: "Recursoid");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Tareaid",
                table: "Detalle",
                column: "Tareaid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_responsableid",
                table: "Tarea",
                column: "responsableid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");
        }
    }
}
