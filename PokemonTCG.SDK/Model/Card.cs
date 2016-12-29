using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTCG.SDK.Model
{
    public class Card
    {
        public string id { get; set; }
        public string name { get; set; }
        public int nationalPokedexNumber { get; set; }
        public string imageUrl { get; set; }
        public string subtype { get; set; }
        public string supertype { get; set; }
        public Ability ability { get; set; }
        public string hp { get; set; }
        public List<string> retreatCost { get; set; }
        public string number { get; set; }
        public string artist { get; set; }
        public string series { get; set; }
        public string set { get; set; }
        public List<string> types { get; set; }
        public List<Attack> attacks { get; set; }
        public List<Weakness> weaknesses { get; set; }
        public List<Resistance> resistances { get; set; }
    }
}
