using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Al_Iman.Repositories.Migrations
{
    public partial class AddDoctorToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "IsDoctor",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Timing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorIdId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MorningShiftStartTime = table.Column<int>(type: "int", nullable: false),
                    MorningShiftEndTime = table.Column<int>(type: "int", nullable: false),
                    AfternoonShiftStartTime = table.Column<int>(type: "int", nullable: false),
                    AfternoonShiftEndTime = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timing_AspNetUsers_DoctorIdId",
                        column: x => x.DoctorIdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Timing_DoctorIdId",
                table: "Timing",
                column: "DoctorIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timing");

            migrationBuilder.DropColumn(
                name: "IsDoctor",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "ID");
        }
    }
}
