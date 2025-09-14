using System.Globalization;

namespace MusicStoreApp.data;

public class Product
{
    public Product()
    {
    }

    public Product(int ID, ProductType productType, string artist, string title, Genre genre, int releaseYear,
        double price, int quantity, string imageUrl)
    {
        this.ID = ID;
        ProductType = productType;
        Artist = artist;
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        Price = price;
        Quantity = quantity;
        ImageUrl = imageUrl;
    }

    public int ID { get; set; } = 1; // Won't be null
    public ProductType ProductType { get; set; } = ProductType.CD; // Won't be null
    public string Artist { get; set; } = string.Empty; // Won't be null
    public string Title { get; set; } = string.Empty; // Won't be null
    public Genre Genre { get; set; } = Genre.Rock; // Won't be null
    public int ReleaseYear { get; set; } = 1; // Won't be null
    public double Price { get; set; } = 1.0; // Won't be null
    public int Quantity { get; set; } = 1; // Won't be null
    public string ImageUrl { get; set; } = string.Empty; // Won't be null
    public double Subtotal { get; set; } = 1.0; // Won't be null

    public override string ToString()
    {
        var euroCulture = new CultureInfo("de-DE");
        return
            $"Artist: {Artist} | Title: {Title} | Release Year: {ReleaseYear} | Genre: {Genre} | Type: {ProductType} | Price: {Price.ToString("C", euroCulture)}";
    }
}