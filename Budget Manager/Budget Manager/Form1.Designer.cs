namespace Budget_Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mcCalender = new System.Windows.Forms.MonthCalendar();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbPaidUsing = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paid using";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // mcCalender
            // 
            this.mcCalender.Location = new System.Drawing.Point(114, 245);
            this.mcCalender.MaxSelectionCount = 1;
            this.mcCalender.Name = "mcCalender";
            this.mcCalender.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 5;
            // 
            // cbPaidUsing
            // 
            this.cbPaidUsing.FormattingEnabled = true;
            this.cbPaidUsing.Items.AddRange(new object[] {
            "Check",
            "Online",
            "Debit Card",
            "Credit Card",
            "Cash"});
            this.cbPaidUsing.Location = new System.Drawing.Point(438, 126);
            this.cbPaidUsing.Name = "cbPaidUsing";
            this.cbPaidUsing.Size = new System.Drawing.Size(250, 24);
            this.cbPaidUsing.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(799, 129);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(126, 22);
            this.txtAmount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1010, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Utilities",
            "Food",
            "Household",
            "Grocery",
            "Entertainment"});
            this.cbCategory.Location = new System.Drawing.Point(1013, 126);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(438, 245);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 22);
            this.txtDescription.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(45, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Expense";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(799, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 43);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 558);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cbPaidUsing);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.mcCalender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar mcCalender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbPaidUsing;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnAdd;
    }
}

