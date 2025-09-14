namespace MusicStoreApp.gui.user;

partial class UserShoppingCartWindow
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
        btn_UpdateItemAmount = new System.Windows.Forms.Button();
        lbl_WindowInfo = new System.Windows.Forms.Label();
        cb_ItemAmount = new System.Windows.Forms.ComboBox();
        btn_Checkout = new System.Windows.Forms.Button();
        btn_CancelAndClose = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        lbl_ItemAmount = new System.Windows.Forms.Label();
        lbl_RemoveItem = new System.Windows.Forms.Label();
        btn_RemoveItem = new System.Windows.Forms.Button();
        lbl_TotalPrice = new System.Windows.Forms.Label();
        lb_ShoppingCartItems = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // btn_UpdateItemAmount
        // 
        btn_UpdateItemAmount.BackColor = System.Drawing.Color.MediumSeaGreen;
        btn_UpdateItemAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_UpdateItemAmount.ForeColor = System.Drawing.Color.Honeydew;
        btn_UpdateItemAmount.Location = new System.Drawing.Point(297, 610);
        btn_UpdateItemAmount.Name = "btn_UpdateItemAmount";
        btn_UpdateItemAmount.Size = new System.Drawing.Size(98, 40);
        btn_UpdateItemAmount.TabIndex = 1;
        btn_UpdateItemAmount.Text = "Update";
        btn_UpdateItemAmount.UseVisualStyleBackColor = false;
        btn_UpdateItemAmount.Click += btn_UpdateItemAmount_Click;
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_WindowInfo.Location = new System.Drawing.Point(40, 60);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(320, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "Check what you\'ve got so far";
        // 
        // cb_ItemAmount
        // 
        cb_ItemAmount.BackColor = System.Drawing.Color.Honeydew;
        cb_ItemAmount.ForeColor = System.Drawing.Color.DarkGreen;
        cb_ItemAmount.FormattingEnabled = true;
        cb_ItemAmount.Location = new System.Drawing.Point(172, 620);
        cb_ItemAmount.Name = "cb_ItemAmount";
        cb_ItemAmount.Size = new System.Drawing.Size(90, 23);
        cb_ItemAmount.TabIndex = 0;
        cb_ItemAmount.SelectedIndexChanged += cb_ItemAmount_SelectedIndexChanged;
        // 
        // btn_Checkout
        // 
        btn_Checkout.BackColor = System.Drawing.Color.PaleGreen;
        btn_Checkout.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Checkout.ForeColor = System.Drawing.Color.DarkGreen;
        btn_Checkout.Location = new System.Drawing.Point(440, 680);
        btn_Checkout.Name = "btn_Checkout";
        btn_Checkout.Size = new System.Drawing.Size(320, 40);
        btn_Checkout.TabIndex = 3;
        btn_Checkout.Text = "Checkout";
        btn_Checkout.UseVisualStyleBackColor = false;
        btn_Checkout.Click += btn_Checkout_Click;
        // 
        // btn_CancelAndClose
        // 
        btn_CancelAndClose.BackColor = System.Drawing.Color.Crimson;
        btn_CancelAndClose.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_CancelAndClose.ForeColor = System.Drawing.Color.Honeydew;
        btn_CancelAndClose.Location = new System.Drawing.Point(820, 680);
        btn_CancelAndClose.Name = "btn_CancelAndClose";
        btn_CancelAndClose.Size = new System.Drawing.Size(320, 40);
        btn_CancelAndClose.TabIndex = 4;
        btn_CancelAndClose.Text = "Cancel and close";
        btn_CancelAndClose.UseVisualStyleBackColor = false;
        btn_CancelAndClose.Click += btn_Cancel_Click;
        // 
        // lbl_WelcomeMessage
        // 
        lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
        lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_WelcomeMessage.ForeColor = System.Drawing.Color.Honeydew;
        lbl_WelcomeMessage.Location = new System.Drawing.Point(40, 31);
        lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
        lbl_WelcomeMessage.Size = new System.Drawing.Size(320, 29);
        lbl_WelcomeMessage.TabIndex = 100;
        lbl_WelcomeMessage.Text = "Shopping cart";
        // 
        // lbl_ItemAmount
        // 
        lbl_ItemAmount.BackColor = System.Drawing.Color.Transparent;
        lbl_ItemAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_ItemAmount.ForeColor = System.Drawing.Color.Honeydew;
        lbl_ItemAmount.Location = new System.Drawing.Point(40, 620);
        lbl_ItemAmount.Name = "lbl_ItemAmount";
        lbl_ItemAmount.Size = new System.Drawing.Size(120, 28);
        lbl_ItemAmount.TabIndex = 103;
        lbl_ItemAmount.Text = "Update amount:";
        // 
        // lbl_RemoveItem
        // 
        lbl_RemoveItem.BackColor = System.Drawing.Color.Transparent;
        lbl_RemoveItem.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_RemoveItem.ForeColor = System.Drawing.Color.Honeydew;
        lbl_RemoveItem.Location = new System.Drawing.Point(37, 690);
        lbl_RemoveItem.Name = "lbl_RemoveItem";
        lbl_RemoveItem.Size = new System.Drawing.Size(254, 20);
        lbl_RemoveItem.TabIndex = 104;
        lbl_RemoveItem.Text = "Remove item from shopping cart";
        // 
        // btn_RemoveItem
        // 
        btn_RemoveItem.BackColor = System.Drawing.Color.MediumSeaGreen;
        btn_RemoveItem.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_RemoveItem.ForeColor = System.Drawing.Color.Honeydew;
        btn_RemoveItem.Location = new System.Drawing.Point(297, 680);
        btn_RemoveItem.Name = "btn_RemoveItem";
        btn_RemoveItem.Size = new System.Drawing.Size(98, 40);
        btn_RemoveItem.TabIndex = 2;
        btn_RemoveItem.Text = "Remove";
        btn_RemoveItem.UseVisualStyleBackColor = false;
        btn_RemoveItem.Click += btn_RemoveItem_Click;
        // 
        // lbl_TotalPrice
        // 
        lbl_TotalPrice.BackColor = System.Drawing.Color.Transparent;
        lbl_TotalPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_TotalPrice.ForeColor = System.Drawing.Color.Honeydew;
        lbl_TotalPrice.Location = new System.Drawing.Point(440, 620);
        lbl_TotalPrice.Name = "lbl_TotalPrice";
        lbl_TotalPrice.Size = new System.Drawing.Size(320, 20);
        lbl_TotalPrice.TabIndex = 105;
        lbl_TotalPrice.Text = "//TODO TotalPrice";
        // 
        // lb_ShoppingCartItems
        // 
        lb_ShoppingCartItems.BackColor = System.Drawing.Color.Honeydew;
        lb_ShoppingCartItems.Font = new System.Drawing.Font("Segoe UI", 10F);
        lb_ShoppingCartItems.FormattingEnabled = true;
        lb_ShoppingCartItems.Location = new System.Drawing.Point(40, 100);
        lb_ShoppingCartItems.Name = "lb_ShoppingCartItems";
        lb_ShoppingCartItems.Size = new System.Drawing.Size(1080, 497);
        lb_ShoppingCartItems.TabIndex = 106;
        // 
        // ShoppingCartWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(lb_ShoppingCartItems);
        Controls.Add(lbl_TotalPrice);
        Controls.Add(btn_RemoveItem);
        Controls.Add(lbl_RemoveItem);
        Controls.Add(lbl_ItemAmount);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_CancelAndClose);
        Controls.Add(btn_Checkout);
        Controls.Add(cb_ItemAmount);
        Controls.Add(lbl_WindowInfo);
        Controls.Add(btn_UpdateItemAmount);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Shopping Cart";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox lb_ShoppingCartItems;

    private System.Windows.Forms.Label lbl_TotalPrice;

    private System.Windows.Forms.Button btn_RemoveItem;

    private System.Windows.Forms.Label lbl_WelcomeMessage;

    private System.Windows.Forms.Button btn_CancelAndClose;

    private System.Windows.Forms.Label lbl_RemoveItem;

    private System.Windows.Forms.Button btn_Checkout;

    private System.Windows.Forms.ComboBox cb_ItemAmount;

    private System.Windows.Forms.Label lbl_WindowInfo;

    private System.Windows.Forms.Label lbl_ItemAmount;

    private System.Windows.Forms.Button btn_UpdateItemAmount;

    #endregion
}