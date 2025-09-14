namespace MusicStoreApp.data;

public class Favorites
{
    private int userID;
    private int productID;
    private bool isFavorite;
    public Favorites()
    {
    }
    
    public Favorites(int userID, int productID, bool isFavorite)
    {
        this.userID = userID;
        this.productID = productID;
        this.isFavorite = isFavorite;
    }
    
    public int UserID { get; set; }
    public int ProductID { get; set; }
    public bool IsFavorite { get; set;}
}