
namespace Boggle
{
    public static class GameDictionary
    {
        public static string[] GetWords(string category)
        {
            if (category == "animals")
                return new string[] { "куыдз", "кæсаг", "дзæбидр", "гæды", "уасæг", "бабыз" };

            if (category == "items")
                return new string[] { "ахстон", "хур", "бæлас", "стъалы", "арт", "арв", "дымгæ" };

            if (category == "food")
                return new string[] { "æхсыр", "фæткъуы", "кæрдо", "джитъри", "балджын" };

            return new string[0];
        }
    }
}
