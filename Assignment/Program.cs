namespace Assignment
{
    //PART 01
    #region Q01
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", ", Authors)}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price}";
        }
    }
    #endregion

    #region Q02

    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
    #endregion

    //PART 02

    #region PART 02

    // User Defined Delegate
    //public delegate string BookDelegate(Book B);
    //public class LibraryEngine
    //{
    //    public static void ProcessBooks(List<Book> bList, BookDelegate fPtr)
    //    {
    //        foreach (Book B in bList)
    //            Console.WriteLine(fPtr(B));
    //    }
    //} 

    //Built-in Delegate
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, Func<Book , string> fPtr)
        {
            foreach (Book B in bList)
                Console.WriteLine(fPtr(B));
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            // PART 02

            s#region  PART 02

            //List<Book> books = new List<Book>
            //{
            //       new Book("123", "C# Basics", new string[] { "Ali", "Mona" }, DateTime.Now, 150),
            //       new Book("456", "OOP in Depth", new string[] { "Sara" }, DateTime.Now, 200)
            //};

            //// a) User Defined Delegate
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            //// b) Built-in Delegate
            //LibraryEngine.ProcessBooks(books, new Func<Book, string>(BookFunctions.GetAuthors));

            //// c) Anonymous Method
            //LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            //// d) Lambda Expression
            //LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToShortDateString());


            #endregion



        }
    }
}
