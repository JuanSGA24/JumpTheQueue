using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JumpTheQueue.WebAPI.Implementation.Migrations
{
    public partial class _01092021JumpTheQueueInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    username = table.Column<string>(type: "character varying", nullable: false),
                    password = table.Column<string>(type: "character varying", nullable: false),
                    role = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Queue",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    logo = table.Column<string>(type: "character varying", nullable: true),
                    description = table.Column<string>(type: "character varying", nullable: true),
                    accessLink = table.Column<string>(type: "character varying", nullable: true),
                    minAttentionTime = table.Column<int>(nullable: false),
                    openTime = table.Column<DateTime>(type: "date", nullable: true),
                    closeTime = table.Column<DateTime>(type: "date", nullable: true),
                    started = table.Column<bool>(nullable: true),
                    closed = table.Column<bool>(nullable: true),
                    user_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queue", x => x.id);
                    table.ForeignKey(
                        name: "queue_fk",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccessCode",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    code = table.Column<string>(type: "character varying", nullable: false),
                    createdTime = table.Column<DateTime>(type: "date", nullable: false),
                    startTime = table.Column<DateTime>(type: "date", nullable: true),
                    endTime = table.Column<DateTime>(type: "date", nullable: true),
                    status = table.Column<string>(type: "character varying", nullable: true),
                    visitor_id = table.Column<Guid>(nullable: false),
                    queue_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessCode", x => x.id);
                    table.ForeignKey(
                        name: "accesscode_fk",
                        column: x => x.queue_id,
                        principalTable: "Queue",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "accesscode_fk_1",
                        column: x => x.visitor_id,
                        principalTable: "Visitor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessCode_queue_id",
                table: "AccessCode",
                column: "queue_id");

            migrationBuilder.CreateIndex(
                name: "IX_AccessCode_visitor_id",
                table: "AccessCode",
                column: "visitor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Queue_user_id",
                table: "Queue",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessCode");

            migrationBuilder.DropTable(
                name: "Queue");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
