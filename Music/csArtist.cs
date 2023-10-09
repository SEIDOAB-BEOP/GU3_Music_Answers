using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Helpers;

namespace Music
{
    public interface IArtist
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ToString();

        public IArtist Seed(csSeedGenerator rnd);
    }

    public class csArtist : IArtist
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"Artist {FirstName} {LastName}";

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

