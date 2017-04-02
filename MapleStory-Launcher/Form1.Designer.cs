namespace MSLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mapleLocLabel = new System.Windows.Forms.Label();
            this.mapleLocationTextbox = new System.Windows.Forms.TextBox();
            this.exeBrowseButton = new System.Windows.Forms.Button();
            this.exeBrowseDialog = new System.Windows.Forms.OpenFileDialog();
            this.launchMethodLabel = new System.Windows.Forms.Label();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(83, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(171, 22);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.WordWrap = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(6, 22);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(62, 16);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Email/ID:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(6, 50);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(83, 47);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(171, 22);
            this.passwordTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(9, 75);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(245, 42);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextbox);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.methodComboBox);
            this.groupBox2.Controls.Add(this.launchMethodLabel);
            this.groupBox2.Controls.Add(this.exeBrowseButton);
            this.groupBox2.Controls.Add(this.mapleLocationTextbox);
            this.groupBox2.Controls.Add(this.mapleLocLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 83);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // mapleLocLabel
            // 
            this.mapleLocLabel.AutoSize = true;
            this.mapleLocLabel.Location = new System.Drawing.Point(5, 22);
            this.mapleLocLabel.Name = "mapleLocLabel";
            this.mapleLocLabel.Size = new System.Drawing.Size(31, 13);
            this.mapleLocLabel.TabIndex = 0;
            this.mapleLocLabel.Text = "EXE:";
            // 
            // mapleLocationTextbox
            // 
            this.mapleLocationTextbox.Enabled = false;
            this.mapleLocationTextbox.Location = new System.Drawing.Point(42, 19);
            this.mapleLocationTextbox.Name = "mapleLocationTextbox";
            this.mapleLocationTextbox.Size = new System.Drawing.Size(178, 20);
            this.mapleLocationTextbox.TabIndex = 1;
            this.mapleLocationTextbox.WordWrap = false;
            // 
            // exeBrowseButton
            // 
            this.exeBrowseButton.Location = new System.Drawing.Point(226, 19);
            this.exeBrowseButton.Name = "exeBrowseButton";
            this.exeBrowseButton.Size = new System.Drawing.Size(28, 20);
            this.exeBrowseButton.TabIndex = 2;
            this.exeBrowseButton.Text = "...";
            this.exeBrowseButton.UseVisualStyleBackColor = true;
            this.exeBrowseButton.Click += new System.EventHandler(this.exeBrowseButton_Click);
            // 
            // exeBrowseDialog
            // 
            this.exeBrowseDialog.FileName = "MapleStory.exe";
            this.exeBrowseDialog.InitialDirectory = ".";
            this.exeBrowseDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exeBrowseDialog_FileOk);
            // 
            // launchMethodLabel
            // 
            this.launchMethodLabel.AutoSize = true;
            this.launchMethodLabel.Location = new System.Drawing.Point(6, 53);
            this.launchMethodLabel.Name = "launchMethodLabel";
            this.launchMethodLabel.Size = new System.Drawing.Size(85, 13);
            this.launchMethodLabel.TabIndex = 3;
            this.launchMethodLabel.Text = "Launch Method:";
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.ItemHeight = 13;
            this.methodComboBox.Items.AddRange(new object[] {
            "Web Login",
            "Nexon Launcher"});
            this.methodComboBox.Location = new System.Drawing.Point(99, 50);
            this.methodComboBox.MaxDropDownItems = 2;
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(155, 21);
            this.methodComboBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 275);
            this.MinimumSize = new System.Drawing.Size(300, 275);
            this.Name = "Form1";
            this.Text = "MapleStory Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mapleLocationTextbox;
        private System.Windows.Forms.Label mapleLocLabel;
        private System.Windows.Forms.Button exeBrowseButton;
        private System.Windows.Forms.OpenFileDialog exeBrowseDialog;
        private System.Windows.Forms.Label launchMethodLabel;
        private System.Windows.Forms.ComboBox methodComboBox;
    }
}

