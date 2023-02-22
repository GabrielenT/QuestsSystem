namespace QuestsSystem.Models
{
    public class NpcRequirementConnector
    {
            public int NpcRequirementConnectorID { get; set; }
            public int RequirementID { get; set; }
            public int NpcID { get; set; }
            public virtual Requirement Requirement { get; set; }
            public virtual Npc NPC { get; set; }
    }
}
