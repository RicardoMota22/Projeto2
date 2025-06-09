using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySim
{
    public class Book : IBook
    {
        public string Title { get; }

        public string Author { get; }

        public int Year { get; }
        public bool IsBorrowed { get; }
        public void Borrow()
        {
            
        }
        public void ReturnBook()
        {

        }

        

    }
}