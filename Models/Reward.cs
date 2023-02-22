namespace QuestsSystem.Models
{
    public enum RewardType
    {
        item, reputation, unlock
    }
    public class Reward
    {
        public int RewardID { get; set; }
        public string RewardName { get; set; }
        public RewardType rewardType { get; set; }
        public int? Quantity { get; set; }
    }
}
