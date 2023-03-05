using QuestsSystem.Models;

namespace QuestsSystem.Data
{
    public class MobRepository : IMobRepository
    {
        private static QuestContext _questContext;
        public MobRepository(QuestContext questContext)
        {
            _questContext = questContext;
        }
        public async Task<IEnumerable<Mob>> GetAllMobs()
        {
            var list = _questContext.Mob;
            return await Task.FromResult(list);
        }
        public async Task<IEnumerable<Mob>> GetMobsLevelRange(int minLevel, int maxLevel)
        {
            var list = _questContext.Mob.Where(x => (x.Level >= minLevel && x.Level <= maxLevel));
            return await Task.FromResult(list);
        }
        public async Task<IEnumerable<Mob>> GetMobsLevelRangeDifficulty(int minLevel, int maxLevel, Difficulty difficulty)
        {
            var list = _questContext.Mob.Where(x => (x.Level >= minLevel && x.Level <= maxLevel && x.Difficulty == difficulty));
            return await Task.FromResult(list);
        }
        public async Task<IEnumerable<Mob>> GetMobsWithID(int id)
        {
            var list = _questContext.Mob.Where(x => (x.Level == id));
            return await Task.FromResult(list);
        }
    }
}
