namespace QuestsSystem.Models
{
    public enum Rarity
    {
        common, uncommon, rare, epic, mythic, legendary
    }
    public enum Locations
    {
        cave, mine, ruins, farm, desert, plains, meadows, forest, sea, ocean
    }
    public class Quest
    {

        public int QuestID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public Rarity Rarity { get; set; }
        public bool IsChainQuest { get; set; }
        public Locations? Location { get; set; }
        public virtual ICollection<QuestRewardConnector>? Reward { get; set; }
        // public string? AdditionalRewards { get; set; } //collection of additionalrewards
        
    }
}
