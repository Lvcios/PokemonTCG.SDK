using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTCG.SDK
{
    public class Supertypes
    {
        public List<string> supertypes { get; set; }
        public List<string> All()
        {
            Supertypes supertypes = APIClient<Supertypes>.GetClient().All("supertypes", "");
            return supertypes != null ? supertypes.supertypes : null;
        }
    }
}
