namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ContactListView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCtrlQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberNUP = new System.Windows.Forms.NumericUpDown();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.RelationComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberNUP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactListView
            // 
            this.ContactListView.LargeImageList = this.imageList1;
            this.ContactListView.Location = new System.Drawing.Point(75, 218);
            this.ContactListView.Name = "ContactListView";
            this.ContactListView.Size = new System.Drawing.Size(694, 305);
            this.ContactListView.TabIndex = 0;
            this.ContactListView.UseCompatibleStateImageBehavior = false;
            this.ContactListView.SelectedIndexChanged += new System.EventHandler(this.ContactListView_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(75, 181);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(45, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCtrlSToolStripMenuItem,
            this.exitCtrlQToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveCtrlSToolStripMenuItem.Text = "Save";
            this.saveCtrlSToolStripMenuItem.Click += new System.EventHandler(this.saveCtrlSToolStripMenuItem_Click);
            // 
            // exitCtrlQToolStripMenuItem
            // 
            this.exitCtrlQToolStripMenuItem.Name = "exitCtrlQToolStripMenuItem";
            this.exitCtrlQToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitCtrlQToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitCtrlQToolStripMenuItem.Text = "Exit";
            this.exitCtrlQToolStripMenuItem.Click += new System.EventHandler(this.exitCtrlQToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "FAMILY.jpg");
            this.imageList1.Images.SetKeyName(1, "FRIEND.jpg");
            this.imageList1.Images.SetKeyName(2, "BUISNESS.jpg");
            this.imageList1.Images.SetKeyName(3, "OTHER.jpg");
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(6, 183);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 212);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(200, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(6, 241);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(87, 23);
            this.PrevButton.TabIndex = 4;
            this.PrevButton.Text = "Previos";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(119, 241);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(87, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(6, 154);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(200, 23);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(86, 24);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.FirstNameTextBox.TabIndex = 7;
            this.FirstNameTextBox.Text = "John";
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(86, 50);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.LastNameTextBox.TabIndex = 8;
            this.LastNameTextBox.Text = "Wick";
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // PhoneNumberNUP
            // 
            this.PhoneNumberNUP.Location = new System.Drawing.Point(86, 76);
            this.PhoneNumberNUP.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.PhoneNumberNUP.Name = "PhoneNumberNUP";
            this.PhoneNumberNUP.Size = new System.Drawing.Size(120, 20);
            this.PhoneNumberNUP.TabIndex = 9;
            this.PhoneNumberNUP.Value = new decimal(new int[] {
            -539222987,
            2,
            0,
            0});
            this.PhoneNumberNUP.ValueChanged += new System.EventHandler(this.PhoneNumberNUP_ValueChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(86, 102);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(120, 20);
            this.EmailTextBox.TabIndex = 10;
            this.EmailTextBox.Text = "TheBoogieMan@gmail.com";
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rowLabel);
            this.groupBox1.Controls.Add(this.RelationComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PhoneNumberNUP);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Controls.Add(this.PrevButton);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(75, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 302);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of Rows";
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(116, 267);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(34, 13);
            this.rowLabel.TabIndex = 14;
            this.rowLabel.Text = "0 of 0";
            // 
            // RelationComboBox
            // 
            this.RelationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelationComboBox.FormattingEnabled = true;
            this.RelationComboBox.Items.AddRange(new object[] {
            "Family",
            "Friend",
            "Buisness",
            "Other"});
            this.RelationComboBox.Location = new System.Drawing.Point(85, 127);
            this.RelationComboBox.MaxDropDownItems = 4;
            this.RelationComboBox.Name = "RelationComboBox";
            this.RelationComboBox.Size = new System.Drawing.Size(121, 21);
            this.RelationComboBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Relation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 1061);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ContactListView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberNUP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ContactListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitCtrlQToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.NumericUpDown PhoneNumberNUP;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RelationComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rowLabel;
    }
}

