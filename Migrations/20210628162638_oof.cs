using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagementProject.Migrations
{
    public partial class oof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Doctor_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Doctor_Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Patient_Id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSchedule",
                columns: table => new
                {
                    Timeslot_Id = table.Column<int>(type: "int", nullable: false),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSchedule", x => new { x.Doctor_Id, x.Timeslot_Id });
                    table.ForeignKey(
                        name: "FK_DoctorSchedule_Doctors_Doctor_Id",
                        column: x => x.Doctor_Id,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorSchedule_Patients_Patient_Id",
                        column: x => x.Patient_Id,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Doctor_Id", "Age", "Gender", "Name", "Password", "PasswordSalt", "Phone", "Username" },
                values: new object[] { 1, 30, "Male", "TimDoc", new byte[] { 0 }, new byte[] { 0 }, "323524523", "docabc" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Doctor_Id", "Age", "Gender", "Name", "Password", "PasswordSalt", "Phone", "Username" },
                values: new object[] { 2, 30, "Male", "TiDoc", new byte[] { 0, 0 }, new byte[] { 0, 0 }, "323524523", "docoof" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Patient_Id", "Age", "Gender", "Name", "Password", "PasswordSalt", "Phone", "Username" },
                values: new object[] { 1, 30, "Male", "Tim", new byte[] { 0 }, new byte[] { 0 }, "32423434", "abc" });

            migrationBuilder.InsertData(
                table: "DoctorSchedule",
                columns: new[] { "Doctor_Id", "Timeslot_Id", "Patient_Id", "Time" },
                values: new object[,]
                {
                    { 1, 1, null, "930-1030" },
                    { 1, 2, null, "1330-1430" },
                    { 2, 1, null, "930-1030" },
                    { 2, 2, null, "1330-1430" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSchedule_Patient_Id",
                table: "DoctorSchedule",
                column: "Patient_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "DoctorSchedule");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
