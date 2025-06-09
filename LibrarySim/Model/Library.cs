
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibrarySim.View;

namespace LibrarySim.Model
{
    public class Library
    {
        private readonly List<IBook> books;

        public Library()
        {
            books = new List<IBook>();
        }

        public void LoadBooks(string file)
        {
            //Implement me
            using StreamReader sr = new StreamReader("books.txt");

            // print content
            while ((file = sr.ReadLine()) != null)
            {
                file.Split(",");
            }
            
            

        }

        public IEnumerable<IBook> GetAllBooks() => books.AsReadOnly();


        public IReadOnlyList<IBook> GetBorrowedBooks()
        {
            List<IBook> borrowedBooks = new List<IBook>();
            foreach (IBook book in books)
            {
                if (book.IsBorrowed)
                {
                    borrowedBooks.Add(book);
                }
            }
            return borrowedBooks.AsReadOnly();
        }

        
        public IReadOnlyList<IBook> GetAvailableBooks()
        {
            List<IBook> availableBooks = new List<IBook>();
            foreach (IBook book in books)
            {
                if (!book.IsBorrowed)
                {
                    availableBooks.Add(book);
                }
            }
            return availableBooks.AsReadOnly();
        }

        public string BorrowBook(string title)
        {

            //Implement me (title of book)
            foreach (Book book in books)
            {
                if (book.IsBorrowed)
                {
                    book.Borrow(); //cant have writelines
                }
            }
            return "";
        }

        public string ReturnBook(string title)
        {
            //Implement me
            foreach (Book book in books)
            {
                if (!book.IsBorrowed)
                {
                    book.ReturnBook();
                }
            } 
            return "";
        }

        public int BookCount => books.Count;
    }
}