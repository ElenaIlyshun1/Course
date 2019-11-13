using Microsoft.EntityFrameworkCore.Migrations;

namespace WebHelsi.Migrations
{
    public partial class AddtblSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_tblClients_ClientId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_tblDoctors_DoctorId",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "tblSchedule");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_DoctorId",
                table: "tblSchedule",
                newName: "IX_tblSchedule_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_ClientId",
                table: "tblSchedule",
                newName: "IX_tblSchedule_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblSchedule",
                table: "tblSchedule",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblSchedule_tblClients_ClientId",
                table: "tblSchedule",
                column: "ClientId",
                principalTable: "tblClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblSchedule_tblDoctors_DoctorId",
                table: "tblSchedule",
                column: "DoctorId",
                principalTable: "tblDoctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblSchedule_tblClients_ClientId",
                table: "tblSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_tblSchedule_tblDoctors_DoctorId",
                table: "tblSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblSchedule",
                table: "tblSchedule");

            migrationBuilder.RenameTable(
                name: "tblSchedule",
                newName: "Schedules");

            migrationBuilder.RenameIndex(
                name: "IX_tblSchedule_DoctorId",
                table: "Schedules",
                newName: "IX_Schedules_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_tblSchedule_ClientId",
                table: "Schedules",
                newName: "IX_Schedules_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_tblClients_ClientId",
                table: "Schedules",
                column: "ClientId",
                principalTable: "tblClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_tblDoctors_DoctorId",
                table: "Schedules",
                column: "DoctorId",
                principalTable: "tblDoctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
