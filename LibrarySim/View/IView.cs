using System.Collections.Generic;
using LibrarySim.Model;

namespace LibrarySim.View
{

    public interface IView
    {
        public void DisplayWelcomeSign();
        public void DisplayBooks(IEnumerable<IBook> books);
        public void DisplayBorrowedBooks(IEnumerable<IBook> books);
        public void DisplayMessage(string message);
        public string AskForMenuChoice();
        public string AskForBookTitle(IEnumerable<IBook> availableBooks);

    }

}