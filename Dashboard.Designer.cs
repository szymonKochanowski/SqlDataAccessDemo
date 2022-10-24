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
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 20;
            this.peopleFoundListBox.Location = new System.Drawing.Point(77, 140);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(682, 124);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.LastNameTextBox.Location = new System.Drawing.Point(349, 61);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(191, 27);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(249, 65);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(354, 105);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // firstNameInsertTextBox
            // 
            this.firstNameInsertTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.firstNameInsertTextBox.Location = new System.Drawing.Point(172, 351);
            this.firstNameInsertTextBox.Name = "firstNameInsertTextBox";
            this.firstNameInsertTextBox.Size = new System.Drawing.Size(191, 27);
            this.firstNameInsertTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // lastNameInsertTexBox
            // 
            this.lastNameInsertTexBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lastNameInsertTexBox.Location = new System.Drawing.Point(172, 396);
            this.lastNameInsertTexBox.Name = "lastNameInsertTexBox";
            this.lastNameInsertTexBox.Size = new System.Drawing.Size(191, 27);
            this.lastNameInsertTexBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // emailInsertTextBox
            // 
            this.emailInsertTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.emailInsertTextBox.Location = new System.Drawing.Point(172, 439);
            this.emailInsertTextBox.Name = "emailInsertTextBox";
            this.emailInsertTextBox.Size = new System.Drawing.Size(191, 27);
            this.emailInsertTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gender";
            // 
            // genderInsertTextBox
            // 
            this.genderInsertTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.genderInsertTextBox.Location = new System.Drawing.Point(172, 487);
            this.genderInsertTextBox.Name = "genderInsertTextBox";
            this.genderInsertTextBox.Size = new System.Drawing.Size(191, 27);
            this.genderInsertTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add New Person";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(152, 546);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(94, 29);
            this.insertButton.TabIndex = 13;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 680);
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
    }
}