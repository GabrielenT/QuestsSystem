using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Channels;
using System.Xml.Linq;
using System.Reflection.PortableExecutable;

namespace QuestsSystem.Models
{
    public enum Difficulty
    {
        common, uncommon, rare, epic, mythic, legendary
    }
    public enum DamageType
    {
        physical, chaos, celestial, fire, earth, air, water
    }
    public enum SpawnBiome
    {
        cave, mine, ruins, farm, desert, plains, meadows, forest, sea, ocean
    }
    public enum MonsterType
    {
        animal,mob,boss,celestial
    }
    public class Mob
    {

        public int MobID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Difficulty Difficulty { get; set; }
        public int MagicResistance { get; set; }
        public int PhysicalResistance { get; set; }
        public DamageType DamageType { get; set; }
        public SpawnBiome? SpawnBiome{ get; set; }
        public MonsterType MonsterType { get; set; }
        public int Weight { get; set; }

    }
}
