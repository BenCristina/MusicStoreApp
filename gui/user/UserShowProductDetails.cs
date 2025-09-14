using System.Globalization;
using MusicStoreApp.data;

namespace MusicStoreApp;

public partial class UserShowProductDetails : Form
{
    public UserShowProductDetails(Product product)
    {
        InitializeComponent();
        DatabaseHandler.Connect();
        PrintDetails(product);
    }

    public UserShowProductDetails()
    {
    }

    private void PrintDetails(Product product)
    {
        lbl_ArtistName.Text = product.Artist;
        lbl_Title.Text = product.Title;
        lbl_ReleaseYear.Text = "Year: " + product.ReleaseYear;
        lbl_Genre.Text = "Genre: " + product.Genre;
        lbl_ProductType.Text = "Type: " + product.ProductType;
        lbl_Price.Text =
            "Price: " + product.Price.ToString("C", CultureInfo.GetCultureInfo("de-DE")); // German currency format
        pb_CoverArtwork.ImageLocation = product.ImageUrl;
    }

    private void btn_Close_Click(object sender, EventArgs e)
    {
        Close();
    }
}