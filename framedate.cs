using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
using System.Threading;

namespace RutonyChat {


	


public static class CharacterConfigLoader
{
    public static JObject LoadCharactersConfig()
    {
        string filepath = Path.Combine(base_path, "resources", "character_misc.json");
        string contents = File.ReadAllText(filepath);
        JObject chara_misc_json = JsonConvert.DeserializeObject<JObject>(contents);
        return chara_misc_json;
    }

    public static string CorrectCharacterName(string alias)
    {
        if (const.CHARACTER_ALIAS.ContainsKey(alias))
        {
            return alias;
        }

        foreach (var pair in const.CHARACTER_ALIAS)
        {
            if (pair.Value.Contains(alias))
            {
                return pair.Key;
            }
        }

        return null;
    }
}

namespace RutonyChat {
   
   public class Script {
	   
	   	
	public class dictionary 
	{	
		public string name { get; set; }
		public string proper_name { get; set; }
		public string local_json { get; set; }
	{

	public class Move
	{
		public string Alias[] { get; set; } 
		public string BlockFrame { get; set; }
		public string Command { get; set; }
		public string CounterHitFrame { get; set; }
		public string Damage { get; set; }
		public string Gif { get; set; }
		public string HitFrame { get; set; }
		public string HitLevel { get; set; }
		public string Notes { get; set; }
		public string StartUpFrame { get; set; }
		public List<string> Tags { get; set; }
	}

	public class RootObject
	{
		public List<Move> Moves { get;set;}
	}
	
	dictionary? discitonary = 
                JsonSerializer.Deserialize<dictionary>(jsonString);	
		
	public void RunScript(string site, string username, string text, string param)
	{
		
		
        
		
		

			

        }
    }
}
