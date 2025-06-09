using System;
using LibrarySim.Controller;
using LibrarySim.Model;
using LibrarySim.View;

namespace LibrarySim
{
    public class Program
    {
        private static void Main(string[] args)
        {

            if (args.Length < 1)
            {
                Console.WriteLine("Error! command should be: dotnet run --project" +
                " LibrarySim -- books.txt");
                Environment.Exit(-1);
            }

            string filepath = args[0];

            //Implement me
            Library library = new Library();
            ConsoleView view = new ConsoleView();

            LibraryController controller = new LibraryController(library, view);

            controller.Run();


            
        }
    }
}
