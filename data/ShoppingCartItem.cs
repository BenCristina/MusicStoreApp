using System.Globalization;

namespace MusicStoreApp.data;

public class ShoppingCartItem
{
    public Product Product { get; set; } // Reference to the product
    public int Quantity { get; set; } // Quantity of the product
    public double Subtotal => Product.Price * Quantity; // Calculate Subtotal

    // Override ToString for display in the ListBox
    public override string ToString()
    {
        var euroCulture = new CultureInfo("de-DE");
        return
            $"Artist: {Product.Artist} | Title: {Product.Title} | Year: {Product.ReleaseYear} | Genre: {Product.Genre} | Type: {Product.ProductType} | Price: {Product.Price.ToString("C", euroCulture)} | Quantity: {Quantity} | Subtotal: {Subtotal.ToString("C", euroCulture)}";
    }
}