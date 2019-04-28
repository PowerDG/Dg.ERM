using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DG.ERM.Migrations
{
    public partial class InitialCreateOUnits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DgOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Sorting = table.Column<int>(nullable: false),
                    Operator = table.Column<string>(nullable: true),
                    RecordCreateTime = table.Column<string>(nullable: true),
                    RecordUpdateTime = table.Column<string>(nullable: true),
                    RecordStatus = table.Column<int>(nullable: false),
                    ParentId1 = table.Column<int>(nullable: true),
                    ParentId = table.Column<long>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DgOrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DgOrganizationUnits_DgOrganizationUnits_ParentId1",
                        column: x => x.ParentId1,
                        principalTable: "DgOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DgOrganizationUnits_ParentId1",
                table: "DgOrganizationUnits",
                column: "ParentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DgOrganizationUnits");
        }
    }
}
