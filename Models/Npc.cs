using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuestsSystem.Models
{
    public enum Roles
    {
        peasant, citizen, military, noble, aristocrat, king
    }
    public enum Professions
    {
        jewelcrafter, merchant, blacksmith, miner //add some more - WIP
    }
    public enum Races
    {
        human, dwarf, elf, goblin, orc
    }
    public class Npc
    {
        public int NpcID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Roles Role { get; set; }
        public Professions Profession { get; set; }
        public bool IsDynamic { get; set; }
        public Races Race { get; set; }
        public virtual ICollection<NpcRequirementConnector>? AdditionalRequirements { get; set; } // slownik: Will only talk to Humans, requires player to be a mage etc.
    }
}
