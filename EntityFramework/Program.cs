namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddBook(new Book
            //{
            //    Name = "Salam",
            //    SalePrice = 5,
            //    CostPrice = 6,
            //    GenreId = 1,
            //    Genres = new Genre() { Name = "Salam verir"}
            //});

            //AddBook(new Book
            //{
            //    Name = "Sagol",
            //    SalePrice = 9,
            //    CostPrice = 7,
            //    GenreId = 2,
            //    Genres = new Genre() { Name = "Sagol edir"}
            //});

            Console.WriteLine(GetGenre(2));

        }
        public static void AddBook(Book book)
        {
            AppDbContext newDb = new AppDbContext();
            newDb.Books.Add(book);
            newDb.SaveChanges();

        }
        public static void AddGenre(Genre genre)
        {
            AppDbContext newDb = new AppDbContext();
            newDb.Genres.Add(genre);
            newDb.SaveChanges();
        }
        public static Genre GetGenre(int id)
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Genres.FirstOrDefault(x => x.Id == id);
        }
        public static Book GetBook(int id)
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Books.FirstOrDefault(x => x.Id == id);
        }
        public static List<Genre> GetAllGenres()
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Genres.ToList();
        }
        public static List<Book> GetAllBooks()
        {
            AppDbContext newDb = new AppDbContext();
            return newDb.Books.ToList();
        }
        public static void RemoveGenre(int id)
        {
            AppDbContext newDb = new AppDbContext();
            var genre = GetGenre(id);
            if (genre != null) throw new Exception("Genre is not found");
            newDb.Genres.Remove(genre);
            newDb.SaveChanges();

        }   
        public static void RemoveBook(int id)
        {
            AppDbContext newDb = new AppDbContext();
            var book = GetBook(id);
            if (book != null) throw new Exception("Genre is not found");
            newDb.Books.Remove(book);
            newDb.SaveChanges();

        }
        public static void UpdateGenre(int id, Genre genre)
        {
            AppDbContext newDb = new AppDbContext();
            var existgenre = GetGenre(id);
            if (genre != null) throw new Exception("Genre is not found");
            existgenre.Name = genre.Name;
            newDb.SaveChanges();

        }
        public static void UpdateBook(int id, Book book)
        {
            AppDbContext newDb = new AppDbContext();
            var existbook = GetBook(id);
            if (book != null) throw new Exception("Genre is not found");
            existbook.Name = book.Name;
            newDb.SaveChanges();

        }
    }
}
