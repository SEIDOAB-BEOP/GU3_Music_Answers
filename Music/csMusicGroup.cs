using System;
using System.Collections.Generic;

using Helpers;

namespace Music
{
    public interface IMusicGroup
    {
        public string Name { get; set; }
        public int EstablishedYear { get; set; }

        public List<IArtist> Members { get; set; }
        public List<IAlbum> Albums { get; set; }

        public IMusicGroup Seed(csSeedGenerator rnd);
    }

	public class csMusicGroup : IMusicGroup
	{
		public string Name { get; set; }
		public int EstablishedYear { get; set; }

        public List<IArtist> Members { get; set; } = new List<IArtist>();
        public List<IAlbum> Albums { get; set; } = new List<IAlbum>();

        public override string ToString() =>
            $"{Name} with {Members.Count} members was esblished {EstablishedYear} and made {Albums.Count} great albums. ";

        public csMusicGroup()
		{
		}

        public IMusicGroup Seed(csSeedGenerator rnd)
        {
            /*
            //Create between 3 and 8 Members
            for (int i = 3; i < rnd.Next(4, 9); i++)
            {
                this.Members.Add(new csArtist().Seed(rnd));
            }

            //Create between 5 and 16 Albums

            for (int i = 5; i < rnd.Next(6, 17); i++)
            {
                this.Albums.Add(new csAlbum().Seed(rnd));
            }
            */
            EstablishedYear = rnd.Next(1970, 2010);
            Name = rnd.MusicBand;

            return this;
        }
    }
}

