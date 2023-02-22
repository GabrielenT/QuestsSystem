namespace QuestsSystem.Models
{
    public class QuestRewardConnector
    {
        public int QuestRewardConnectorID { get; set; }
        public int RewardID { get; set; }
        public int NpcID { get; set; }
        public virtual Reward Reward { get; set; }
        public virtual Quest Quest { get; set; }
    }
}
