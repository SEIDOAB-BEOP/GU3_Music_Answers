using Helpers;
namespace Music;
class Program
{
    static void Main(string[] args)
    {
        //Create a list of 20 great bands
        var rnd = new csSeedGenerator();
        var _greatMusicBands = new List<IMusicGroup>();

        for (int c = 0; c < 20; c++)
        {
            _greatMusicBands.Add(new csMusicGroup().Seed(rnd));
        }

        foreach (var item in _greatMusicBands)
        {
            Console.WriteLine(item);
            if (item.Members.Count > 0)
            {
                Console.WriteLine($"  - First member is {item.Members[0].FirstName} {item.Members[0].LastName}");
            }
            if (item.Albums.Count > 0)
            {
                Console.WriteLine($"  - First Album is {item.Albums[0].Name} released {item.Albums[0].ReleaseYear}");
            }
        }

        Console.ReadKey();
    }
}

