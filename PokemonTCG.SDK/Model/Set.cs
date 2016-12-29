using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTCG.SDK.Model
{
    public class Set
    {
        public string code { get; set; }
        public string name { get; set; }
        public string series { get; set; }
        public string totalCards { get; set; }
        public bool standardLegal { get; set; }
        public string releaseDate { get; set; }
    }
}
