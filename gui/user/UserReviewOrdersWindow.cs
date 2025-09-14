using MusicStoreApp.data;

namespace MusicStoreApp.gui.user;

public partial class UserReviewOrdersWindow : Form
{
    public UserReviewOrdersWindow()
    {
        InitializeComponent();
        Load += ReviewOrdersWindow_Load; // Load event handler
    }

    private void ReviewOrdersWindow_Load(object? sender, EventArgs e)
    {
        LoadUserOrder();
    }

    private void LoadUserOrder()
    {
        lb_OrdersList.Items.Clear(); // Clears the list of orders

        var loggedInUserID = DatabaseHandler.userIDFromDatabase; // Get logged-in user

        var userOrders =
            DataManager.Instance.OrdersList.Where(order => order.UserID == loggedInUserID)
                .ToList(); // Get all orders of logged-in user

        if (userOrders.Count == 0)
        {
            lb_OrdersList.Items.Add("No orders found");
            return;
        }

        foreach (var order in userOrders) lb_OrdersList.Items.Add(DatabaseHandler.ConvertOrdersToString(order));
    }


    private void lb_OrdersList_SelectedIndexChanged(object? sender, EventArgs e)
    {
        // Handle item selection if needed
        var selectedItem = lb_OrdersList.SelectedItem?.ToString();
        if (selectedItem != null) MessageBox.Show($"Selected Order: {selectedItem}");
    }

    private void btn_CancelCurrentOrder_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("This feature is not yet implemented.", "Not Implemented", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void btn_Cancel_Click(object? sender, EventArgs e)
    {
        var userMainWindow = new UserMainWindow();
        userMainWindow.Show();
        Close();
    }
}