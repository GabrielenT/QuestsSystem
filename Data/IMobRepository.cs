using QuestsSystem.Models;

namespace QuestsSystem.Data
{
    public interface IMobRepository
    {
        Task<IEnumerable<Mob>> GetAllMobs();
        Task<IEnumerable<Mob>> GetMobsLevelRange(int minLevel, int maxLevel);
        Task<IEnumerable<Mob>> GetMobsLevelRangeDifficulty(int minLevel, int maxLevel, Difficulty difficulty);
        Task<IEnumerable<Mob>> GetMobsWithID(int id);
    }
}
