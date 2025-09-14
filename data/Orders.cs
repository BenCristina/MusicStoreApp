namespace MusicStoreApp.data;

public class Orders
{
    public Orders()
    {
    }

    public Orders(string id, DateTime orderDate, bool paymentStatus, bool shippingStatus, int userID, int productID,
        int orderedItemQuantity, double totalPrice)
    {
        ID = id; // Corrected the assignment
        OrderDate = orderDate; // Corrected assignment and casing
        PaymentStatus = paymentStatus;
        ShippingStatus = shippingStatus;
        UserID = userID;
        ProductID = productID;
        OrderedItemQuantity = orderedItemQuantity;
        TotalPrice = totalPrice;
    }

    public string ID { get; set; } = string.Empty; // Order ID in string format
    public DateTime OrderDate { get; set; } = DateTime.Now; // Corrected the casing
    public bool PaymentStatus { get; set; } = true; // Won't be null
    public bool ShippingStatus { get; set; } = true; // Won't be null
    public int UserID { get; set; } = 1; // Won't be null
    public int ProductID { get; set; } = 1; // Won't be null
    public int OrderedItemQuantity { get; set; } = 1; // Won't be null
    public double TotalPrice { get; set; } = 1.0; // Won't be null
}