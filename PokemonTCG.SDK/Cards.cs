using PokemonTCG.SDK.Model;
using System.Collections.Generic;

namespace PokemonTCG.SDK
{
    public class Cards
    {
        public List<Card> cards;
        public Card card;
        private string query { get; set; }

        public List<Card> All()
        {
            Cards cards = APIClient<Cards>.GetClient().All("cards", query);
            return cards != null ? cards.cards : null;
        }

        public Card Find(string id)
        {
            Cards cards = APIClient<Cards>.GetClient().Find("cards", id);
            return cards != null ? cards.card: null;
        }

        public Cards Where(string name = "", int nationalPokedexNumber = 0, string types = "", string subtype = "",
            string supertype = "", string hp = "", string number = "", string artist = "", string rarity = "", string series = "",
            string set = "", string setCode = "", string retreatCost = "", string text = "",
            string attackDamage = "", string attackCost = "", string weaknesses = "", string resistances = "",
            string ancientTrait = "", string abilityName = "", string abilityText = "", string abilityType = "",
            string page = "", string pageSize = "")
        {
            if (!string.IsNullOrEmpty(name)) { query += string.Format("name={0}&", name); }
            if (nationalPokedexNumber > 0) { query += string.Format("nationalPokedexNumber={0}", nationalPokedexNumber); }
            if (!string.IsNullOrEmpty(types)) { query += string.Format("types={0}&", types); }
            if (!string.IsNullOrEmpty(subtype)) { query += string.Format("subtype={0}&", subtype); }
            if (!string.IsNullOrEmpty(supertype)) { query += string.Format("supertype={0}&", supertype); }
            if (!string.IsNullOrEmpty(hp)) { query += string.Format("hp={0}&", hp); }
            if (!string.IsNullOrEmpty(number)) { query += string.Format("number={0}&", number); }
            if (!string.IsNullOrEmpty(artist)) { query += string.Format("artist={0}&", artist); }
            if (!string.IsNullOrEmpty(rarity)) { query += string.Format("rarity={0}&", rarity); }
            if (!string.IsNullOrEmpty(series)) { query += string.Format("series={0}&", series); }
            if (!string.IsNullOrEmpty(set)) { query += string.Format("set={0}&", set); }
            if (!string.IsNullOrEmpty(setCode)) { query += string.Format("setCode={0}&", setCode); }
            if (!string.IsNullOrEmpty(retreatCost)) { query += string.Format("retreatCost={0}&", retreatCost); }
            if (!string.IsNullOrEmpty(text)) { query += string.Format("text={0}&", text); }
            if (!string.IsNullOrEmpty(attackDamage)) { query += string.Format("attackDamage={0}&", attackDamage); }
            if (!string.IsNullOrEmpty(attackCost)) { query += string.Format("attackCost={0}&", attackCost); }
            if (!string.IsNullOrEmpty(weaknesses)) { query += string.Format("weaknesses={0}&", weaknesses); }
            if (!string.IsNullOrEmpty(resistances)) { query += string.Format("resistances={0}&", resistances); }
            if (!string.IsNullOrEmpty(ancientTrait)) { query += string.Format("ancientTrait={0}&", ancientTrait); }
            if (!string.IsNullOrEmpty(abilityName)) { query += string.Format("abilityName={0}&", abilityName); }
            if (!string.IsNullOrEmpty(abilityText)) { query += string.Format("abilityText={0}&", abilityText); }
            if (!string.IsNullOrEmpty(abilityType)) { query += string.Format("abilityType={0}&", abilityType); }
            if (!string.IsNullOrEmpty(page)) { query += string.Format("page={0}&", page); }
            if (!string.IsNullOrEmpty(pageSize)) { query += string.Format("pageSize={0}&", pageSize); }

            return this;
        }

    }
}
