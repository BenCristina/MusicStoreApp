namespace MusicStoreApp.gui.admin;

partial class AdminUpdateAccountWindow
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
        btn_UpdateAccount = new System.Windows.Forms.Button();
        tb_FirstName = new System.Windows.Forms.TextBox();
        lbl_FirstName = new System.Windows.Forms.Label();
        lbl_Email = new System.Windows.Forms.Label();
        tb_Email = new System.Windows.Forms.TextBox();
        lbl_Phone = new System.Windows.Forms.Label();
        tb_Phone = new System.Windows.Forms.TextBox();
        lbl_LastName = new System.Windows.Forms.Label();
        tb_LastName = new System.Windows.Forms.TextBox();
        lbl_HouseNumber = new System.Windows.Forms.Label();
        tb_HouseNumber = new System.Windows.Forms.TextBox();
        lbl_StreetName = new System.Windows.Forms.Label();
        tb_StreetName = new System.Windows.Forms.TextBox();
        lbl_ZipCode = new System.Windows.Forms.Label();
        tb_ZipCode = new System.Windows.Forms.TextBox();
        lbl_City = new System.Windows.Forms.Label();
        tb_City = new System.Windows.Forms.TextBox();
        lbl_DateOfBirth = new System.Windows.Forms.Label();
        dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
        lbl_Mandatory = new System.Windows.Forms.Label();
        btn_Cancel = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        lbl_WindowInfo = new System.Windows.Forms.Label();
        cb_ConfirmationWarning = new System.Windows.Forms.CheckBox();
        SuspendLayout();
        // 
        // btn_UpdateAccount
        // 
        btn_UpdateAccount.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_UpdateAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_UpdateAccount.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_UpdateAccount.Location = new System.Drawing.Point(40, 600);
        btn_UpdateAccount.Name = "btn_UpdateAccount";
        btn_UpdateAccount.Size = new System.Drawing.Size(160, 40);
        btn_UpdateAccount.TabIndex = 10;
        btn_UpdateAccount.Text = "Update account";
        btn_UpdateAccount.UseVisualStyleBackColor = false;
        btn_UpdateAccount.Click += btn_UpdateAccount_Click;
        // 
        // tb_FirstName
        // 
        tb_FirstName.BackColor = System.Drawing.Color.Honeydew;
        tb_FirstName.Location = new System.Drawing.Point(40, 125);
        tb_FirstName.Name = "tb_FirstName";
        tb_FirstName.Size = new System.Drawing.Size(140, 23);
        tb_FirstName.TabIndex = 0;
        // 
        // lbl_FirstName
        // 
        lbl_FirstName.BackColor = System.Drawing.Color.Transparent;
        lbl_FirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_FirstName.ForeColor = System.Drawing.Color.Honeydew;
        lbl_FirstName.Location = new System.Drawing.Point(40, 100);
        lbl_FirstName.Name = "lbl_FirstName";
        lbl_FirstName.Size = new System.Drawing.Size(140, 20);
        lbl_FirstName.TabIndex = 102;
        lbl_FirstName.Text = "First name*";
        // 
        // lbl_Email
        // 
        lbl_Email.BackColor = System.Drawing.Color.Transparent;
        lbl_Email.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Email.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Email.Location = new System.Drawing.Point(40, 160);
        lbl_Email.Name = "lbl_Email";
        lbl_Email.Size = new System.Drawing.Size(320, 20);
        lbl_Email.TabIndex = 104;
        lbl_Email.Text = "Email address*";
        // 
        // tb_Email
        // 
        tb_Email.BackColor = System.Drawing.Color.Honeydew;
        tb_Email.Location = new System.Drawing.Point(40, 185);
        tb_Email.Name = "tb_Email";
        tb_Email.Size = new System.Drawing.Size(320, 23);
        tb_Email.TabIndex = 2;
        // 
        // lbl_Phone
        // 
        lbl_Phone.BackColor = System.Drawing.Color.Transparent;
        lbl_Phone.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Phone.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Phone.Location = new System.Drawing.Point(40, 220);
        lbl_Phone.Name = "lbl_Phone";
        lbl_Phone.Size = new System.Drawing.Size(320, 20);
        lbl_Phone.TabIndex = 105;
        lbl_Phone.Text = "Phone number*";
        // 
        // tb_Phone
        // 
        tb_Phone.BackColor = System.Drawing.Color.Honeydew;
        tb_Phone.Location = new System.Drawing.Point(40, 245);
        tb_Phone.Name = "tb_Phone";
        tb_Phone.Size = new System.Drawing.Size(320, 23);
        tb_Phone.TabIndex = 3;
        // 
        // lbl_LastName
        // 
        lbl_LastName.BackColor = System.Drawing.Color.Transparent;
        lbl_LastName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_LastName.ForeColor = System.Drawing.Color.Honeydew;
        lbl_LastName.Location = new System.Drawing.Point(220, 100);
        lbl_LastName.Name = "lbl_LastName";
        lbl_LastName.Size = new System.Drawing.Size(140, 20);
        lbl_LastName.TabIndex = 103;
        lbl_LastName.Text = "Last name*";
        // 
        // tb_LastName
        // 
        tb_LastName.BackColor = System.Drawing.Color.Honeydew;
        tb_LastName.Location = new System.Drawing.Point(220, 125);
        tb_LastName.Name = "tb_LastName";
        tb_LastName.Size = new System.Drawing.Size(140, 23);
        tb_LastName.TabIndex = 1;
        // 
        // lbl_HouseNumber
        // 
        lbl_HouseNumber.BackColor = System.Drawing.Color.Transparent;
        lbl_HouseNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_HouseNumber.ForeColor = System.Drawing.Color.Honeydew;
        lbl_HouseNumber.Location = new System.Drawing.Point(280, 280);
        lbl_HouseNumber.Name = "lbl_HouseNumber";
        lbl_HouseNumber.Size = new System.Drawing.Size(91, 20);
        lbl_HouseNumber.TabIndex = 107;
        lbl_HouseNumber.Text = "Number*";
        // 
        // tb_HouseNumber
        // 
        tb_HouseNumber.BackColor = System.Drawing.Color.Honeydew;
        tb_HouseNumber.Location = new System.Drawing.Point(280, 305);
        tb_HouseNumber.Name = "tb_HouseNumber";
        tb_HouseNumber.Size = new System.Drawing.Size(80, 23);
        tb_HouseNumber.TabIndex = 5;
        // 
        // lbl_StreetName
        // 
        lbl_StreetName.BackColor = System.Drawing.Color.Transparent;
        lbl_StreetName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_StreetName.ForeColor = System.Drawing.Color.Honeydew;
        lbl_StreetName.Location = new System.Drawing.Point(40, 280);
        lbl_StreetName.Name = "lbl_StreetName";
        lbl_StreetName.Size = new System.Drawing.Size(140, 20);
        lbl_StreetName.TabIndex = 106;
        lbl_StreetName.Text = "Street name*";
        // 
        // tb_StreetName
        // 
        tb_StreetName.BackColor = System.Drawing.Color.Honeydew;
        tb_StreetName.Location = new System.Drawing.Point(40, 305);
        tb_StreetName.Name = "tb_StreetName";
        tb_StreetName.Size = new System.Drawing.Size(220, 23);
        tb_StreetName.TabIndex = 4;
        // 
        // lbl_ZipCode
        // 
        lbl_ZipCode.BackColor = System.Drawing.Color.Transparent;
        lbl_ZipCode.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_ZipCode.ForeColor = System.Drawing.Color.Honeydew;
        lbl_ZipCode.Location = new System.Drawing.Point(40, 335);
        lbl_ZipCode.Name = "lbl_ZipCode";
        lbl_ZipCode.Size = new System.Drawing.Size(94, 29);
        lbl_ZipCode.TabIndex = 108;
        lbl_ZipCode.Text = "Zip code*";
        // 
        // tb_ZipCode
        // 
        tb_ZipCode.BackColor = System.Drawing.Color.Honeydew;
        tb_ZipCode.Location = new System.Drawing.Point(40, 365);
        tb_ZipCode.Name = "tb_ZipCode";
        tb_ZipCode.Size = new System.Drawing.Size(80, 23);
        tb_ZipCode.TabIndex = 6;
        // 
        // lbl_City
        // 
        lbl_City.BackColor = System.Drawing.Color.Transparent;
        lbl_City.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_City.ForeColor = System.Drawing.Color.Honeydew;
        lbl_City.Location = new System.Drawing.Point(140, 335);
        lbl_City.Name = "lbl_City";
        lbl_City.Size = new System.Drawing.Size(140, 29);
        lbl_City.TabIndex = 109;
        lbl_City.Text = "City*";
        // 
        // tb_City
        // 
        tb_City.BackColor = System.Drawing.Color.Honeydew;
        tb_City.Location = new System.Drawing.Point(140, 365);
        tb_City.Name = "tb_City";
        tb_City.Size = new System.Drawing.Size(220, 23);
        tb_City.TabIndex = 7;
        // 
        // lbl_DateOfBirth
        // 
        lbl_DateOfBirth.BackColor = System.Drawing.Color.Transparent;
        lbl_DateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_DateOfBirth.ForeColor = System.Drawing.Color.Honeydew;
        lbl_DateOfBirth.Location = new System.Drawing.Point(40, 400);
        lbl_DateOfBirth.Name = "lbl_DateOfBirth";
        lbl_DateOfBirth.Size = new System.Drawing.Size(320, 20);
        lbl_DateOfBirth.TabIndex = 110;
        lbl_DateOfBirth.Text = "Date of birth*";
        // 
        // dtp_DateOfBirth
        // 
        dtp_DateOfBirth.CalendarMonthBackground = System.Drawing.Color.Honeydew;
        dtp_DateOfBirth.Location = new System.Drawing.Point(42, 425);
        dtp_DateOfBirth.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
        dtp_DateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
        dtp_DateOfBirth.Name = "dtp_DateOfBirth";
        dtp_DateOfBirth.Size = new System.Drawing.Size(317, 23);
        dtp_DateOfBirth.TabIndex = 8;
        dtp_DateOfBirth.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
        // 
        // lbl_Mandatory
        // 
        lbl_Mandatory.BackColor = System.Drawing.Color.Transparent;
        lbl_Mandatory.ForeColor = System.Drawing.Color.Aquamarine;
        lbl_Mandatory.Location = new System.Drawing.Point(40, 655);
        lbl_Mandatory.Name = "lbl_Mandatory";
        lbl_Mandatory.Size = new System.Drawing.Size(74, 20);
        lbl_Mandatory.TabIndex = 111;
        lbl_Mandatory.Text = "* Mandatory";
        // 
        // btn_Cancel
        // 
        btn_Cancel.BackColor = System.Drawing.Color.Crimson;
        btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Cancel.ForeColor = System.Drawing.Color.Honeydew;
        btn_Cancel.Location = new System.Drawing.Point(259, 600);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new System.Drawing.Size(100, 40);
        btn_Cancel.TabIndex = 11;
        btn_Cancel.Text = "Cancel";
        btn_Cancel.UseVisualStyleBackColor = false;
        btn_Cancel.Click += btn_Cancel_Click;
        // 
        // lbl_WelcomeMessage
        // 
        lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
        lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_WelcomeMessage.ForeColor = System.Drawing.Color.Honeydew;
        lbl_WelcomeMessage.Location = new System.Drawing.Point(40, 40);
        lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
        lbl_WelcomeMessage.Size = new System.Drawing.Size(320, 20);
        lbl_WelcomeMessage.TabIndex = 100;
        lbl_WelcomeMessage.Text = "Update user account information here";
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.Aquamarine;
        lbl_WindowInfo.Location = new System.Drawing.Point(40, 60);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(346, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "Before you start, first confirm with the user";
        // 
        // cb_ConfirmationWarning
        // 
        cb_ConfirmationWarning.ForeColor = System.Drawing.Color.Aquamarine;
        cb_ConfirmationWarning.Location = new System.Drawing.Point(40, 470);
        cb_ConfirmationWarning.Name = "cb_ConfirmationWarning";
        cb_ConfirmationWarning.Size = new System.Drawing.Size(320, 23);
        cb_ConfirmationWarning.TabIndex = 9;
        cb_ConfirmationWarning.Text = "I hereby confirm that the user requested these changes. *";
        cb_ConfirmationWarning.UseVisualStyleBackColor = true;
        // 
        // AdminUpdateAccountWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Teal;
        ClientSize = new System.Drawing.Size(404, 761);
        Controls.Add(cb_ConfirmationWarning);
        Controls.Add(lbl_WindowInfo);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_Cancel);
        Controls.Add(lbl_Mandatory);
        Controls.Add(dtp_DateOfBirth);
        Controls.Add(lbl_DateOfBirth);
        Controls.Add(lbl_City);
        Controls.Add(tb_City);
        Controls.Add(lbl_ZipCode);
        Controls.Add(tb_ZipCode);
        Controls.Add(lbl_HouseNumber);
        Controls.Add(tb_HouseNumber);
        Controls.Add(lbl_StreetName);
        Controls.Add(tb_StreetName);
        Controls.Add(lbl_LastName);
        Controls.Add(tb_LastName);
        Controls.Add(lbl_Phone);
        Controls.Add(tb_Phone);
        Controls.Add(lbl_Email);
        Controls.Add(tb_Email);
        Controls.Add(lbl_FirstName);
        Controls.Add(tb_FirstName);
        Controls.Add(btn_UpdateAccount);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(420, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(420, 800);
        Opacity = 0.95D;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Update Users Account";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.CheckBox cb_ConfirmationWarning;

    private System.Windows.Forms.Label lbl_WelcomeMessage;
    private System.Windows.Forms.Label lbl_WindowInfo;

    private System.Windows.Forms.Button btn_Cancel;

    private System.Windows.Forms.Label lbl_Mandatory;

    private System.Windows.Forms.Label lbl_LastName;
    private System.Windows.Forms.TextBox tb_LastName;
    private System.Windows.Forms.Label lbl_HouseNumber;
    private System.Windows.Forms.TextBox tb_HouseNumber;
    private System.Windows.Forms.Label lbl_StreetName;
    private System.Windows.Forms.TextBox tb_StreetName;
    private System.Windows.Forms.Label lbl_ZipCode;
    private System.Windows.Forms.TextBox tb_ZipCode;
    private System.Windows.Forms.Label lbl_City;
    private System.Windows.Forms.TextBox tb_City;
    private System.Windows.Forms.Label lbl_DateOfBirth;
    private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;

    private System.Windows.Forms.Label lbl_Phone;
    private System.Windows.Forms.TextBox tb_Phone;

    private System.Windows.Forms.TextBox tb_Email;
    private System.Windows.Forms.Label lbl_Email;

    private System.Windows.Forms.Label lbl_FirstName;

    private System.Windows.Forms.TextBox tb_FirstName;

    private System.Windows.Forms.Button btn_UpdateAccount;

    #endregion
}