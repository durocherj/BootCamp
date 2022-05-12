using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        public int id { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public bool status { get; set; }
        public string checkedOutDateDate { get; set; }
        public string dueDate { get; set; }  

    }
}
