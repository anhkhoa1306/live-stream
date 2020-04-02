using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LiveStreamSample.Data.Migrations
{
    public partial class properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "LiveStreamData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    UrlImage = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<Guid>(nullable: false),
                    LiveStreamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LiveStreamData_PropertyId",
                table: "LiveStreamData",
                column: "PropertyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LiveStreamData_Properties_PropertyId",
                table: "LiveStreamData",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiveStreamData_Properties_PropertyId",
                table: "LiveStreamData");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_LiveStreamData_PropertyId",
                table: "LiveStreamData");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "LiveStreamData");
        }
    }
}
