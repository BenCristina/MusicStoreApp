namespace MusicStoreApp.gui.user;  partial class UserMainWindow {     /// <summary>     ///  Required designer variable.     /// </summary>     private System.ComponentModel.IContainer components = null;      /// <summary>     ///  Clean up any resources being used.     /// </summary>     /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>     protected override void Dispose(bool disposing)     {         if (disposing && (components != null))         {             components.Dispose();         }          base.Dispose(disposing);     }      #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btn_Logout = new System.Windows.Forms.Button();
        lbl_WindowInfo = new System.Windows.Forms.Label();
        btn_BrowseProducts = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        btn_PastOrders = new System.Windows.Forms.Button();
        btn_Favorites = new System.Windows.Forms.Button();
        btn_AccountDetails = new System.Windows.Forms.Button();
        btn_ShoppingCart = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btn_Logout
        // 
        btn_Logout.BackColor = System.Drawing.Color.Crimson;
        btn_Logout.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Logout.ForeColor = System.Drawing.Color.Honeydew;
        btn_Logout.Location = new System.Drawing.Point(620, 420);
        btn_Logout.Name = "btn_Logout";
        btn_Logout.Size = new System.Drawing.Size(320, 40);
        btn_Logout.TabIndex = 6;
        btn_Logout.Text = "Logout";
        btn_Logout.UseVisualStyleBackColor = false;
        btn_Logout.Click += btn_Logout_Click;
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_WindowInfo.Location = new System.Drawing.Point(240, 260);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(320, 20);
        lbl_WindowInfo.TabIndex = 3;
        lbl_WindowInfo.Text = "Choose from the options below";
        // 
        // btn_BrowseProducts
        // 
        btn_BrowseProducts.BackColor = System.Drawing.Color.PaleGreen;
        btn_BrowseProducts.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_BrowseProducts.ForeColor = System.Drawing.Color.DarkGreen;
        btn_BrowseProducts.Location = new System.Drawing.Point(240, 300);
        btn_BrowseProducts.Name = "btn_BrowseProducts";
        btn_BrowseProducts.Size = new System.Drawing.Size(320, 40);
        btn_BrowseProducts.TabIndex = 1;
        btn_BrowseProducts.Text = "Browse products";
        btn_BrowseProducts.UseVisualStyleBackColor = false;
        btn_BrowseProducts.Click += btn_BrowseProducts_Click;
        // 
        // lbl_WelcomeMessage
        // 
        lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
        lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_WelcomeMessage.ForeColor = System.Drawing.Color.Honeydew;
        lbl_WelcomeMessage.Location = new System.Drawing.Point(240, 241);
        lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
        lbl_WelcomeMessage.Size = new System.Drawing.Size(320, 20);
        lbl_WelcomeMessage.TabIndex = 14;
        lbl_WelcomeMessage.Text = "Welcome!";
        // 
        // btn_PastOrders
        // 
        btn_PastOrders.BackColor = System.Drawing.Color.PaleGreen;
        btn_PastOrders.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_PastOrders.ForeColor = System.Drawing.Color.DarkGreen;
        btn_PastOrders.Location = new System.Drawing.Point(620, 360);
        btn_PastOrders.Name = "btn_PastOrders";
        btn_PastOrders.Size = new System.Drawing.Size(320, 40);
        btn_PastOrders.TabIndex = 4;
        btn_PastOrders.Text = "Past orders";
        btn_PastOrders.UseVisualStyleBackColor = false;
        btn_PastOrders.Click += btn_PastOrders_Click;
        // 
        // btn_Favorites
        // 
        btn_Favorites.BackColor = System.Drawing.Color.PaleGreen;
        btn_Favorites.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Favorites.ForeColor = System.Drawing.Color.DarkGreen;
        btn_Favorites.Location = new System.Drawing.Point(240, 360);
        btn_Favorites.Name = "btn_Favorites";
        btn_Favorites.Size = new System.Drawing.Size(320, 40);
        btn_Favorites.TabIndex = 3;
        btn_Favorites.Text = "Favorites";
        btn_Favorites.UseVisualStyleBackColor = false;
        btn_Favorites.Click += btn_Favorites_Click;
        // 
        // btn_AccountDetails
        // 
        btn_AccountDetails.BackColor = System.Drawing.Color.PaleGreen;
        btn_AccountDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_AccountDetails.ForeColor = System.Drawing.Color.DarkGreen;
        btn_AccountDetails.Location = new System.Drawing.Point(240, 420);
        btn_AccountDetails.Name = "btn_AccountDetails";
        btn_AccountDetails.Size = new System.Drawing.Size(320, 40);
        btn_AccountDetails.TabIndex = 5;
        btn_AccountDetails.Text = "Account details";
        btn_AccountDetails.UseVisualStyleBackColor = false;
        btn_AccountDetails.Click += btn_AccountDetails_Click;
        // 
        // btn_ShoppingCart
        // 
        btn_ShoppingCart.BackColor = System.Drawing.Color.PaleGreen;
        btn_ShoppingCart.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShoppingCart.ForeColor = System.Drawing.Color.DarkGreen;
        btn_ShoppingCart.Location = new System.Drawing.Point(620, 300);
        btn_ShoppingCart.Name = "btn_ShoppingCart";
        btn_ShoppingCart.Size = new System.Drawing.Size(320, 40);
        btn_ShoppingCart.TabIndex = 2;
        btn_ShoppingCart.Text = "Shopping cart";
        btn_ShoppingCart.UseVisualStyleBackColor = false;
        btn_ShoppingCart.Click += btn_ShoppingCart_Click;
        // 
        // UserMainWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(btn_ShoppingCart);
        Controls.Add(btn_AccountDetails);
        Controls.Add(btn_Favorites);
        Controls.Add(btn_PastOrders);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_BrowseProducts);
        Controls.Add(lbl_WindowInfo);
        Controls.Add(btn_Logout);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Main Window";
        ResumeLayout(false);
    }      private System.Windows.Forms.Button btn_ShoppingCart;      private System.Windows.Forms.Button btn_PastOrders;     private System.Windows.Forms.Button btn_Favorites;     private System.Windows.Forms.Button btn_AccountDetails;      private System.Windows.Forms.Label lbl_WelcomeMessage;      private System.Windows.Forms.Button btn_BrowseProducts;      private System.Windows.Forms.Label lbl_WindowInfo;      private System.Windows.Forms.Button btn_Logout;      #endregion }
