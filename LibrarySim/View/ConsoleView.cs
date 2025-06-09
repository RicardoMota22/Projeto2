using System.Collections.Generic;
using LibrarySim.Model;
using Spectre.Console;

namespace LibrarySim.View
{
    public class ConsoleView : IView
    {
        public void DisplayWelcomeSign()
        {
            AnsiConsole.Write(
                new FigletText("Library")
                    .Centered()
                    .Color(Color.Green));
        }
        
        public void DisplayBooks(IEnumerable<IBook> books)
        {
            Table table = new Table();
            table.AddColumn("Title");
            table.AddColumn("Author");
            table.AddColumn("Year");
            table.AddColumn("Status");

            foreach (IBook book in books)
            {
                table.AddRow(
                    book.Title,
                    book.Author,
                    book.Year.ToString(),
                    book.IsBorrowed ? "[red]Borrowed[/]" : "[green]Available[/]"
                );
            }

            AnsiConsole.Write(new Panel(table).Header("Books List", Justify.Center));
        }

        public void DisplayBorrowedBooks(IEnumerable<IBook> books)
        {
            Table table = new Table();
            table.AddColumn("Title");
            table.AddColumn("Author");
            table.AddColumn("Year");

            foreach (IBook book in books)
            {
                table.AddRow(book.Title, book.Author, book.Year.ToString());
            }

            AnsiConsole.Write(new Panel(table).Header("Borrowed Books", Justify.Center));
        }

        public void DisplayMessage(string message)
        {
            AnsiConsole.MarkupLine($"[yellow]{message}[/]");
        }

        public string AskForMenuChoice()
        {
            
            List<string> options = new List<string>
            {
                "List all books",
                "Borrow a book",
                "List borrowed books",
                "Return a book",
                "Exit"
            };

            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold]Select an option[/]")
                    .AddChoices(options)
            );
        }

        public string AskForBookTitle(IEnumerable<IBook> availableBooks)
        {
            List<string> titles = new List<string>();
            foreach (IBook book in availableBooks)
            {
                titles.Add(book.Title);
            }

            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select a book title")
                    .AddChoices(titles)
            );
        }


    }

}