using Microsoft.EntityFrameworkCore;
using QuestsSystem.Models;

namespace QuestsSystem.Data
{
    public class QuestContext : DbContext
    {

        public QuestContext(DbContextOptions options) :base(options)
        {
            //Quest.Add(new Quest { Name = "Wolf Destroyer", Description = "Kill 10 wolves", Level = 1, Rarity = Rarity.common, IsChainQuest = false });
            //Quest.Add(new Quest { Name = "Sheep Destroyer", Description = "Kill 10 sheeps", Level = 1, Rarity = Rarity.common, IsChainQuest = false, Location = Locations.forest });
            //Quest.Add(new Quest { Name = "Sheep Desacration", Description = "Kill 666 white sheeps", Level = 1, Rarity = Rarity.rare, IsChainQuest = true, Location = Locations.farm });
            //Quest.Add(new Quest { Name = "Sheep Destroyer", Description = "Stop the Sheepocalypse", Level = 1, Rarity = Rarity.common, IsChainQuest = false, Location = Locations.ruins });
        }
        public DbSet<Mob> Mob { get; set; }
        public DbSet<Npc> Npc { get; set; }
        public DbSet<NpcRequirementConnector> NpcRequirementConnector { get; set; }
        public DbSet<Quest> Quest { get; set; }
        public DbSet<QuestRewardConnector> QuestRewardConnector { get; set; }
        public DbSet<Requirement> Requirement { get; set; }
        public DbSet<Reward> Reward { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
