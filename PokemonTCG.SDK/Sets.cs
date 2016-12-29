using PokemonTCG.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTCG.SDK
{
    public class Sets
    {
        private string query { get; set; }
        public List<Set> sets { get; set; }
        public Set set { get; set; }

        public List<Set> All()
        {
            Sets sets = APIClient<Sets>.GetClient().All("sets", query);
            return sets != null ? sets.sets : null;
        }

        public Set Find(string id)
        {
            Sets sets = APIClient<Sets>.GetClient().Find("sets", id);
            return sets != null ? sets.set : null;
        }

        public Sets Where(string name = "", string series = "", string totalCards = "", string standardLegal = "", 
            string code = "", string releaseDate = "", string page = "", string pageSize = "")
        {
            if (!string.IsNullOrEmpty(name)) { query += string.Format("name={0}&", name); }
            if (!string.IsNullOrEmpty(series)) { query += string.Format("series={0}&", series); }
            if (!string.IsNullOrEmpty(totalCards)) { query += string.Format("totalCards={0}&", totalCards); }
            if (!string.IsNullOrEmpty(standardLegal)) { query += string.Format("standardLegal={0}&", standardLegal); }
            if (!string.IsNullOrEmpty(releaseDate)) { query += string.Format("releaseDate={0}&", releaseDate); }
            if (!string.IsNullOrEmpty(page)) { query += string.Format("page={0}&", page); }
            if (!string.IsNullOrEmpty(pageSize)) { query += string.Format("pageSize={0}&", pageSize); }
            return this;
        }
    }
}
