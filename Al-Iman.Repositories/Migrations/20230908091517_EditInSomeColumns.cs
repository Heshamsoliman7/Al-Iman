using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Al_Iman.Repositories.Migrations
{
    public partial class EditInSomeColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_HospitalInfos_HospitalId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_HospitalInfos_HospitalId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HospitalId",
                table: "Rooms",
                newName: "HospitalInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HospitalId",
                table: "Rooms",
                newName: "IX_Rooms_HospitalInfoId");

            migrationBuilder.RenameColumn(
                name: "HospitalId",
                table: "Contacts",
                newName: "HospitalInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_HospitalId",
                table: "Contacts",
                newName: "IX_Contacts_HospitalInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_HospitalInfos_HospitalInfoId",
                table: "Contacts",
                column: "HospitalInfoId",
                principalTable: "HospitalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_HospitalInfos_HospitalInfoId",
                table: "Rooms",
                column: "HospitalInfoId",
                principalTable: "HospitalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_HospitalInfos_HospitalInfoId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_HospitalInfos_HospitalInfoId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HospitalInfoId",
                table: "Rooms",
                newName: "HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HospitalInfoId",
                table: "Rooms",
                newName: "IX_Rooms_HospitalId");

            migrationBuilder.RenameColumn(
                name: "HospitalInfoId",
                table: "Contacts",
                newName: "HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_HospitalInfoId",
                table: "Contacts",
                newName: "IX_Contacts_HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_HospitalInfos_HospitalId",
                table: "Contacts",
                column: "HospitalId",
                principalTable: "HospitalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_HospitalInfos_HospitalId",
                table: "Rooms",
                column: "HospitalId",
                principalTable: "HospitalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
