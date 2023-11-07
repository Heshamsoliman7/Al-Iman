using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Al_Iman.Repositories.Migrations
{
    public partial class Edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_HospitalInfos_HospitalInfoId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_HospitalInfos_HospitalInfoId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Timing_AspNetUsers_DoctorIdId",
                table: "Timing");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "MedicineReports");

            migrationBuilder.DropTable(
                name: "Payrolls");

            migrationBuilder.DropTable(
                name: "PrescribedMedicines");

            migrationBuilder.DropTable(
                name: "TestPrices");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "PatientReport");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Labs");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Timing",
                table: "Timing");

            migrationBuilder.DropIndex(
                name: "IX_Timing_DoctorIdId",
                table: "Timing");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoctorIdId",
                table: "Timing");

            migrationBuilder.RenameTable(
                name: "Timing",
                newName: "Timings");

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

            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "AspNetUsers",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoctorId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentTime",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "Timings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timings",
                table: "Timings",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Timings_DoctorId",
                table: "Timings",
                column: "DoctorId",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Timings_AspNetUsers_DoctorId",
                table: "Timings",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_HospitalInfos_HospitalId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_HospitalInfos_HospitalId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Timings_AspNetUsers_DoctorId",
                table: "Timings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Timings",
                table: "Timings");

            migrationBuilder.DropIndex(
                name: "IX_Timings_DoctorId",
                table: "Timings");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppointmentTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Timings");

            migrationBuilder.RenameTable(
                name: "Timings",
                newName: "Timing");

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

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "AspNetUsers",
                newName: "PictureUrl");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DoctorIdId",
                table: "Timing",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timing",
                table: "Timing",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Labs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BloodPressure = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    LabNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<int>(type: "int", nullable: false),
                    TestCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Labs_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientReportId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientReport_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientReport_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payrolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeIdId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AccountNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BonusSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Compensation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HourlySalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payrolls_AspNetUsers_EmployeeIdId",
                        column: x => x.EmployeeIdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Advance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillNumber = table.Column<int>(type: "int", nullable: false),
                    DoctorCharge = table.Column<int>(type: "int", nullable: false),
                    LabCharge = table.Column<int>(type: "int", nullable: false),
                    MedicineCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoOfDays = table.Column<int>(type: "int", nullable: false),
                    NursingCharge = table.Column<int>(type: "int", nullable: false),
                    OperationCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalBill = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bills_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicineReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Qunantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicineReports_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicineReports_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescribedMedicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    PatientReportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescribedMedicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescribedMedicines_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescribedMedicines_PatientReport_PatientReportId",
                        column: x => x.PatientReportId,
                        principalTable: "PatientReport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: false),
                    LabId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TestCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestPrices_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestPrices_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Timing_DoctorIdId",
                table: "Timing",
                column: "DoctorIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_InsuranceId",
                table: "Bills",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PatientId",
                table: "Bills",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_PatientId",
                table: "Labs",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineReports_MedicineId",
                table: "MedicineReports",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineReports_SupplierId",
                table: "MedicineReports",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientReport_DoctorId",
                table: "PatientReport",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientReport_PatientId",
                table: "PatientReport",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Payrolls_EmployeeIdId",
                table: "Payrolls",
                column: "EmployeeIdId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescribedMedicines_MedicineId",
                table: "PrescribedMedicines",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescribedMedicines_PatientReportId",
                table: "PrescribedMedicines",
                column: "PatientReportId");

            migrationBuilder.CreateIndex(
                name: "IX_TestPrices_BillId",
                table: "TestPrices",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_TestPrices_LabId",
                table: "TestPrices",
                column: "LabId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Timing_AspNetUsers_DoctorIdId",
                table: "Timing",
                column: "DoctorIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
