namespace QuestsSystem.Models
{
    public enum RequirementType
    {
        unlock, reputation, race, class_locked
    }
    public class Requirement
    {
        public int RequirementID { get; set; }
        public string RequirementName { get; set; }
        public RequirementType RequirementType { get; set; }
    }
}
