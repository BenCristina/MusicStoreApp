namespace MusicStoreApp.gui;

partial class RegistrationWindow
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
        lbl_GotAccount = new System.Windows.Forms.Label();
        cb_TermAndConditions = new System.Windows.Forms.CheckBox();
        btn_CreateAccount = new System.Windows.Forms.Button();
        tb_FirstName = new System.Windows.Forms.TextBox();
        lbl_FirstName = new System.Windows.Forms.Label();
        lbl_Email = new System.Windows.Forms.Label();
        lbl_BackToLogin = new System.Windows.Forms.Label();
        tb_Email = new System.Windows.Forms.TextBox();
        lbl_Phone = new System.Windows.Forms.Label();
        tb_Phone = new System.Windows.Forms.TextBox();
        lbl_Username = new System.Windows.Forms.Label();
        tb_Username = new System.Windows.Forms.TextBox();
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
        lbl_Password = new System.Windows.Forms.Label();
        tb_Password = new System.Windows.Forms.TextBox();
        lbl_PasswordRepeat = new System.Windows.Forms.Label();
        tb_PasswordRepeat = new System.Windows.Forms.TextBox();
        lbl_DateOfBirth = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        lbl_Succesful = new System.Windows.Forms.Label();
        dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
        SuspendLayout();
        // 
        // lbl_GotAccount
        // 
        lbl_GotAccount.BackColor = System.Drawing.Color.Transparent;
        lbl_GotAccount.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_GotAccount.Location = new System.Drawing.Point(440, 650);
        lbl_GotAccount.Name = "lbl_GotAccount";
        lbl_GotAccount.Size = new System.Drawing.Size(140, 20);
        lbl_GotAccount.TabIndex = 112;
        lbl_GotAccount.Text = "Already got an account?";
        // 
        // cb_TermAndConditions
        // 
        cb_TermAndConditions.BackColor = System.Drawing.Color.Transparent;
        cb_TermAndConditions.ForeColor = System.Drawing.Color.PaleGreen;
        cb_TermAndConditions.Location = new System.Drawing.Point(440, 580);
        cb_TermAndConditions.Name = "cb_TermAndConditions";
        cb_TermAndConditions.Size = new System.Drawing.Size(320, 20);
        cb_TermAndConditions.TabIndex = 12;
        cb_TermAndConditions.Text = "I agree to the terms and conditions.";
        cb_TermAndConditions.UseVisualStyleBackColor = false;
        // 
        // btn_CreateAccount
        // 
        btn_CreateAccount.BackColor = System.Drawing.Color.PaleGreen;
        btn_CreateAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_CreateAccount.ForeColor = System.Drawing.Color.DarkGreen;
        btn_CreateAccount.Location = new System.Drawing.Point(440, 600);
        btn_CreateAccount.Name = "btn_CreateAccount";
        btn_CreateAccount.Size = new System.Drawing.Size(320, 40);
        btn_CreateAccount.TabIndex = 13;
        btn_CreateAccount.Text = "Create account";
        btn_CreateAccount.UseVisualStyleBackColor = false;
        btn_CreateAccount.Click += btn_CreateAccount_Click;
        // 
        // tb_FirstName
        // 
        tb_FirstName.BackColor = System.Drawing.Color.Honeydew;
        tb_FirstName.Location = new System.Drawing.Point(440, 65);
        tb_FirstName.Name = "tb_FirstName";
        tb_FirstName.Size = new System.Drawing.Size(140, 23);
        tb_FirstName.TabIndex = 0;
        // 
        // lbl_FirstName
        // 
        lbl_FirstName.BackColor = System.Drawing.Color.Transparent;
        lbl_FirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_FirstName.ForeColor = System.Drawing.Color.Honeydew;
        lbl_FirstName.Location = new System.Drawing.Point(440, 40);
        lbl_FirstName.Name = "lbl_FirstName";
        lbl_FirstName.Size = new System.Drawing.Size(140, 20);
        lbl_FirstName.TabIndex = 100;
        lbl_FirstName.Text = "First name*";
        // 
        // lbl_Email
        // 
        lbl_Email.BackColor = System.Drawing.Color.Transparent;
        lbl_Email.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Email.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Email.Location = new System.Drawing.Point(440, 100);
        lbl_Email.Name = "lbl_Email";
        lbl_Email.Size = new System.Drawing.Size(320, 20);
        lbl_Email.TabIndex = 102;
        lbl_Email.Text = "Email address*";
        // 
        // lbl_BackToLogin
        // 
        lbl_BackToLogin.BackColor = System.Drawing.Color.Transparent;
        lbl_BackToLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lbl_BackToLogin.ForeColor = System.Drawing.Color.Honeydew;
        lbl_BackToLogin.Location = new System.Drawing.Point(440, 670);
        lbl_BackToLogin.Name = "lbl_BackToLogin";
        lbl_BackToLogin.Size = new System.Drawing.Size(320, 20);
        lbl_BackToLogin.TabIndex = 14;
        lbl_BackToLogin.Text = "Login here";
        lbl_BackToLogin.Click += lbl_BackToLogin_Click;
        // 
        // tb_Email
        // 
        tb_Email.BackColor = System.Drawing.Color.Honeydew;
        tb_Email.Location = new System.Drawing.Point(440, 125);
        tb_Email.Name = "tb_Email";
        tb_Email.Size = new System.Drawing.Size(320, 23);
        tb_Email.TabIndex = 2;
        // 
        // lbl_Phone
        // 
        lbl_Phone.BackColor = System.Drawing.Color.Transparent;
        lbl_Phone.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Phone.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Phone.Location = new System.Drawing.Point(440, 160);
        lbl_Phone.Name = "lbl_Phone";
        lbl_Phone.Size = new System.Drawing.Size(320, 20);
        lbl_Phone.TabIndex = 103;
        lbl_Phone.Text = "Phone number*";
        // 
        // tb_Phone
        // 
        tb_Phone.BackColor = System.Drawing.Color.Honeydew;
        tb_Phone.Location = new System.Drawing.Point(440, 185);
        tb_Phone.Name = "tb_Phone";
        tb_Phone.Size = new System.Drawing.Size(320, 23);
        tb_Phone.TabIndex = 3;
        // 
        // lbl_Username
        // 
        lbl_Username.BackColor = System.Drawing.Color.Transparent;
        lbl_Username.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Username.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Username.Location = new System.Drawing.Point(440, 400);
        lbl_Username.Name = "lbl_Username";
        lbl_Username.Size = new System.Drawing.Size(320, 20);
        lbl_Username.TabIndex = 109;
        lbl_Username.Text = "Username*";
        // 
        // tb_Username
        // 
        tb_Username.BackColor = System.Drawing.Color.Honeydew;
        tb_Username.Location = new System.Drawing.Point(440, 425);
        tb_Username.Name = "tb_Username";
        tb_Username.Size = new System.Drawing.Size(320, 23);
        tb_Username.TabIndex = 9;
        // 
        // lbl_LastName
        // 
        lbl_LastName.BackColor = System.Drawing.Color.Transparent;
        lbl_LastName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_LastName.ForeColor = System.Drawing.Color.Honeydew;
        lbl_LastName.Location = new System.Drawing.Point(620, 40);
        lbl_LastName.Name = "lbl_LastName";
        lbl_LastName.Size = new System.Drawing.Size(140, 20);
        lbl_LastName.TabIndex = 101;
        lbl_LastName.Text = "Last name*";
        // 
        // tb_LastName
        // 
        tb_LastName.BackColor = System.Drawing.Color.Honeydew;
        tb_LastName.Location = new System.Drawing.Point(620, 65);
        tb_LastName.Name = "tb_LastName";
        tb_LastName.Size = new System.Drawing.Size(140, 23);
        tb_LastName.TabIndex = 1;
        // 
        // lbl_HouseNumber
        // 
        lbl_HouseNumber.BackColor = System.Drawing.Color.Transparent;
        lbl_HouseNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_HouseNumber.ForeColor = System.Drawing.Color.Honeydew;
        lbl_HouseNumber.Location = new System.Drawing.Point(680, 220);
        lbl_HouseNumber.Name = "lbl_HouseNumber";
        lbl_HouseNumber.Size = new System.Drawing.Size(97, 20);
        lbl_HouseNumber.TabIndex = 105;
        lbl_HouseNumber.Text = "Number";
        // 
        // tb_HouseNumber
        // 
        tb_HouseNumber.BackColor = System.Drawing.Color.Honeydew;
        tb_HouseNumber.Location = new System.Drawing.Point(680, 245);
        tb_HouseNumber.Name = "tb_HouseNumber";
        tb_HouseNumber.Size = new System.Drawing.Size(80, 23);
        tb_HouseNumber.TabIndex = 5;
        // 
        // lbl_StreetName
        // 
        lbl_StreetName.BackColor = System.Drawing.Color.Transparent;
        lbl_StreetName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_StreetName.ForeColor = System.Drawing.Color.Honeydew;
        lbl_StreetName.Location = new System.Drawing.Point(440, 220);
        lbl_StreetName.Name = "lbl_StreetName";
        lbl_StreetName.Size = new System.Drawing.Size(140, 20);
        lbl_StreetName.TabIndex = 104;
        lbl_StreetName.Text = "Street name*";
        // 
        // tb_StreetName
        // 
        tb_StreetName.BackColor = System.Drawing.Color.Honeydew;
        tb_StreetName.Location = new System.Drawing.Point(440, 245);
        tb_StreetName.Name = "tb_StreetName";
        tb_StreetName.Size = new System.Drawing.Size(220, 23);
        tb_StreetName.TabIndex = 4;
        // 
        // lbl_ZipCode
        // 
        lbl_ZipCode.BackColor = System.Drawing.Color.Transparent;
        lbl_ZipCode.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_ZipCode.ForeColor = System.Drawing.Color.Honeydew;
        lbl_ZipCode.Location = new System.Drawing.Point(440, 280);
        lbl_ZipCode.Name = "lbl_ZipCode";
        lbl_ZipCode.Size = new System.Drawing.Size(80, 20);
        lbl_ZipCode.TabIndex = 106;
        lbl_ZipCode.Text = "Zip code*";
        // 
        // tb_ZipCode
        // 
        tb_ZipCode.BackColor = System.Drawing.Color.Honeydew;
        tb_ZipCode.Location = new System.Drawing.Point(440, 305);
        tb_ZipCode.Name = "tb_ZipCode";
        tb_ZipCode.Size = new System.Drawing.Size(80, 23);
        tb_ZipCode.TabIndex = 6;
        // 
        // lbl_City
        // 
        lbl_City.BackColor = System.Drawing.Color.Transparent;
        lbl_City.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_City.ForeColor = System.Drawing.Color.Honeydew;
        lbl_City.Location = new System.Drawing.Point(540, 280);
        lbl_City.Name = "lbl_City";
        lbl_City.Size = new System.Drawing.Size(140, 20);
        lbl_City.TabIndex = 107;
        lbl_City.Text = "City*";
        // 
        // tb_City
        // 
        tb_City.BackColor = System.Drawing.Color.Honeydew;
        tb_City.Location = new System.Drawing.Point(540, 305);
        tb_City.Name = "tb_City";
        tb_City.Size = new System.Drawing.Size(220, 23);
        tb_City.TabIndex = 7;
        // 
        // lbl_Password
        // 
        lbl_Password.BackColor = System.Drawing.Color.Transparent;
        lbl_Password.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Password.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Password.Location = new System.Drawing.Point(440, 460);
        lbl_Password.Name = "lbl_Password";
        lbl_Password.Size = new System.Drawing.Size(320, 20);
        lbl_Password.TabIndex = 110;
        lbl_Password.Text = "Password*";
        // 
        // tb_Password
        // 
        tb_Password.BackColor = System.Drawing.Color.Honeydew;
        tb_Password.Location = new System.Drawing.Point(440, 485);
        tb_Password.Name = "tb_Password";
        tb_Password.PasswordChar = '*';
        tb_Password.Size = new System.Drawing.Size(320, 23);
        tb_Password.TabIndex = 10;
        // 
        // lbl_PasswordRepeat
        // 
        lbl_PasswordRepeat.BackColor = System.Drawing.Color.Transparent;
        lbl_PasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_PasswordRepeat.ForeColor = System.Drawing.Color.Honeydew;
        lbl_PasswordRepeat.Location = new System.Drawing.Point(440, 520);
        lbl_PasswordRepeat.Name = "lbl_PasswordRepeat";
        lbl_PasswordRepeat.Size = new System.Drawing.Size(320, 20);
        lbl_PasswordRepeat.TabIndex = 111;
        lbl_PasswordRepeat.Text = "Repeat password*";
        // 
        // tb_PasswordRepeat
        // 
        tb_PasswordRepeat.BackColor = System.Drawing.Color.Honeydew;
        tb_PasswordRepeat.Location = new System.Drawing.Point(440, 545);
        tb_PasswordRepeat.Name = "tb_PasswordRepeat";
        tb_PasswordRepeat.PasswordChar = '*';
        tb_PasswordRepeat.Size = new System.Drawing.Size(320, 23);
        tb_PasswordRepeat.TabIndex = 11;
        // 
        // lbl_DateOfBirth
        // 
        lbl_DateOfBirth.BackColor = System.Drawing.Color.Transparent;
        lbl_DateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_DateOfBirth.ForeColor = System.Drawing.Color.Honeydew;
        lbl_DateOfBirth.Location = new System.Drawing.Point(440, 340);
        lbl_DateOfBirth.Name = "lbl_DateOfBirth";
        lbl_DateOfBirth.Size = new System.Drawing.Size(320, 20);
        lbl_DateOfBirth.TabIndex = 108;
        lbl_DateOfBirth.Text = "Date of birth*";
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Transparent;
        label1.ForeColor = System.Drawing.Color.PaleGreen;
        label1.Location = new System.Drawing.Point(686, 650);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(74, 20);
        label1.TabIndex = 113;
        label1.Text = "* Mandatory";
        // 
        // lbl_Succesful
        // 
        lbl_Succesful.Location = new System.Drawing.Point(440, 706);
        lbl_Succesful.Name = "lbl_Succesful";
        lbl_Succesful.Size = new System.Drawing.Size(319, 35);
        lbl_Succesful.TabIndex = 39;
        // 
        // dtp_DateOfBirth
        // 
        dtp_DateOfBirth.CalendarMonthBackground = System.Drawing.Color.Honeydew;
        dtp_DateOfBirth.Location = new System.Drawing.Point(440, 365);
        dtp_DateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
        dtp_DateOfBirth.Name = "dtp_DateOfBirth";
        dtp_DateOfBirth.Size = new System.Drawing.Size(320, 23);
        dtp_DateOfBirth.TabIndex = 8;
        // 
        // RegistrationWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(dtp_DateOfBirth);
        Controls.Add(lbl_Succesful);
        Controls.Add(label1);
        Controls.Add(lbl_DateOfBirth);
        Controls.Add(lbl_PasswordRepeat);
        Controls.Add(tb_PasswordRepeat);
        Controls.Add(lbl_Password);
        Controls.Add(tb_Password);
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
        Controls.Add(lbl_Username);
        Controls.Add(tb_Username);
        Controls.Add(lbl_Phone);
        Controls.Add(tb_Phone);
        Controls.Add(lbl_BackToLogin);
        Controls.Add(lbl_Email);
        Controls.Add(tb_Email);
        Controls.Add(lbl_FirstName);
        Controls.Add(tb_FirstName);
        Controls.Add(btn_CreateAccount);
        Controls.Add(cb_TermAndConditions);
        Controls.Add(lbl_GotAccount);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Create account";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;

    private System.Windows.Forms.Label lbl_Succesful;

    private System.Windows.Forms.Label label1;

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
    private System.Windows.Forms.Label lbl_Password;
    private System.Windows.Forms.TextBox tb_Password;
    private System.Windows.Forms.Label lbl_PasswordRepeat;
    private System.Windows.Forms.TextBox tb_PasswordRepeat;
    private System.Windows.Forms.Label lbl_DateOfBirth;

    private System.Windows.Forms.Label lbl_Phone;
    private System.Windows.Forms.TextBox tb_Phone;
    private System.Windows.Forms.Label lbl_Username;
    private System.Windows.Forms.TextBox tb_Username;

    private System.Windows.Forms.Label lbl_BackToLogin;

    private System.Windows.Forms.TextBox tb_Email;
    private System.Windows.Forms.Label lbl_Email;

    private System.Windows.Forms.Label lbl_FirstName;

    private System.Windows.Forms.TextBox tb_FirstName;

    private System.Windows.Forms.Button btn_CreateAccount;

    private System.Windows.Forms.CheckBox cb_TermAndConditions;

    private System.Windows.Forms.Label lbl_GotAccount;

    #endregion
}