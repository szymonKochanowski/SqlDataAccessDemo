namespace SqlDataAccessDemo
{
    partial class Dashboard
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameInsertTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameInsertTexBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInsertTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genderInsertTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 15;
            this.peopleFoundListBox.Location = new System.Drawing.Point(67, 105);
            this.peopleFoundListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(597, 94);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.LastNameTextBox.Location = new System.Drawing.Point(305, 46);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(168, 23);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(218, 49);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(310, 79);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 22);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // firstNameInsertTextBox
            // 
            this.firstNameInsertTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.firstNameInsertTextBox.Location = new System.Drawing.Point(150, 263);
            this.firstNameInsertTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameInsertTextBox.Name = "firstNameInsertTextBox";
            this.firstNameInsertTextBox.Size = new System.Drawing.Size(168, 23);
            this.firstNameInsertTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // lastNameInsertTexBox
            // 
            this.lastNameInsertTexBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lastNameInsertTexBox.Location = new System.Drawing.Point(150, 297);
            this.lastNameInsertTexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameInsertTexBox.Name = "lastNameInsertTexBox";
            this.lastNameInsertTexBox.Size = new System.Drawing.Size(168, 23);
            this.lastNameInsertTexBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // emailInsertTextBox
            // 
            this.emailInsertTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.emailInsertTextBox.Location = new System.Drawing.Point(150, 329);
            this.emailInsertTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailInsertTextBox.Name = "emailInsertTextBox";
            this.emailInsertTextBox.Size = new System.Drawing.Size(168, 23);
            this.emailInsertTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gender";
            // 
            // genderInsertTextBox
            // 
            this.genderInsertTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.genderInsertTextBox.Location = new System.Drawing.Point(150, 365);
            this.genderInsertTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderInsertTextBox.Name = "genderInsertTextBox";
            this.genderInsertTextBox.Size = new System.Drawing.Size(168, 23);
            this.genderInsertTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add New Person";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(133, 410);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(82, 22);
            this.insertButton.TabIndex = 13;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(553, 410);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 22);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Id";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.IdTextBox.Location = new System.Drawing.Point(521, 368);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(168, 23);
            this.IdTextBox.TabIndex = 15;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(255, 410);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(82, 22);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 522);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genderInsertTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailInsertTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameInsertTexBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameInsertTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.peopleFoundListBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "DatabaseAccessDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox peopleFoundListBox;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private Button searchButton;
        private Label label1;
        private TextBox firstNameInsertTextBox;
        private Label label2;
        private TextBox lastNameInsertTexBox;
        private Label label3;
        private TextBox emailInsertTextBox;
        private Label label4;
        private TextBox genderInsertTextBox;
        private Label label5;
        private Button insertButton;
        private Button button1;
        private Button deleteButton;
        private Label label6;
        private TextBox IdTextBox;
        private Button updateButton;
    }
}