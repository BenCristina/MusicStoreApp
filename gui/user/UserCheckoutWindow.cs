using System.Text.RegularExpressions;
using MusicStoreApp.data;

namespace MusicStoreApp.gui.user;

public partial class UserCheckoutWindow : Form
{
    public UserCheckoutWindow()
    {
        InitializeComponent();
        LoadShoppingCart();
        lbl_Address_Updated();

        // Populate the ComboBox with the available payment methods
        cb_ChooseCreditCardProvider.Items.AddRange("Visa", "MasterCard", "American Express");

        cb_ChooseCreditCardProvider.SelectedIndex = 0; // Select the first item (Visa) by default
    }

    private void LoadShoppingCart()
    {
        lb_ItemsToOrder.Items.Clear(); // Clear the ListBox

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

            lb_ItemsToOrder.Items.Add(cartItem); // The overridden ToString() handles the display
        }

        if (DataManager.Instance.ShoppingCartList == null || DataManager.Instance.ShoppingCartList.Count == 0)
            MessageBox.Show("Your shopping cart is empty.", "Empty cart", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
    }

    private void lbl_Address_Updated()
    {
        // Retrieve the logged-in user ID
        var loggedInUserId = DatabaseHandler.userIDFromDatabase;
        Console.WriteLine($"Logged-in User ID at CheckoutWindow: {DatabaseHandler.userIDFromDatabase}"); // Debugging

        // Retrieve the logged-in user info
        if (DataManager.Instance.Users.TryGetValue(loggedInUserId, out var loggedInUser))
        {
            Console.WriteLine(
                $"Logged-in User at CheckoutWindow: {loggedInUser.firstName} {loggedInUser.lastName}"); // Debugging
            lbl_Address.Text =
                $"Name: {loggedInUser.firstName} {loggedInUser.lastName} | Address: {loggedInUser.addressStreet} {loggedInUser.addressNumber}, {loggedInUser.addressZipCode} {loggedInUser.addressCity}";
        }
        else
        {
            Console.WriteLine("Logged-in user object is null."); // Debugging
            lbl_Address.Text = "Welcome!";
        }

        Console.WriteLine("No logged-in user at DataManager.Users."); // Debugging
    }

    public void UpdateAddress(string firstName, string lastName, string addressStreet, string addressNumber,
        string addressZipCode, string addressCity)
    {
        // Update the address in the UI
        lbl_Address.Text =
            $"Name: {firstName} {lastName} | Address: {addressStreet} {addressNumber}, {addressZipCode} {addressCity}";
    }


    private void ValidatePaymentMethod()
    {
    }

    private void btn_UpdateDeliveryAddress_Click(object sender, EventArgs e)
    {
        var loggedInUserId = DatabaseHandler.userIDFromDatabase;
        DataManager.Instance.Users.TryGetValue(loggedInUserId, out var loggedInUser);

        if (loggedInUser != null)
        {
            var deliveryAddressWindow = new UserDeliveryAddressWindow(loggedInUser);

            if (deliveryAddressWindow.ShowDialog() == DialogResult.OK)
            {
                var updatedUser = deliveryAddressWindow.GetUpdatedUserAddress();

                if (updatedUser != null)
                {
                    UpdateAddress(updatedUser.firstName, updatedUser.lastName, updatedUser.addressStreet,
                        updatedUser.addressNumber, updatedUser.addressZipCode, updatedUser.addressCity);

                    if (deliveryAddressWindow.UpdateAccountInDatabase())
                        DatabaseHandler.UpdateUserAddress(updatedUser.ID, updatedUser.addressStreet,
                            updatedUser.addressNumber, updatedUser.addressZipCode, updatedUser.addressCity);
                }
            }
        }
        else
        {
            MessageBox.Show("Unable to retrieve user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btn_CompleteOrder_Click(object sender, EventArgs e)
    {
        // Ensure user checks agreement
        if (!cb_ConfirmOrder.Checked)
        {
            MessageBox.Show("Please confirm that you have read and agree to the terms and conditions.",
                "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Validate payment details
        var isValid = ValidatePaymentDetails();
        if (!isValid)
        {
            MessageBox.Show("Please enter valid payment details.", "Invalid Payment Details", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        // Create the order
        var cart = DataManager.Instance.ShoppingCartList;
        if (cart == null || cart.Count == 0)
        {
            MessageBox.Show("Your shopping cart is empty.", "Empty cart", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        var userId = DatabaseHandler.userIDFromDatabase;
        var orderDate = DateTime.Now;

        try
        {
            // Pass the cart and other details to AddOrder
            DatabaseHandler.AddOrder(userId, orderDate, cart, true, false);

            // Success message
            MessageBox.Show("Your order has been placed successfully.", "Order Placed", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Clear the shopping cart
            DataManager.Instance.ShoppingCartList.Clear();
            LoadShoppingCart();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to complete the order: {ex.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private bool ValidatePaymentDetails()
    {
        // Validate ComboBox Selection
        if (cb_ChooseCreditCardProvider.SelectedItem == null)
        {
            MessageBox.Show("Please select a payment method.", "Invalid Payment Method", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }

        var selectedCardType = cb_ChooseCreditCardProvider.SelectedItem.ToString();
        var cardNumber = tb_CreditCardNumber.Text;

        // Regex for specific card types
        var amexRegex = @"^3[47]\d{14}$"; // American Express
        var visaRegex = @"^4\d{15}?$"; // Visa
        var mastercardRegex = @"^5[1-5]\d{14}$"; // Mastercard

        // Match card number with selected card type
        if ((selectedCardType == "American Express" && !Regex.IsMatch(cardNumber, amexRegex)) ||
            (selectedCardType == "Visa" && !Regex.IsMatch(cardNumber, visaRegex)) ||
            (selectedCardType == "Mastercard" && !Regex.IsMatch(cardNumber, mastercardRegex)))
        {
            MessageBox.Show($"Invalid Credit Card Number for {selectedCardType}. Please check the card number.",
                "Invalid Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Validate name on card
        var nameOnCard = tb_NameOnCard.Text;
        if (!Regex.IsMatch(nameOnCard, @"^[A-Za-z\s]+$"))
        {
            MessageBox.Show("Invalid name on card. Only letters are allowed.", "Invalid name on card",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Validate Expiry Date (MM/YY format)
        var expiryDate = tb_CreditCardExpiryDate.Text;
        if (!Regex.IsMatch(expiryDate, @"^(0[1-9]|1[0-2])\/\d{2}$"))
        {
            MessageBox.Show("Invalid expiry date. Please enter in MM/YY format.", "Invalid expiry date",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Check if expiry date is in the future
        var expiryDateParts = expiryDate.Split('/');
        var month = int.Parse(expiryDateParts[0]);
        var year = int.Parse(expiryDateParts[1]) + 2000; // Convert YY to YYYY
        var expiry = new DateTime(year, month, 1).AddMonths(1).AddDays(-1); // Add one month and subtract one day

        if (expiry < DateTime.Now)
        {
            MessageBox.Show("Your credit card has expired.", "Expired Credit Card", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }

        // Validate Credit Card Verification (CVV)
        var cvv = tb_CreditCardVerificationCode.Text;
        if (!Regex.IsMatch(cvv, @"^\d{3,4}$"))
        {
            MessageBox.Show("Invalid CVV. Please enter a 3-4 digit number.", "Invalid CVV", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }

        return true; // All validation passed :-) 
    }

    private void cb_ChooseCreditCardProvider_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void btn_CancelAndClose_Click(object sender, EventArgs e)
    {
        var shoppingCartWindow = new UserShoppingCartWindow();
        shoppingCartWindow.Show();
        Close();
    }
}