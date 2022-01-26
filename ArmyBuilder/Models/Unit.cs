
using Newtonsoft.Json;

namespace ArmyBuilder.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Movement { get; set; }
        public int Range { get; set; }
        public int Strength { get; set; }
        public int Armor { get; set; }
        public int Points { get; set; }
    }
}