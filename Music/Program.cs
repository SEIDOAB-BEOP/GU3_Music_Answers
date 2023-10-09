using Helpers;
namespace Music;
class Program
{
    static void Main(string[] args)
    {
        var rnd = new csSeedGenerator();

        var _greatMusicBands = new List<IMusicGroup>();
        var _greatMusicArtists = new List<IArtist>();
        var _greatMusicAlbums = new List<IAlbum>();

        #region Seed a list of 2 MusicGroups, 2 Artists, 2 Albums
        for (int c = 0; c < 2; c++)
        {
            _greatMusicBands.Add(new csMusicGroup().Seed(rnd));
        }
        for (int c = 0; c < 2; c++)
        {
            _greatMusicArtists.Add(new csArtist().Seed(rnd));
        }
        for (int c = 0; c < 2; c++)
        {
            _greatMusicAlbums.Add(new csAlbum().Seed(rnd));
        }
        #endregion

        PresentMusicBands(_greatMusicBands);
        PresentMusicArtists(_greatMusicArtists);
        PresentMusicAlbums(_greatMusicAlbums);

        Console.ReadKey();
    }

    private static void PresentMusicAlbums(List<IAlbum> _greatMusicAlbums)
    {
        Console.WriteLine("\nGreat Music Albums");
        foreach (var item in _greatMusicAlbums)
        {
            Console.WriteLine(item);
        }
    }

    private static void PresentMusicArtists(List<IArtist> _greatMusicArtists)
    {
        Console.WriteLine("\nGreat Music Artists");
        foreach (var item in _greatMusicArtists)
        {
            Console.WriteLine(item);
        }
    }

    private static void PresentMusicBands(List<IMusicGroup> _greatMusicBands)
    {
        Console.WriteLine("\nGreat Music Bands");
        foreach (var item in _greatMusicBands)
        {
            Console.WriteLine(item);
            if (item.Members.Count > 0)
            {
                Console.WriteLine($"  - First member is {item.Members[0].FirstName} {item.Members[0].LastName}");
            }
            else
            {
                Console.WriteLine("   - No Members in the group");
            }
            if (item.Albums.Count > 0)
            {
                Console.WriteLine($"  - First Album is {item.Albums[0].Name} released {item.Albums[0].ReleaseYear}");
            }
            else
            {
                Console.WriteLine("  - No Albums released by the group");
            }
        }
    }
}

/* Exercises
1. Implement IMusicGroup in a class csMusicGroup
2. Implement IArtist in a class csArtist
3. Implement IAlbum in a class csAlbum
4. Seed a list of 2 MusicGroups, 2 Artists, 2 Albums

5. Seed 5 MusicGroups with 1 - 5 Members and 2 - 5 Albums
6. Refractor so the seeding of Members and Albums is made by Seed() in the MusicGroup
 */


