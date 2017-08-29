namespace Lab6_Library
{
    partial class libraryGUI
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
            this.addButton = new System.Windows.Forms.Button();
            this.ISBNtext = new System.Windows.Forms.TextBox();
            this.TITLEtext = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.TITLE = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.libraryList = new System.Windows.Forms.ListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.loanStatusButton = new System.Windows.Forms.Button();
            this.onLoanButton = new System.Windows.Forms.Button();
            this.notOnLoanButton = new System.Windows.Forms.Button();
            this.libraryGUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.libraryGUIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(29, 82);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Book";
            this.toolTip.SetToolTip(this.addButton, "Add a book using ISBN and Title");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ISBNtext
            // 
            this.ISBNtext.Location = new System.Drawing.Point(73, 21);
            this.ISBNtext.Name = "ISBNtext";
            this.ISBNtext.Size = new System.Drawing.Size(102, 20);
            this.ISBNtext.TabIndex = 1;
            // 
            // TITLEtext
            // 
            this.TITLEtext.Location = new System.Drawing.Point(73, 48);
            this.TITLEtext.Name = "TITLEtext";
            this.TITLEtext.Size = new System.Drawing.Size(376, 20);
            this.TITLEtext.TabIndex = 2;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(37, 25);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(35, 13);
            this.ISBN.TabIndex = 3;
            this.ISBN.Text = "ISBN:";
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.Location = new System.Drawing.Point(32, 52);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(40, 13);
            this.TITLE.TabIndex = 4;
            this.TITLE.Text = "TITLE:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(386, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.toolTip.SetToolTip(this.searchButton, "Search for a book using ISBN or Title");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(29, 267);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 12;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(193, 82);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(98, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove Book";
            this.toolTip.SetToolTip(this.removeButton, "Remove a book using ISBN");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // libraryList
            // 
            this.libraryList.FormattingEnabled = true;
            this.libraryList.Location = new System.Drawing.Point(29, 145);
            this.libraryList.Name = "libraryList";
            this.libraryList.Size = new System.Drawing.Size(420, 108);
            this.libraryList.TabIndex = 15;
            // 
            // loanStatusButton
            // 
            this.loanStatusButton.Location = new System.Drawing.Point(368, 112);
            this.loanStatusButton.Name = "loanStatusButton";
            this.loanStatusButton.Size = new System.Drawing.Size(81, 23);
            this.loanStatusButton.TabIndex = 16;
            this.loanStatusButton.Text = "Loan Status";
            this.toolTip.SetToolTip(this.loanStatusButton, "Enter ISBN to view loan status");
            this.loanStatusButton.UseVisualStyleBackColor = true;
            this.loanStatusButton.Click += new System.EventHandler(this.loanStatusButton_Click);
            // 
            // onLoanButton
            // 
            this.onLoanButton.Location = new System.Drawing.Point(29, 112);
            this.onLoanButton.Name = "onLoanButton";
            this.onLoanButton.Size = new System.Drawing.Size(75, 23);
            this.onLoanButton.TabIndex = 17;
            this.onLoanButton.Text = "On Loan";
            this.toolTip.SetToolTip(this.onLoanButton, "Enter ISBN to set loan = true");
            this.onLoanButton.UseVisualStyleBackColor = true;
            this.onLoanButton.Click += new System.EventHandler(this.onLoanButton_Click);
            // 
            // notOnLoanButton
            // 
            this.notOnLoanButton.Location = new System.Drawing.Point(193, 112);
            this.notOnLoanButton.Name = "notOnLoanButton";
            this.notOnLoanButton.Size = new System.Drawing.Size(98, 23);
            this.notOnLoanButton.TabIndex = 18;
            this.notOnLoanButton.Text = "Not On Loan";
            this.toolTip.SetToolTip(this.notOnLoanButton, "Enter ISBN to set loan = false");
            this.notOnLoanButton.UseVisualStyleBackColor = true;
            this.notOnLoanButton.Click += new System.EventHandler(this.notOnLoanButton_Click);
            // 
            // libraryGUIBindingSource
            // 
            this.libraryGUIBindingSource.DataSource = typeof(Lab6_Library.libraryGUI);
            // 
            // libraryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 293);
            this.Controls.Add(this.notOnLoanButton);
            this.Controls.Add(this.onLoanButton);
            this.Controls.Add(this.loanStatusButton);
            this.Controls.Add(this.libraryList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.TITLEtext);
            this.Controls.Add(this.ISBNtext);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "libraryGUI";
            this.Text = "Library GUI";
            //this.Load += new System.EventHandler(this.libraryGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryGUIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox ISBNtext;
        private System.Windows.Forms.TextBox TITLEtext;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox libraryList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource libraryGUIBindingSource;
        private System.Windows.Forms.Button loanStatusButton;
        private System.Windows.Forms.Button onLoanButton;
        private System.Windows.Forms.Button notOnLoanButton;
    }
}

