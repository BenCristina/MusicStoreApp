namespace MusicStoreApp.gui.user;

partial class UserCheckoutWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lb_ItemsToOrder = new System.Windows.Forms.ListBox();
        btn_CompleteOrder = new System.Windows.Forms.Button();
        lbl_HintCheckOrder = new System.Windows.Forms.Label();
        cb_ChooseCreditCardProvider = new System.Windows.Forms.ComboBox();
        cb_ConfirmOrder = new System.Windows.Forms.CheckBox();
        btn_UpdateDeliveryAddress = new System.Windows.Forms.Button();
        btn_CancelAndClose = new System.Windows.Forms.Button();
        tb_NameOnCard = new System.Windows.Forms.TextBox();
        lbl_CheckOrder = new System.Windows.Forms.Label();
        tb_CreditCardNumber = new System.Windows.Forms.TextBox();
        tb_CreditCardExpiryDate = new System.Windows.Forms.TextBox();
        tb_CreditCardVerificationCode = new System.Windows.Forms.TextBox();
        lbl_PaymentMethod = new System.Windows.Forms.Label();
        lbl_HintPaymentMethod = new System.Windows.Forms.Label();
        lbl_DeliveryAddress = new System.Windows.Forms.Label();
        lbl_HintDeliveryAddress = new System.Windows.Forms.Label();
        lbl_Address = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lb_ItemsToOrder
        // 
        lb_ItemsToOrder.BackColor = System.Drawing.Color.Honeydew;
        lb_ItemsToOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
        lb_ItemsToOrder.FormattingEnabled = true;
        lb_ItemsToOrder.Location = new System.Drawing.Point(40, 100);
        lb_ItemsToOrder.Name = "lb_ItemsToOrder";
        lb_ItemsToOrder.Size = new System.Drawing.Size(1100, 242);
        lb_ItemsToOrder.TabIndex = 104;
        // 
        // btn_CompleteOrder
        // 
        btn_CompleteOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
        btn_CompleteOrder.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_CompleteOrder.ForeColor = System.Drawing.Color.Honeydew;
        btn_CompleteOrder.Location = new System.Drawing.Point(40, 680);
        btn_CompleteOrder.Name = "btn_CompleteOrder";
        btn_CompleteOrder.Size = new System.Drawing.Size(320, 40);
        btn_CompleteOrder.TabIndex = 7;
        btn_CompleteOrder.Text = "Complete order";
        btn_CompleteOrder.UseVisualStyleBackColor = false;
        btn_CompleteOrder.Click += btn_CompleteOrder_Click;
        // 
        // lbl_HintCheckOrder
        // 
        lbl_HintCheckOrder.BackColor = System.Drawing.Color.Transparent;
        lbl_HintCheckOrder.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_HintCheckOrder.Location = new System.Drawing.Point(40, 60);
        lbl_HintCheckOrder.Name = "lbl_HintCheckOrder";
        lbl_HintCheckOrder.Size = new System.Drawing.Size(320, 20);
        lbl_HintCheckOrder.TabIndex = 101;
        lbl_HintCheckOrder.Text = "Your are about to purchase the following items";
        lbl_HintCheckOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // cb_ChooseCreditCardProvider
        // 
        cb_ChooseCreditCardProvider.BackColor = System.Drawing.Color.Honeydew;
        cb_ChooseCreditCardProvider.ForeColor = System.Drawing.Color.DarkGreen;
        cb_ChooseCreditCardProvider.FormattingEnabled = true;
        cb_ChooseCreditCardProvider.Location = new System.Drawing.Point(40, 509);
        cb_ChooseCreditCardProvider.Name = "cb_ChooseCreditCardProvider";
        cb_ChooseCreditCardProvider.Size = new System.Drawing.Size(320, 23);
        cb_ChooseCreditCardProvider.TabIndex = 1;
        cb_ChooseCreditCardProvider.SelectedIndexChanged += cb_ChooseCreditCardProvider_SelectedIndexChanged;
        // 
        // cb_ConfirmOrder
        // 
        cb_ConfirmOrder.BackColor = System.Drawing.Color.Transparent;
        cb_ConfirmOrder.ForeColor = System.Drawing.Color.PaleGreen;
        cb_ConfirmOrder.Location = new System.Drawing.Point(40, 654);
        cb_ConfirmOrder.Name = "cb_ConfirmOrder";
        cb_ConfirmOrder.Size = new System.Drawing.Size(334, 20);
        cb_ConfirmOrder.TabIndex = 6;
        cb_ConfirmOrder.Text = "I confirm that the information provided is correct.";
        cb_ConfirmOrder.UseVisualStyleBackColor = false;
        // 
        // btn_UpdateDeliveryAddress
        // 
        btn_UpdateDeliveryAddress.BackColor = System.Drawing.Color.PaleGreen;
        btn_UpdateDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_UpdateDeliveryAddress.ForeColor = System.Drawing.Color.DarkGreen;
        btn_UpdateDeliveryAddress.Location = new System.Drawing.Point(820, 414);
        btn_UpdateDeliveryAddress.Name = "btn_UpdateDeliveryAddress";
        btn_UpdateDeliveryAddress.Size = new System.Drawing.Size(320, 40);
        btn_UpdateDeliveryAddress.TabIndex = 0;
        btn_UpdateDeliveryAddress.Text = "Update Delivery Address";
        btn_UpdateDeliveryAddress.UseVisualStyleBackColor = false;
        btn_UpdateDeliveryAddress.Click += btn_UpdateDeliveryAddress_Click;
        // 
        // btn_CancelAndClose
        // 
        btn_CancelAndClose.BackColor = System.Drawing.Color.Crimson;
        btn_CancelAndClose.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_CancelAndClose.ForeColor = System.Drawing.Color.Honeydew;
        btn_CancelAndClose.Location = new System.Drawing.Point(820, 680);
        btn_CancelAndClose.Name = "btn_CancelAndClose";
        btn_CancelAndClose.Size = new System.Drawing.Size(320, 40);
        btn_CancelAndClose.TabIndex = 8;
        btn_CancelAndClose.Text = "Cancel and close";
        btn_CancelAndClose.UseVisualStyleBackColor = false;
        btn_CancelAndClose.Click += btn_CancelAndClose_Click;
        // 
        // tb_NameOnCard
        // 
        tb_NameOnCard.BackColor = System.Drawing.Color.Honeydew;
        tb_NameOnCard.Location = new System.Drawing.Point(40, 538);
        tb_NameOnCard.Name = "tb_NameOnCard";
        tb_NameOnCard.Size = new System.Drawing.Size(320, 23);
        tb_NameOnCard.TabIndex = 2;
        tb_NameOnCard.Text = "Enter full name on credit card";
        // 
        // lbl_CheckOrder
        // 
        lbl_CheckOrder.BackColor = System.Drawing.Color.Transparent;
        lbl_CheckOrder.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_CheckOrder.ForeColor = System.Drawing.Color.Honeydew;
        lbl_CheckOrder.Location = new System.Drawing.Point(40, 40);
        lbl_CheckOrder.Name = "lbl_CheckOrder";
        lbl_CheckOrder.Size = new System.Drawing.Size(320, 20);
        lbl_CheckOrder.TabIndex = 100;
        lbl_CheckOrder.Text = "Check your order";
        lbl_CheckOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tb_CreditCardNumber
        // 
        tb_CreditCardNumber.BackColor = System.Drawing.Color.Honeydew;
        tb_CreditCardNumber.Location = new System.Drawing.Point(40, 565);
        tb_CreditCardNumber.Name = "tb_CreditCardNumber";
        tb_CreditCardNumber.Size = new System.Drawing.Size(320, 23);
        tb_CreditCardNumber.TabIndex = 3;
        tb_CreditCardNumber.Text = "Enter credit card number";
        // 
        // tb_CreditCardExpiryDate
        // 
        tb_CreditCardExpiryDate.BackColor = System.Drawing.Color.Honeydew;
        tb_CreditCardExpiryDate.Location = new System.Drawing.Point(40, 594);
        tb_CreditCardExpiryDate.Name = "tb_CreditCardExpiryDate";
        tb_CreditCardExpiryDate.Size = new System.Drawing.Size(320, 23);
        tb_CreditCardExpiryDate.TabIndex = 4;
        tb_CreditCardExpiryDate.Text = "Enter expiry date (mm/yy)";
        // 
        // tb_CreditCardVerificationCode
        // 
        tb_CreditCardVerificationCode.BackColor = System.Drawing.Color.Honeydew;
        tb_CreditCardVerificationCode.Location = new System.Drawing.Point(40, 623);
        tb_CreditCardVerificationCode.Name = "tb_CreditCardVerificationCode";
        tb_CreditCardVerificationCode.Size = new System.Drawing.Size(320, 23);
        tb_CreditCardVerificationCode.TabIndex = 5;
        tb_CreditCardVerificationCode.Text = "Enter CCV";
        // 
        // lbl_PaymentMethod
        // 
        lbl_PaymentMethod.BackColor = System.Drawing.Color.Transparent;
        lbl_PaymentMethod.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_PaymentMethod.ForeColor = System.Drawing.Color.Honeydew;
        lbl_PaymentMethod.Location = new System.Drawing.Point(40, 466);
        lbl_PaymentMethod.Name = "lbl_PaymentMethod";
        lbl_PaymentMethod.Size = new System.Drawing.Size(320, 20);
        lbl_PaymentMethod.TabIndex = 106;
        lbl_PaymentMethod.Text = "Payment method";
        lbl_PaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_HintPaymentMethod
        // 
        lbl_HintPaymentMethod.BackColor = System.Drawing.Color.Transparent;
        lbl_HintPaymentMethod.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_HintPaymentMethod.Location = new System.Drawing.Point(40, 486);
        lbl_HintPaymentMethod.Name = "lbl_HintPaymentMethod";
        lbl_HintPaymentMethod.Size = new System.Drawing.Size(320, 20);
        lbl_HintPaymentMethod.TabIndex = 107;
        lbl_HintPaymentMethod.Text = "Enter your credit card details";
        lbl_HintPaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_DeliveryAddress
        // 
        lbl_DeliveryAddress.BackColor = System.Drawing.Color.Transparent;
        lbl_DeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_DeliveryAddress.ForeColor = System.Drawing.Color.Honeydew;
        lbl_DeliveryAddress.Location = new System.Drawing.Point(40, 360);
        lbl_DeliveryAddress.Name = "lbl_DeliveryAddress";
        lbl_DeliveryAddress.Size = new System.Drawing.Size(320, 20);
        lbl_DeliveryAddress.TabIndex = 102;
        lbl_DeliveryAddress.Text = "Delivery address";
        lbl_DeliveryAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_HintDeliveryAddress
        // 
        lbl_HintDeliveryAddress.BackColor = System.Drawing.Color.Transparent;
        lbl_HintDeliveryAddress.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_HintDeliveryAddress.Location = new System.Drawing.Point(40, 380);
        lbl_HintDeliveryAddress.Name = "lbl_HintDeliveryAddress";
        lbl_HintDeliveryAddress.Size = new System.Drawing.Size(320, 20);
        lbl_HintDeliveryAddress.TabIndex = 103;
        lbl_HintDeliveryAddress.Text = "Your order will be shipped to";
        lbl_HintDeliveryAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_Address
        // 
        lbl_Address.BackColor = System.Drawing.Color.Honeydew;
        lbl_Address.Font = new System.Drawing.Font("Segoe UI", 10F);
        lbl_Address.ForeColor = System.Drawing.SystemColors.WindowText;
        lbl_Address.Location = new System.Drawing.Point(40, 415);
        lbl_Address.Name = "lbl_Address";
        lbl_Address.Size = new System.Drawing.Size(750, 37);
        lbl_Address.TabIndex = 108;
        lbl_Address.Text = "Delivery address";
        lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CheckoutWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(lbl_Address);
        Controls.Add(lbl_DeliveryAddress);
        Controls.Add(lbl_HintDeliveryAddress);
        Controls.Add(lbl_HintPaymentMethod);
        Controls.Add(lbl_PaymentMethod);
        Controls.Add(tb_CreditCardVerificationCode);
        Controls.Add(tb_CreditCardExpiryDate);
        Controls.Add(tb_CreditCardNumber);
        Controls.Add(lbl_CheckOrder);
        Controls.Add(tb_NameOnCard);
        Controls.Add(btn_CancelAndClose);
        Controls.Add(btn_UpdateDeliveryAddress);
        Controls.Add(cb_ConfirmOrder);
        Controls.Add(cb_ChooseCreditCardProvider);
        Controls.Add(lbl_HintCheckOrder);
        Controls.Add(btn_CompleteOrder);
        Controls.Add(lb_ItemsToOrder);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Checkout";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lbl_Address;
    private System.Windows.Forms.TextBox tb_CreditCardExpiryDate;
    private System.Windows.Forms.TextBox tb_CreditCardVerificationCode;
    private System.Windows.Forms.Label lbl_DeliveryAddress;
    private System.Windows.Forms.Label lbl_HintDeliveryAddress;
    private System.Windows.Forms.TextBox tb_CreditCardNumber;
    private System.Windows.Forms.Label lbl_CheckOrder;
    private System.Windows.Forms.TextBox tb_NameOnCard;
    private System.Windows.Forms.Button btn_CancelAndClose;
    private System.Windows.Forms.Label lbl_HintPaymentMethod;
    private System.Windows.Forms.Button btn_UpdateDeliveryAddress;
    private System.Windows.Forms.CheckBox cb_ConfirmOrder;
    private System.Windows.Forms.ComboBox cb_ChooseCreditCardProvider;
    private System.Windows.Forms.Label lbl_HintCheckOrder;
    private System.Windows.Forms.Label lbl_PaymentMethod;
    private System.Windows.Forms.Button btn_CompleteOrder;
    private System.Windows.Forms.ListBox lb_ItemsToOrder;
    #endregion
}