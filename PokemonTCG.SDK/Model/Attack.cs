using System.Collections.Generic;

namespace PokemonTCG.SDK.Model
{
    public class Attack
    {
        public List<string> cost { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public string damage { get; set; }
        public int convertedEnergyCost { get; set; }
    }
}