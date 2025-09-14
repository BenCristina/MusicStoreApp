namespace MusicStoreApp.gui.user;

partial class UserReviewOrdersWindow
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
        lb_OrdersList = new System.Windows.Forms.ListBox();
        btn_CancelCurrentOrder = new System.Windows.Forms.Button();
        lbl_DescriptionOrders = new System.Windows.Forms.Label();
        btn_Close = new System.Windows.Forms.Button();
        lbl_Orders = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lb_OrdersList
        // 
        lb_OrdersList.BackColor = System.Drawing.Color.Honeydew;
        lb_OrdersList.FormattingEnabled = true;
        lb_OrdersList.Location = new System.Drawing.Point(40, 100);
        lb_OrdersList.Name = "lb_OrdersList";
        lb_OrdersList.Size = new System.Drawing.Size(700, 544);
        lb_OrdersList.TabIndex = 102;
        lb_OrdersList.SelectedIndexChanged += lb_OrdersList_SelectedIndexChanged;
        // 
        // btn_CancelCurrentOrder
        // 
        btn_CancelCurrentOrder.BackColor = System.Drawing.Color.Tomato;
        btn_CancelCurrentOrder.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_CancelCurrentOrder.ForeColor = System.Drawing.Color.Honeydew;
        btn_CancelCurrentOrder.Location = new System.Drawing.Point(40, 680);
        btn_CancelCurrentOrder.Name = "btn_CancelCurrentOrder";
        btn_CancelCurrentOrder.Size = new System.Drawing.Size(320, 40);
        btn_CancelCurrentOrder.TabIndex = 0;
        btn_CancelCurrentOrder.Text = "Cancel current order";
        btn_CancelCurrentOrder.UseVisualStyleBackColor = false;
        btn_CancelCurrentOrder.Click += btn_CancelCurrentOrder_Click;
        // 
        // lbl_DescriptionOrders
        // 
        lbl_DescriptionOrders.BackColor = System.Drawing.Color.Transparent;
        lbl_DescriptionOrders.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_DescriptionOrders.Location = new System.Drawing.Point(40, 60);
        lbl_DescriptionOrders.Name = "lbl_DescriptionOrders";
        lbl_DescriptionOrders.Size = new System.Drawing.Size(320, 20);
        lbl_DescriptionOrders.TabIndex = 101;
        lbl_DescriptionOrders.Text = "Review the status of past and current orders with us";
        lbl_DescriptionOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_Close
        // 
        btn_Close.BackColor = System.Drawing.Color.Crimson;
        btn_Close.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Close.ForeColor = System.Drawing.Color.Honeydew;
        btn_Close.Location = new System.Drawing.Point(620, 680);
        btn_Close.Name = "btn_Close";
        btn_Close.Size = new System.Drawing.Size(120, 40);
        btn_Close.TabIndex = 1;
        btn_Close.Text = "Close";
        btn_Close.UseVisualStyleBackColor = false;
        btn_Close.Click += btn_Cancel_Click;
        // 
        // lbl_Orders
        // 
        lbl_Orders.BackColor = System.Drawing.Color.Transparent;
        lbl_Orders.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Orders.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Orders.Location = new System.Drawing.Point(40, 29);
        lbl_Orders.Name = "lbl_Orders";
        lbl_Orders.Size = new System.Drawing.Size(320, 31);
        lbl_Orders.TabIndex = 100;
        lbl_Orders.Text = "Your past and current orders";
        lbl_Orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ReviewOrdersWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(784, 761);
        Controls.Add(lbl_Orders);
        Controls.Add(btn_Close);
        Controls.Add(lbl_DescriptionOrders);
        Controls.Add(btn_CancelCurrentOrder);
        Controls.Add(lb_OrdersList);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(800, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(800, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Favorites";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lbl_Orders;

    private System.Windows.Forms.Button btn_Close;

    private System.Windows.Forms.Label lbl_DescriptionOrders;

    private System.Windows.Forms.Button btn_CancelCurrentOrder;

    private System.Windows.Forms.ListBox lb_OrdersList;

    #endregion
}