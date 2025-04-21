
class Program
{
    public static void Main()
    {
        Book[] books = new Book[5];
            
        books[0] = new Book ("1984", "George Orwell", 1949);
        books[1] = new Book ("The Fault in Our Stars", "John Green", 2012);
        books[2] = new Book ("Clean Code", "Robert C. Martin", 2008);
        books[3] = new Book ("War and Peace", "Leo Tolstoy", 1869);
        books[4] = new Book ("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 1979);
        
        newestBooks(books);
        Console.WriteLine();
        findLongestBook(books);
        
        static void newestBooks(Book [] books)
        {
            Console.WriteLine("Все книги, написанные после 2000 года: ");

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Year > 2000)
                {
                    Console.WriteLine(books[i].Title + ", " + books[i].Author);
                }
            }
        }

        static void findLongestBook(Book[] books)
        {
            Console.WriteLine("Книга с самым длинным названием ");

            int longest = books[0].Title.Length;
            Book longestBook = books[0];
        
            for (int i = 1; i < books.Length; i++)
            {
                if (books[i].Title.Length > longest)
                {
                    longest = books[i].Title.Length;
                    longestBook = books[i];
                }
            }
            Console.WriteLine(longestBook.Title + ", " + longestBook.Author);
        }
    }
}

public class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title, string author, int year)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
    }
}