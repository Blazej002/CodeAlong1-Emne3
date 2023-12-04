//Library assistant
//Du skal lage et bibliotek som består av noen ulike bøker av ulike sjangre og med ulike utgivelsesår.
//Brukeren skal ha mulighet til å legge til flere bøker i biblioteket, og liste opp alle bøker i en valgfri sjanger.
//Year
//Genre
//Name

using System.Diagnostics;

namespace CodeAlong;

internal class Program
{
    static void Main()
    {
        var bibliotek = new Bibliotek();
        while (true)
        {
            Console.WriteLine("1. Show all books \n2. Add new book \n3. Search by genre \n4. Exit");
            var userInp = Console.ReadKey().Key;
            Console.WriteLine();

            switch (userInp)
            {
                case ConsoleKey.D1:
                    bibliotek.ShowAllBooks();
                    break;
                case ConsoleKey.D2:
                    AddNewBook(bibliotek);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("What genre?");
                    var search = Console.ReadLine();
                    bibliotek.ShowBooksByGenre(search);
                    break;
                case ConsoleKey.D4:
                    Environment.Exit(0);
                    break;
            }

            Console.Clear();
        }
    }

    private static void AddNewBook(Bibliotek bib)// bib was Added post Codealong
    {
        Console.WriteLine("Whats the book name?");// Added post Codealong
        var newBookName = (string?)Console.ReadLine();
        Console.WriteLine("Whats the book genre?");// Added post Codealong
        var newBookGenre = (string?)Console.ReadLine();
        Console.WriteLine("When was the book made?");// Added post Codealong
        var newBookYear = Console.ReadLine();
        int nby = Convert.ToInt32(newBookYear);

        var newBook = new Book(newBookName, newBookGenre, nby);
        bib.AddBook(newBook);// Added post Codealong /Forgot to add this, but i saw it at the last secund.
    }
}