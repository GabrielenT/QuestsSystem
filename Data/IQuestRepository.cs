using QuestsSystem.Models;

namespace QuestsSystem.Data

{
    public interface IQuestRepository
    {
        Task<IEnumerable<Quest>> GetAllQuests();
        Task<IEnumerable<Quest>> GetQuestsInLevelRange(int minLevel, int maxLevel);
        Task<IEnumerable<Quest>> GetQuestsWithID(int id);
    }
}
