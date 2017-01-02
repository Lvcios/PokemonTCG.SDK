# PokemonTCG.SDK
Pokemon TCG dotNET SDK

This SDK use the API from https://pokemontcg.io/

You can install it through the Package Manager Console (NuGet) by
    
    Install-Package PokemonTCG.SDK
    
Or download the dll file from https://www.nuget.org/packages/PokemonTCG.SDK/

## How to use it##

Get all cards

		foreach (Card card in new Cards().All())
        {
			Console.WriteLine(string.Format("Id: {4},Name: {0}, Pokedex Number {1}, Abilitie Name:{2}, desc:{3}",
				card.name,
				card.nationalPokedexNumber,
				card.ability != null ? card.ability.name : "",
				card.ability != null ? card.ability.text : "",
				card.id));
		}
		
Get cards using some filters and pagination

		foreach (Card card in new Cards().Where(name: "pikachu", page: "1", pageSize: "5").All())
		{
			Console.WriteLine(string.Format("Id: {4},Name: {0}, Pokedex Number {1}, Abilitie Name:{2}, desc:{3}",
				card.name,
				card.nationalPokedexNumber,
				card.ability != null ? card.ability.name : "",
				card.ability != null ? card.ability.text : "",
				card.id));
		}

Find card by id

		var cardFind = new Cards().Find("xy7-54");
		
		Console.WriteLine(string.Format("Id: {4},Name: {0}, Pokedex Number {1}, Abilitie Name:{2}, desc:{3}",
			cardFind.name,
			cardFind.nationalPokedexNumber,
			cardFind.ability != null ? cardFind.ability.name : "",
			cardFind.ability != null ? cardFind.ability.text : "",
			cardFind.id
		));

Get all sets

		foreach (Set set in new Sets().All())	
		{
			Console.WriteLine(string.Format("Set Name: {0}, code:{1}, total cards:{2}",
				set.name, set.code, set.totalCards));
		}

Get sets using filters and pagination

		foreach (Set set in new Sets().Where(name:"phantom forces" ,page:"1", pageSize: "5").All())
		{
			Console.WriteLine(string.Format("Set Name: {0}, code:{1}, total cards:{2}",
				set.name, set.code, set.totalCards));
		}

Find set by id
		
		Set setFind = new Sets().Find("xy1");
		Console.WriteLine(string.Format("Set Name: {0}, code:{1}, total cards:{2}", setFind.name, setFind.code, setFind.totalCards));

Types, Subtypes and Supertypes

		Console.WriteLine(string.Join(",", new Types().All()));
		Console.WriteLine(string.Join(",", new Subtypes().All()));
		Console.WriteLine(string.Join(",", new Supertypes().All()));

I need your support. Improve the code and make a pull request.
