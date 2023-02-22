using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestsSystem.Migrations
{
    /// <inheritdoc />
    public partial class MigracjaOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mob",
                columns: table => new
                {
                    MobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    MagicResistance = table.Column<int>(type: "int", nullable: false),
                    PhysicalResistance = table.Column<int>(type: "int", nullable: false),
                    DamageType = table.Column<int>(type: "int", nullable: false),
                    SpawnBiome = table.Column<int>(type: "int", nullable: true),
                    MonsterType = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mob", x => x.MobID);
                });

            migrationBuilder.CreateTable(
                name: "Npc",
                columns: table => new
                {
                    NpcID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Profession = table.Column<int>(type: "int", nullable: false),
                    IsDynamic = table.Column<bool>(type: "bit", nullable: false),
                    Race = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Npc", x => x.NpcID);
                });

            migrationBuilder.CreateTable(
                name: "Quest",
                columns: table => new
                {
                    QuestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    IsChainQuest = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.QuestID);
                });

            migrationBuilder.CreateTable(
                name: "Requirement",
                columns: table => new
                {
                    RequirementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequirementType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirement", x => x.RequirementID);
                });

            migrationBuilder.CreateTable(
                name: "Reward",
                columns: table => new
                {
                    RewardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RewardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rewardType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reward", x => x.RewardID);
                });

            migrationBuilder.CreateTable(
                name: "NpcRequirementConnector",
                columns: table => new
                {
                    NpcRequirementConnectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementID = table.Column<int>(type: "int", nullable: false),
                    NpcID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NpcRequirementConnector", x => x.NpcRequirementConnectorID);
                    table.ForeignKey(
                        name: "FK_NpcRequirementConnector_Npc_NpcID",
                        column: x => x.NpcID,
                        principalTable: "Npc",
                        principalColumn: "NpcID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NpcRequirementConnector_Requirement_RequirementID",
                        column: x => x.RequirementID,
                        principalTable: "Requirement",
                        principalColumn: "RequirementID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestRewardConnector",
                columns: table => new
                {
                    QuestRewardConnectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RewardID = table.Column<int>(type: "int", nullable: false),
                    NpcID = table.Column<int>(type: "int", nullable: false),
                    QuestID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestRewardConnector", x => x.QuestRewardConnectorID);
                    table.ForeignKey(
                        name: "FK_QuestRewardConnector_Quest_QuestID",
                        column: x => x.QuestID,
                        principalTable: "Quest",
                        principalColumn: "QuestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestRewardConnector_Reward_RewardID",
                        column: x => x.RewardID,
                        principalTable: "Reward",
                        principalColumn: "RewardID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NpcRequirementConnector_NpcID",
                table: "NpcRequirementConnector",
                column: "NpcID");

            migrationBuilder.CreateIndex(
                name: "IX_NpcRequirementConnector_RequirementID",
                table: "NpcRequirementConnector",
                column: "RequirementID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestRewardConnector_QuestID",
                table: "QuestRewardConnector",
                column: "QuestID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestRewardConnector_RewardID",
                table: "QuestRewardConnector",
                column: "RewardID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mob");

            migrationBuilder.DropTable(
                name: "NpcRequirementConnector");

            migrationBuilder.DropTable(
                name: "QuestRewardConnector");

            migrationBuilder.DropTable(
                name: "Npc");

            migrationBuilder.DropTable(
                name: "Requirement");

            migrationBuilder.DropTable(
                name: "Quest");

            migrationBuilder.DropTable(
                name: "Reward");
        }
    }
}
