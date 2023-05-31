namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Harry Potter", "Call of Duty", "Weird West", "Pillars of Eternity", "Binding of Isaac", "Vampire Survivors", "Stray", "Mario 64", "Contra" };
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
