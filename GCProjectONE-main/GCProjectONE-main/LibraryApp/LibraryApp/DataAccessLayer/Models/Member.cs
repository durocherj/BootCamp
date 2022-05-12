using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Member
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }    
        public string email { get; set; }
        public bool isActive { get; set; }
        public List<Book> books { get; set; }
    }
}