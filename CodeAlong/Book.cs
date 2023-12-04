namespace CodeAlong
{
    class Book
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Book(string name, string genre, int year)
        {
            Name= name;
            Genre= genre;
            Year= year;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}\nGenre: {Genre} - Year: {Year}");
        }

    }
}