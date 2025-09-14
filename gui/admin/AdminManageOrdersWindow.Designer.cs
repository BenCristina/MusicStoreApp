namespace MusicStoreApp.gui.admin;

partial class AdminManageOrdersWindow
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
        lb_OrderList = new System.Windows.Forms.ListBox();
        lbl_WindowInfo = new System.Windows.Forms.Label();
        btn_ShipOrder = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        btn_Shipped = new System.Windows.Forms.Button();
        btn_NotShipped = new System.Windows.Forms.Button();
        tb_SearchOrder = new System.Windows.Forms.TextBox();
        btn_CancelOrder = new System.Windows.Forms.Button();
        btn_ReturnToAdminPanel = new System.Windows.Forms.Button();
        lbl_ProductList = new System.Windows.Forms.ListBox();
        lb_CustomerDetails = new System.Windows.Forms.ListBox();
        btn_PrintOrder = new System.Windows.Forms.Button();
        lbl_Search = new System.Windows.Forms.Label();
        btn_ShowAll = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lb_OrderList
        // 
        lb_OrderList.BackColor = System.Drawing.Color.Honeydew;
        lb_OrderList.FormattingEnabled = true;
        lb_OrderList.Location = new System.Drawing.Point(40, 180);
        lb_OrderList.Name = "lb_OrderList";
        lb_OrderList.Size = new System.Drawing.Size(1100, 259);
        lb_OrderList.TabIndex = 102;
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.Aquamarine;
        lbl_WindowInfo.Location = new System.Drawing.Point(40, 60);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(372, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "You can manage all orders here.";
        lbl_WindowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_ShipOrder
        // 
        btn_ShipOrder.BackColor = System.Drawing.Color.SpringGreen;
        btn_ShipOrder.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShipOrder.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ShipOrder.Location = new System.Drawing.Point(40, 680);
        btn_ShipOrder.Name = "btn_ShipOrder";
        btn_ShipOrder.Size = new System.Drawing.Size(160, 40);
        btn_ShipOrder.TabIndex = 3;
        btn_ShipOrder.Text = "Ship order";
        btn_ShipOrder.UseVisualStyleBackColor = false;
        btn_ShipOrder.Click += btn_ShipOrder_Click;
        // 
        // lbl_WelcomeMessage
        // 
        lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
        lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_WelcomeMessage.ForeColor = System.Drawing.Color.Honeydew;
        lbl_WelcomeMessage.Location = new System.Drawing.Point(40, 40);
        lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
        lbl_WelcomeMessage.Size = new System.Drawing.Size(397, 20);
        lbl_WelcomeMessage.TabIndex = 100;
        lbl_WelcomeMessage.Text = "Welcome to the MusicStore order management system";
        lbl_WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_Shipped
        // 
        btn_Shipped.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_Shipped.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Shipped.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_Shipped.Location = new System.Drawing.Point(40, 130);
        btn_Shipped.Name = "btn_Shipped";
        btn_Shipped.Size = new System.Drawing.Size(120, 40);
        btn_Shipped.TabIndex = 1;
        btn_Shipped.Text = "Shipped";
        btn_Shipped.UseVisualStyleBackColor = false;
        btn_Shipped.Click += btn_Shipped_Click;
        // 
        // btn_NotShipped
        // 
        btn_NotShipped.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_NotShipped.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_NotShipped.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_NotShipped.Location = new System.Drawing.Point(180, 130);
        btn_NotShipped.Name = "btn_NotShipped";
        btn_NotShipped.Size = new System.Drawing.Size(120, 40);
        btn_NotShipped.TabIndex = 2;
        btn_NotShipped.Text = "Not shipped";
        btn_NotShipped.UseVisualStyleBackColor = false;
        btn_NotShipped.Click += btn_NotShipped_Click;
        // 
        // tb_SearchOrder
        // 
        tb_SearchOrder.BackColor = System.Drawing.Color.Honeydew;
        tb_SearchOrder.Location = new System.Drawing.Point(106, 90);
        tb_SearchOrder.Name = "tb_SearchOrder";
        tb_SearchOrder.Size = new System.Drawing.Size(334, 23);
        tb_SearchOrder.TabIndex = 0;
        tb_SearchOrder.Text = "Search";
        // 
        // btn_CancelOrder
        // 
        btn_CancelOrder.BackColor = System.Drawing.Color.Tomato;
        btn_CancelOrder.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_CancelOrder.ForeColor = System.Drawing.Color.Honeydew;
        btn_CancelOrder.Location = new System.Drawing.Point(400, 680);
        btn_CancelOrder.Name = "btn_CancelOrder";
        btn_CancelOrder.Size = new System.Drawing.Size(160, 40);
        btn_CancelOrder.TabIndex = 5;
        btn_CancelOrder.Text = "Cancel order";
        btn_CancelOrder.UseVisualStyleBackColor = false;
        btn_CancelOrder.Click += btn_CancelOrder_Click;
        // 
        // btn_ReturnToAdminPanel
        // 
        btn_ReturnToAdminPanel.BackColor = System.Drawing.Color.Crimson;
        btn_ReturnToAdminPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_ReturnToAdminPanel.ForeColor = System.Drawing.Color.Honeydew;
        btn_ReturnToAdminPanel.Location = new System.Drawing.Point(820, 680);
        btn_ReturnToAdminPanel.Name = "btn_ReturnToAdminPanel";
        btn_ReturnToAdminPanel.Size = new System.Drawing.Size(320, 40);
        btn_ReturnToAdminPanel.TabIndex = 6;
        btn_ReturnToAdminPanel.Text = "Return to Admin Panel";
        btn_ReturnToAdminPanel.UseVisualStyleBackColor = false;
        btn_ReturnToAdminPanel.Click += btn_LogoutAndClose_Click;
        // 
        // lbl_ProductList
        // 
        lbl_ProductList.BackColor = System.Drawing.Color.Honeydew;
        lbl_ProductList.FormattingEnabled = true;
        lbl_ProductList.Location = new System.Drawing.Point(40, 496);
        lbl_ProductList.Name = "lbl_ProductList";
        lbl_ProductList.Size = new System.Drawing.Size(520, 154);
        lbl_ProductList.TabIndex = 103;
        // 
        // lb_CustomerDetails
        // 
        lb_CustomerDetails.BackColor = System.Drawing.Color.Honeydew;
        lb_CustomerDetails.FormattingEnabled = true;
        lb_CustomerDetails.Location = new System.Drawing.Point(620, 496);
        lb_CustomerDetails.Name = "lb_CustomerDetails";
        lb_CustomerDetails.Size = new System.Drawing.Size(520, 154);
        lb_CustomerDetails.TabIndex = 104;
        // 
        // btn_PrintOrder
        // 
        btn_PrintOrder.BackColor = System.Drawing.Color.PaleTurquoise;
        btn_PrintOrder.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_PrintOrder.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_PrintOrder.Location = new System.Drawing.Point(219, 680);
        btn_PrintOrder.Name = "btn_PrintOrder";
        btn_PrintOrder.Size = new System.Drawing.Size(160, 40);
        btn_PrintOrder.TabIndex = 4;
        btn_PrintOrder.Text = "Print order";
        btn_PrintOrder.UseVisualStyleBackColor = false;
        btn_PrintOrder.Click += btn_PrintOrder_Click;
        // 
        // lbl_Search
        // 
        lbl_Search.BackColor = System.Drawing.Color.Transparent;
        lbl_Search.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Search.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Search.Location = new System.Drawing.Point(40, 90);
        lbl_Search.Name = "lbl_Search";
        lbl_Search.Size = new System.Drawing.Size(60, 20);
        lbl_Search.TabIndex = 105;
        lbl_Search.Text = "Search:";
        lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_ShowAll
        // 
        btn_ShowAll.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ShowAll.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowAll.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ShowAll.Location = new System.Drawing.Point(320, 130);
        btn_ShowAll.Name = "btn_ShowAll";
        btn_ShowAll.Size = new System.Drawing.Size(120, 40);
        btn_ShowAll.TabIndex = 106;
        btn_ShowAll.Text = "Show all";
        btn_ShowAll.UseVisualStyleBackColor = false;
        // 
        // AdminManageOrdersWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Teal;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(btn_ShowAll);
        Controls.Add(lbl_Search);
        Controls.Add(btn_PrintOrder);
        Controls.Add(lb_CustomerDetails);
        Controls.Add(lbl_ProductList);
        Controls.Add(btn_ReturnToAdminPanel);
        Controls.Add(btn_CancelOrder);
        Controls.Add(tb_SearchOrder);
        Controls.Add(btn_NotShipped);
        Controls.Add(btn_Shipped);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_ShipOrder);
        Controls.Add(lbl_WindowInfo);
        Controls.Add(lb_OrderList);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        Opacity = 0.95D;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Manage Orders";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_ShowAll;

    private System.Windows.Forms.Label lbl_Search;

    private System.Windows.Forms.Button btn_PrintOrder;

    private System.Windows.Forms.ListBox lbl_ProductList;
    private System.Windows.Forms.ListBox lb_CustomerDetails;

    private System.Windows.Forms.Button btn_ReturnToAdminPanel;

    private System.Windows.Forms.Button btn_NotShipped;
    private System.Windows.Forms.TextBox tb_SearchOrder;

    private System.Windows.Forms.Label lbl_WelcomeMessage;

    private System.Windows.Forms.Button btn_Shipped;

    private System.Windows.Forms.Button btn_ShipOrder;

    private System.Windows.Forms.Label lbl_WindowInfo;

    private System.Windows.Forms.Button btn_CancelOrder;

    private System.Windows.Forms.ListBox lb_OrderList;

    #endregion
}