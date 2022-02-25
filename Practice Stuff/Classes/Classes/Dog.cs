using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    public class Dog
    {
        public double Weight { get; set; }
        public string Breed { get; set; }   
        public int Age { get; set; }    
        public string Size { get; set; }  
        public string Name { get; set; }

        public string Bark()
        {
            return "Woof!";
        }

    }
}
