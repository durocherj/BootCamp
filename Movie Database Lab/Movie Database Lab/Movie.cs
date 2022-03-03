using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    public class Movie
    {
        private string Name;
        private string Category;

        public Movie(string name, string category)
        {
            Name = name;
            Category = category;
        }
        public string GetTitle()
        {
            return Name;
        }
        public string GetCategory()
        {
            return Category;
        }

    }
}
