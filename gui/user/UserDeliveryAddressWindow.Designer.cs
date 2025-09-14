namespace MusicStoreApp;

partial class UserDeliveryAddressWindow
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
        btn_cancel = new System.Windows.Forms.Button();
        tb_StreetName = new System.Windows.Forms.TextBox();
        lbl_UpdateDeliveryAddress = new System.Windows.Forms.Label();
        cb_UpdateAccount = new System.Windows.Forms.CheckBox();
        btn_update = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        tb_FirstName = new System.Windows.Forms.TextBox();
        tb_LastName = new System.Windows.Forms.TextBox();
        tb_HouseNumber = new System.Windows.Forms.TextBox();
        tb_ZipCode = new System.Windows.Forms.TextBox();
        tb_City = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // btn_cancel
        // 
        btn_cancel.BackColor = System.Drawing.Color.Crimson;
        btn_cancel.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_cancel.ForeColor = System.Drawing.Color.Honeydew;
        btn_cancel.Location = new System.Drawing.Point(240, 400);
        btn_cancel.Name = "btn_cancel";
        btn_cancel.Size = new System.Drawing.Size(120, 40);
        btn_cancel.TabIndex = 181;
        btn_cancel.Text = "Cancel";
        btn_cancel.UseVisualStyleBackColor = false;
        btn_cancel.Click += btn_cancel_Click;
        // 
        // tb_StreetName
        // 
        tb_StreetName.BackColor = System.Drawing.Color.Honeydew;
        tb_StreetName.Location = new System.Drawing.Point(40, 180);
        tb_StreetName.Name = "tb_StreetName";
        tb_StreetName.Size = new System.Drawing.Size(320, 23);
        tb_StreetName.TabIndex = 2;
        tb_StreetName.Text = "Street name";
        // 
        // lbl_UpdateDeliveryAddress
        // 
        lbl_UpdateDeliveryAddress.BackColor = System.Drawing.Color.Transparent;
        lbl_UpdateDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_UpdateDeliveryAddress.ForeColor = System.Drawing.Color.Honeydew;
        lbl_UpdateDeliveryAddress.Location = new System.Drawing.Point(40, 40);
        lbl_UpdateDeliveryAddress.Name = "lbl_UpdateDeliveryAddress";
        lbl_UpdateDeliveryAddress.Size = new System.Drawing.Size(320, 20);
        lbl_UpdateDeliveryAddress.TabIndex = 100;
        lbl_UpdateDeliveryAddress.Text = "Update your delivery address";
        lbl_UpdateDeliveryAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        lbl_UpdateDeliveryAddress.Visible = false;
        // 
        // cb_UpdateAccount
        // 
        cb_UpdateAccount.BackColor = System.Drawing.Color.Transparent;
        cb_UpdateAccount.ForeColor = System.Drawing.Color.PaleGreen;
        cb_UpdateAccount.Location = new System.Drawing.Point(40, 340);
        cb_UpdateAccount.Name = "cb_UpdateAccount";
        cb_UpdateAccount.Size = new System.Drawing.Size(320, 20);
        cb_UpdateAccount.TabIndex = 6;
        cb_UpdateAccount.Text = "Also update the address linked to my acccount";
        cb_UpdateAccount.UseVisualStyleBackColor = false;
        cb_UpdateAccount.CheckedChanged += cb_UpdateAccount_CheckedChanged;
        // 
        // btn_update
        // 
        btn_update.BackColor = System.Drawing.Color.MediumSeaGreen;
        btn_update.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_update.ForeColor = System.Drawing.Color.Honeydew;
        btn_update.Location = new System.Drawing.Point(40, 400);
        btn_update.Name = "btn_update";
        btn_update.Size = new System.Drawing.Size(120, 40);
        btn_update.TabIndex = 7;
        btn_update.Text = "Update";
        btn_update.UseVisualStyleBackColor = false;
        btn_update.Click += btn_update_Click;
        // 
        // label3
        // 
        label3.BackColor = System.Drawing.Color.Transparent;
        label3.ForeColor = System.Drawing.Color.PaleGreen;
        label3.Location = new System.Drawing.Point(40, 60);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(320, 20);
        label3.TabIndex = 101;
        label3.Text = "Where do you want us to ship your order?";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tb_FirstName
        // 
        tb_FirstName.BackColor = System.Drawing.Color.Honeydew;
        tb_FirstName.Location = new System.Drawing.Point(40, 100);
        tb_FirstName.Name = "tb_FirstName";
        tb_FirstName.Size = new System.Drawing.Size(320, 23);
        tb_FirstName.TabIndex = 0;
        tb_FirstName.Text = "First name";
        // 
        // tb_LastName
        // 
        tb_LastName.BackColor = System.Drawing.Color.Honeydew;
        tb_LastName.Location = new System.Drawing.Point(40, 140);
        tb_LastName.Name = "tb_LastName";
        tb_LastName.Size = new System.Drawing.Size(320, 23);
        tb_LastName.TabIndex = 1;
        tb_LastName.Text = "Last name";
        // 
        // tb_HouseNumber
        // 
        tb_HouseNumber.BackColor = System.Drawing.Color.Honeydew;
        tb_HouseNumber.Location = new System.Drawing.Point(40, 220);
        tb_HouseNumber.Name = "tb_HouseNumber";
        tb_HouseNumber.Size = new System.Drawing.Size(320, 23);
        tb_HouseNumber.TabIndex = 3;
        tb_HouseNumber.Text = "House number";
        // 
        // tb_ZipCode
        // 
        tb_ZipCode.BackColor = System.Drawing.Color.Honeydew;
        tb_ZipCode.Location = new System.Drawing.Point(40, 260);
        tb_ZipCode.Name = "tb_ZipCode";
        tb_ZipCode.Size = new System.Drawing.Size(320, 23);
        tb_ZipCode.TabIndex = 4;
        tb_ZipCode.Text = "Zip code";
        // 
        // tb_City
        // 
        tb_City.BackColor = System.Drawing.Color.Honeydew;
        tb_City.Location = new System.Drawing.Point(40, 300);
        tb_City.Name = "tb_City";
        tb_City.Size = new System.Drawing.Size(320, 23);
        tb_City.TabIndex = 5;
        tb_City.Text = "City";
        // 
        // DeliveryAddressWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(384, 481);
        Controls.Add(tb_City);
        Controls.Add(tb_ZipCode);
        Controls.Add(tb_HouseNumber);
        Controls.Add(tb_LastName);
        Controls.Add(tb_FirstName);
        Controls.Add(lbl_UpdateDeliveryAddress);
        Controls.Add(tb_StreetName);
        Controls.Add(btn_cancel);
        Controls.Add(label3);
        Controls.Add(cb_UpdateAccount);
        Controls.Add(btn_update);
        Location = new System.Drawing.Point(15, 15);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(400, 520);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(400, 520);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Delivery address";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox tb_ZipCode;
    private System.Windows.Forms.TextBox tb_City;

    private System.Windows.Forms.TextBox tb_LastName;
    private System.Windows.Forms.TextBox tb_HouseNumber;

    private System.Windows.Forms.CheckBox cb_UpdateAccount;
    private System.Windows.Forms.Button btn_update;
    private System.Windows.Forms.TextBox tb_FirstName;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label lbl_UpdateDeliveryAddress;

    private System.Windows.Forms.TextBox tb_StreetName;

    private System.Windows.Forms.Button btn_cancel;

    #endregion
}