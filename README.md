# PokemonTCG.SDK
Pokemon TCG dotNET SDK

This SDK use the API from https://pokemontcg.io/

## How to use it##

    //Get all cards 
    foreach (Card card in new Cards().Where(name:"pikachu", page:"1", pageSize:"5").All())
    {
      Console.WriteLine(string.Format("Id: {4},Name: {0}, Pokedex Number {1}, Abilitie Name:{2}, desc:{3}",
      card.name,
      card.nationalPokedexNumber,
      card.ability != null ? card.ability.name : "",
      card.ability != null ? card.ability.text : "",
      card.id));
    }
    
    //Find card by id
    var cardFind = new Cards().Find("xy7-54");
    Console.WriteLine(string.Format("Id: {4},Name: {0}, Pokedex Number {1}, Abilitie Name:{2}, desc:{3}",
      cardFind.name,
      cardFind.nationalPokedexNumber,
      cardFind.ability != null ? cardFind.ability.name : "",
      cardFind.ability != null ? cardFind.ability.text : "",
      cardFind.id));

      //Get all sets
      foreach(Set set in new Sets().Where(page:"1", pageSize: "5").All())
      {
        Console.WriteLine(string.Format("Set Name: {0}, code:{1}, total cards:{2}", set.name, set.code, set.totalCards));
      }

      //find set by id
      Set setFind = new Sets().Find("xy1");
      Console.WriteLine(string.Format("Set Name: {0}, code:{1}, total cards:{2}", setFind.name, setFind.code, setFind.totalCards));

      //types, subtypes and supertypes
      Console.WriteLine(string.Join(",", new Types().All()));
      Console.WriteLine(string.Join(",", new Subtypes().All()));
      Console.WriteLine(string.Join(",", new Supertypes().All()));

I need your support/
