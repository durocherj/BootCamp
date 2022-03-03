using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    internal class Movie
    {
        private string Name { get; set; }
        private string Category { get; set; }

        public Movie(string name, string category)
        {
            Name = name;
            Category = category;
        }

    }
}
