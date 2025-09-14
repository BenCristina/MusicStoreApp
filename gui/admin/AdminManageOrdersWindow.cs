using MusicStoreApp.data;

namespace MusicStoreApp.gui.admin;

public partial class AdminManageOrdersWindow : Form
{
    public AdminManageOrdersWindow()
    {
        InitializeComponent();
        DatabaseHandler.Connect();
        Load += SelectManageOrders_Load;
    }

    private void SelectManageOrders_Load(object? sender, EventArgs e)
    {
        try
        {
            // Load orders from the database
            DatabaseHandler.LoadOrders();

            // Populate the ListBox
            LoadOrdersToListBox();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    public void LoadOrdersToListBox()
    {
        var ordersList = DataManager.Instance?.OrdersList;

        // Debugging output: Check if list is generated
        Console.WriteLine($"Number of orders loaded: {ordersList?.Count ?? 0}");

        if (ordersList == null || ordersList.Count == 0)
        {
            MessageBox.Show("No orders found. DataManager.OrdersList is empty.", "No Orders Found");
            return;
        }

        // Clear the ListBox and display orders
        lb_OrderList.Items.Clear();
        foreach (var orders in ordersList) lb_OrderList.Items.Add(DatabaseHandler.ConvertOrdersToString(orders));
    }

    private void btn_Shipped_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This feature is not yet implemented", "Not Implemented", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        // TODO 
    }

    private void btn_NotShipped_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This feature is not yet implemented", "Not Implemented", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        // TODO
    }

    private void btn_ShipOrder_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This feature is not yet implemented", "Not Implemented", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        // TODO
    }

    private void btn_PrintOrder_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This feature is not yet implemented", "Not Implemented", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        // TODO
    }

    private void btn_CancelOrder_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This feature is not yet implemented", "Not Implemented", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        // TODO 
    }

    private void btn_LogoutAndClose_Click(object sender, EventArgs e)
    {
        Close();
        var adminPanelWindow = new AdminPanelWindow();
        adminPanelWindow.Show();
    }
}