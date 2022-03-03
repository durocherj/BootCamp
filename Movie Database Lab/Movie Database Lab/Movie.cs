using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    internal class Movie
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public Movie(string name, string category)
        {
            Name = name;
            Category = category;
        }

    }
}
