using System.Xml.Linq;

namespace CodeAlong
{
    internal class Bibliotek
    {
        public List<Book> Books;

        public Bibliotek()
        {
            Books = new List<Book>();
            Books.Add(new Book("New book", "Sci-fi", 2002));
            Books.Add(new Book("New book 2", "Romace", 1998));
        }


        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void ShowAllBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine($"{Books[i].Name} -- Genre: {Books[i].Genre} - Year: {Books[i].Year}");
            }
        }

        public void ShowBooksByGenre(string search)
        {
            var GenreList = new List<Book>();

            foreach (var book in Books)
            {
                if (book.Genre == search)
                {
                    GenreList.Add(book);
                }
            }

            foreach (var book in GenreList)
            {
                book.ShowInfo();//Post codeAlong
                //Console.WriteLine($"{book.Name} -- Genre: {book.Genre} - Year: {book.Year}");//Original
            }
        }
    }
}
