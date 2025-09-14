namespace MusicStoreApp.gui.admin;

partial class AdminPanelWindow
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
        btn_ManageProducts = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        lbl_WindowInfo = new System.Windows.Forms.Label();
        btn_LogoutAndClose = new System.Windows.Forms.Button();
        btn_ManageUsers = new System.Windows.Forms.Button();
        btn_ManageOrders = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btn_ManageProducts
        // 
        btn_ManageProducts.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ManageProducts.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ManageProducts.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ManageProducts.Location = new System.Drawing.Point(240, 350);
        btn_ManageProducts.Name = "btn_ManageProducts";
        btn_ManageProducts.Size = new System.Drawing.Size(320, 40);
        btn_ManageProducts.TabIndex = 0;
        btn_ManageProducts.Text = "Manage products";
        btn_ManageProducts.UseVisualStyleBackColor = false;
        btn_ManageProducts.Click += btn_ManageProducts_Click;
        // 
        // lbl_WelcomeMessage
        // 
        lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
        lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_WelcomeMessage.ForeColor = System.Drawing.Color.Aquamarine;
        lbl_WelcomeMessage.Location = new System.Drawing.Point(240, 290);
        lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
        lbl_WelcomeMessage.Size = new System.Drawing.Size(320, 20);
        lbl_WelcomeMessage.TabIndex = 100;
        lbl_WelcomeMessage.Text = "Welcome, //TODO FirstName";
        lbl_WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.Honeydew;
        lbl_WindowInfo.Location = new System.Drawing.Point(240, 310);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(320, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "Choose from the options below";
        lbl_WindowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_LogoutAndClose
        // 
        btn_LogoutAndClose.BackColor = System.Drawing.Color.Crimson;
        btn_LogoutAndClose.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_LogoutAndClose.ForeColor = System.Drawing.Color.Honeydew;
        btn_LogoutAndClose.Location = new System.Drawing.Point(620, 410);
        btn_LogoutAndClose.Name = "btn_LogoutAndClose";
        btn_LogoutAndClose.Size = new System.Drawing.Size(320, 40);
        btn_LogoutAndClose.TabIndex = 3;
        btn_LogoutAndClose.Text = "Logout and close";
        btn_LogoutAndClose.UseVisualStyleBackColor = false;
        btn_LogoutAndClose.Click += btn_LogoutAndClose_Click;
        // 
        // btn_ManageUsers
        // 
        btn_ManageUsers.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ManageUsers.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ManageUsers.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ManageUsers.Location = new System.Drawing.Point(620, 350);
        btn_ManageUsers.Name = "btn_ManageUsers";
        btn_ManageUsers.Size = new System.Drawing.Size(320, 40);
        btn_ManageUsers.TabIndex = 1;
        btn_ManageUsers.Text = "Manage users";
        btn_ManageUsers.UseVisualStyleBackColor = false;
        btn_ManageUsers.Click += btn_ManageUsers_Click;
        // 
        // btn_ManageOrders
        // 
        btn_ManageOrders.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ManageOrders.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ManageOrders.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ManageOrders.Location = new System.Drawing.Point(240, 410);
        btn_ManageOrders.Name = "btn_ManageOrders";
        btn_ManageOrders.Size = new System.Drawing.Size(320, 40);
        btn_ManageOrders.TabIndex = 2;
        btn_ManageOrders.Text = "Manage orders";
        btn_ManageOrders.UseVisualStyleBackColor = false;
        btn_ManageOrders.Click += btn_ManageOrders_Click;
        // 
        // AdminPanelWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Teal;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(btn_ManageOrders);
        Controls.Add(btn_ManageUsers);
        Controls.Add(btn_LogoutAndClose);
        Controls.Add(lbl_WindowInfo);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_ManageProducts);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        Opacity = 0.95D;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Admin Main Window";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btn_ManageOrders;

    private System.Windows.Forms.Button btn_ManageUsers;

    private System.Windows.Forms.Button btn_LogoutAndClose;

    private System.Windows.Forms.Label lbl_WindowInfo;

    private System.Windows.Forms.Button btn_ManageProducts;

    private System.Windows.Forms.Label lbl_WelcomeMessage;

    #endregion
}