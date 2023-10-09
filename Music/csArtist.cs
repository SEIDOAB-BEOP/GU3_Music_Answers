using System;
using System.Collections.Generic;
using Helpers;

namespace Music
{
    public interface IArtist
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IArtist Seed(csSeedGenerator rnd);
    }

    public class csArtist : IArtist
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public csArtist()
		{
		}

        public IArtist Seed(csSeedGenerator rnd)
        {
            this.FirstName = rnd.FirstName;
            this.LastName = rnd.LastName;

            return this;
        }
    }
}

