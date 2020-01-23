using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfRevision
{
    abstract class Band
    {
        //properties
        public string Name { get; set; }
        public int Year { get; set; }
        public string Members { get; set; }

        public string Albums { get; set; }

        //constructors

        public Band(string name, int year, string members, string albums)
        {
            Name = name;
            Year = year;
            Members = members;
            Albums = albums;
        }

        public class RockBand : Band
        {
            public RockBand()
            {
                Albums = new Album[10];
            }

            public override string ToString()
            {
                return (this.Name + " - Rock");
            }

        }

        public class PopBand : Band
        {
            public PopBand()
            {
                Albums = new Album[10];
            }

            public override string ToString()
            {
                return (this.Name + " - Pop");
            }

        }

        public class IndieBand : Band
        {
            public IndieBand()
            {
                Albums = new Album[10];
            }

            public override string ToString()
            {
                return (this.Name + " - Indie");
            }

        }


        //methods
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
