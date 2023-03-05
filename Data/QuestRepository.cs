using QuestsSystem.Models;

namespace QuestsSystem.Data
{
    public class QuestRepository : IQuestRepository
    {
        private static QuestContext _questContext;
        public QuestRepository(QuestContext questContext)
        {
            _questContext = questContext;
        }
        public async Task<IEnumerable<Quest>> GetAllQuests()
        {
            var list = _questContext.Quest;
            return await Task.FromResult(list);
        }
        public async Task<IEnumerable<Quest>> GetQuestsInLevelRange(int minLevel, int maxLevel)
        {
            var list = _questContext.Quest.Where(x =>(x.Level>=minLevel && x.Level<=maxLevel));
            return await Task.FromResult(list);
        }
        public async Task<IEnumerable<Quest>> GetQuestsWithID(int id)
        {
            var result = _questContext.Quest.Where(x => (x.QuestID == id));
            return await Task.FromResult(result);
        }
    }
}
