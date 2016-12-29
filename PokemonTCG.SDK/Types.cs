using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTCG.SDK
{
    public class Types
    {
        public List<string> types { get; set; }

        public List<string> All()
        {
            Types types = APIClient<Types>.GetClient().All("types", "");
            return types != null ? types.types : null;
        }
    }
}
