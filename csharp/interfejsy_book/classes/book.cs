namespace Classes;

public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public ushort YearOfPublication { get; set; }
    public double Price { get; set; }

    public Book (string Title, string Author, ushort YearOfPublication, double Price)
    {
        this.Title = Title;
        this.Author = Author;
        this.YearOfPublication = YearOfPublication;
        this.Price = Price;
    }

    public int CompareTo(Book other)
    {
        if (other == null) return 1;
        return Price.CompareTo(other.Price);
    }
    public override string ToString()
    {
        return $"{this.Title} {this.Author} {this.YearOfPublication} {this.Price}";
    }
} 