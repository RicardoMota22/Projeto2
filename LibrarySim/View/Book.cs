using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySim.Model;

namespace LibrarySim.View
{
    public class Book : IBook
    {

        public string Title { get; }

        public string Author { get; }

        public int Year { get; }
        public bool IsBorrowed { get; }

        public Book(string title, string author, int year, bool borrowed)
        {
            Title = title;
            Author = author;
            Year = year;
            IsBorrowed = borrowed;
        }
        public void Borrow()
        {
            Console.WriteLine(Title);
        }
        public void ReturnBook()
        {
            Console.WriteLine(Title);
        }

        //Compare if they have the same name
        public IEquatable<Book> GetEquatable(Book other)
        {
            if (other == null) return "";
            if (Equals(other.Title(this.Title)))
            {
                return Title;
            }

            return other.Title;
        }

        public string CompareTo(Book other)
        {
            if (other == null) return "";

            return other.Title;
        }

        //Sort Titles

        public IComparer<Book> GetComparer(Book other)
        {
            if (other == null) return "";
            return;
            
        }

        

    }
}