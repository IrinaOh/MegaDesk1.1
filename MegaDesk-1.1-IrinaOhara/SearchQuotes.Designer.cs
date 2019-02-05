namespace MegaDesk_1_IrinaOhara
{
    partial class searchQuotes
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
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.ComboBox();
            this.searchResultView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Location = new System.Drawing.Point(30, 536);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(150, 70);
            this.btnBackToMainMenu.TabIndex = 0;
            this.btnBackToMainMenu.Text = "Back To Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(456, 24);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(145, 37);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.FormattingEnabled = true;
            this.searchInput.Location = new System.Drawing.Point(30, 24);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(397, 28);
            this.searchInput.TabIndex = 4;
            // 
            // searchResultView
            // 
            this.searchResultView.FormattingEnabled = true;
            this.searchResultView.ItemHeight = 20;
            this.searchResultView.Location = new System.Drawing.Point(30, 131);
            this.searchResultView.Name = "searchResultView";
            this.searchResultView.Size = new System.Drawing.Size(571, 304);
            this.searchResultView.TabIndex = 6;
            // 
            // searchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 634);
            this.Controls.Add(this.searchResultView);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Name = "searchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.ComboBox searchInput;
        private System.Windows.Forms.ListBox searchResultView;
    }
}