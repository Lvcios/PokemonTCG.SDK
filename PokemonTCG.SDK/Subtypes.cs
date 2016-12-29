using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTCG.SDK
{
    public class Subtypes
    {
        public List<string> subtypes { get; set; }
        public List<string> All()
        {
            Subtypes subtypes = APIClient<Subtypes>.GetClient().All("subtypes", "");
            return subtypes != null ? subtypes.subtypes : null;
        }
    }
}
