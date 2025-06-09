using System.Collections.Generic;
using System.Linq;
using LibrarySim.Model;
using LibrarySim.View;

namespace LibrarySim.Controller
{
    public class LibraryController
    {
        private readonly Library library;
        private readonly IView view;

        public LibraryController(Library library, IView view)
        {
            this.library = library;
            this.view = view;
        }

        public void Run()
        {
            view.DisplayWelcomeSign();
            
            bool exit = false;
            while (!exit)
            {
                string choice = view.AskForMenuChoice();
                switch (choice)
                {
                    case "List all books":
                        IEnumerable<IBook> books = library.GetAllBooks();
                        view.DisplayBooks(books);
                        break;
                    case "Borrow a book":
                        IEnumerable<IBook> available = library.GetAvailableBooks();
                        if (available.Count() == 0)
                            view.DisplayMessage("There are no available books");
                        else
                        {
                            string borrowTitle = view.AskForBookTitle(available);
                            view.DisplayMessage(library.BorrowBook(borrowTitle));
                        }
                        break;
                    case "Return a book":
                        IEnumerable<IBook> borrowed = library.GetBorrowedBooks();
                        if (borrowed.Count() == 0)
                            view.DisplayMessage("You have no books to return");
                        else
                        {
                            string returnTitle = view.AskForBookTitle(borrowed);
                            view.DisplayMessage(library.ReturnBook(returnTitle));
                        }
                        break;
                    case "List borrowed books":
                        view.DisplayBorrowedBooks(library.GetBorrowedBooks());
                        break;
                    case "Exit":
                        view.DisplayMessage("Come back anytime!");
                        exit = true;
                        break;
                }
            }
        }
    }
}