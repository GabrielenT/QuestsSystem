using Microsoft.EntityFrameworkCore;
using QuestsSystem.Models;

namespace QuestsSystem.Data
{
    public class QuestContext : DbContext
    {

        public QuestContext(DbContextOptions options) :base(options)
        {
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
