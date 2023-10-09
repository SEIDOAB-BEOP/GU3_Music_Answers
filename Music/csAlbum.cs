using System;
using System.Collections.Generic;
using Helpers;

namespace Music
{
    public interface IAlbum
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }

        public IAlbum Seed(csSeedGenerator rnd);
    }

    public class csAlbum : IAlbum
	{
        public string Name { get; set; }
		public int ReleaseYear { get; set; }

        public csAlbum()
		{
		}
        public IAlbum Seed(csSeedGenerator rnd)
        {
            this.Name = rnd.MusicAlbum;
            this.ReleaseYear = rnd.Next(1970, 1990);

            return this;
        }
    }
}

