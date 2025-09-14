using System.Globalization;
using MusicStoreApp.data;

namespace MusicStoreApp.gui.user;

public partial class UserShoppingCartWindow : Form
{
    public UserShoppingCartWindow()
    {
        InitializeComponent();
        FillComboBox(); // Fill the combobox with the available item amounts
        LoadShoppingCart(); // Load the shopping cart
    }

    private void LoadShoppingCart()
    {
        lb_ShoppingCartItems.Items.Clear(); // Clear the ListBox

        foreach (var entry in DataManager.Instance.ShoppingCartList)
        {
            var product = entry.Key; // The product
            var quantity = entry.Value; // The Quantity

            // Create a new ShoppingCartItem and add it to the ListBox
            var cartItem = new ShoppingCartItem
            {
                Product = product,
                Quantity = quantity
            };

            lb_ShoppingCartItems.Items.Add(cartItem); // The overridden ToString() handles the display
        }

        // Display the total Price
        var euroCulture = new CultureInfo("de-DE");
        var totalPrice = DataManager.Instance.ShoppingCartList.Sum(p => p.Key.Price * p.Value);
        lbl_TotalPrice.Text = $"Total: {totalPrice.ToString("C", euroCulture)}";
    }

    private void FillComboBox()
    {
        cb_ItemAmount.Items.Clear(); // Clear any existing items
        for (var i = 1; i <= 10; i++) cb_ItemAmount.Items.Add(i);

        if (cb_ItemAmount.Items.Count > 0) cb_ItemAmount.SelectedItem = 0; // Select the first item by default
    }

    private void cb_ItemAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lb_ShoppingCartItems.SelectedItem != null) // Ensure an item is selected
        {
            var selectedItem = lb_ShoppingCartItems.SelectedItem.ToString();
            var productTitle = selectedItem.Split('|')[0].Trim();

            var product = DataManager.Instance.ProductsList.FirstOrDefault(p => p.Title == productTitle);

            if (product != null && int.TryParse(cb_ItemAmount.SelectedItem?.ToString(), out var newQuantity))
            {
                // Update the Quantity in the shopping cart
                DataManager.Instance.UpdateShoppingCart(product, newQuantity);
                LoadShoppingCart();
                MessageBox.Show($"Quantity updated to {newQuantity} for {product.Artist} | {product.Title}",
                    "Quantity updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Please select an item to update.", "No item selected", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void btn_UpdateItemAmount_Click(object sender, EventArgs e)
    {
        if (lb_ShoppingCartItems.SelectedItem != null)
        {
            var selectedCartItem = (ShoppingCartItem)lb_ShoppingCartItems.SelectedItem; // Use ShoppingCartItem
            if (selectedCartItem != null && cb_ItemAmount.SelectedItem != null)
            {
                var newQuantity = Convert.ToInt32(cb_ItemAmount.SelectedItem); // Get new Quantity
                DataManager.Instance.UpdateShoppingCart(selectedCartItem.Product, newQuantity); // Update in DataManager
                LoadShoppingCart(); // Refresh ListBox
                MessageBox.Show(
                    $"Quantity updated to {newQuantity} for {selectedCartItem.Product.Artist} | {selectedCartItem.Product.Title}",
                    "Quantity Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a valid Quantity.", "Invalid Quantity", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please select an item to update.", "No Item Selected", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void btn_RemoveItem_Click(object sender, EventArgs e)
    {
        if (lb_ShoppingCartItems.SelectedItem != null)
        {
            var selectedCartItem = (ShoppingCartItem)lb_ShoppingCartItems.SelectedItem; // Use ShoppingCartItem
            if (selectedCartItem != null)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to remove {selectedCartItem.Product.Artist} | {selectedCartItem.Product.Title}?",
                    "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataManager.Instance.RemoveFromShoppingCart(selectedCartItem.Product); // Remove from DataManager
                    LoadShoppingCart(); // Reload ListBox
                }
            }
        }
        else
        {
            MessageBox.Show("Please select an item to remove.", "No Item Selected", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void btn_Checkout_Click(object sender, EventArgs e)
    {
        DatabaseHandler.LoadUsers(); // Load users from database

        var euroCulture = new CultureInfo("de-DE");

        if (DataManager.Instance.ShoppingCartList.Count == 0)
            MessageBox.Show("Your shopping cart is empty.", "Empty cart", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        var totalPrice = DataManager.Instance.ShoppingCartList.Sum(p => p.Key.Price * p.Value);

        MessageBox.Show($"Your total is {totalPrice.ToString("C", euroCulture)}! Continue to checkout.", "Checkout",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        var checkoutWindow = new UserCheckoutWindow();
        checkoutWindow.Show();
        Close();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        var selectProductWindow = new UserSelectProductWindow();
        selectProductWindow.Show();
        Close();
    }
}