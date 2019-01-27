namespace MegaDesk_1_IrinaOhara
{
    partial class AddQuote
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
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.width = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.numberOfDrawers = new System.Windows.Forms.ComboBox();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.rushOrder = new System.Windows.Forms.ComboBox();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(192, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 26);
            this.name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Depth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number Of Drawers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Surface Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Rush Order";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(192, 125);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 26);
            this.width.TabIndex = 10;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(192, 175);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 26);
            this.depth.TabIndex = 11;
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.FormattingEnabled = true;
            this.numberOfDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numberOfDrawers.Location = new System.Drawing.Point(249, 217);
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(121, 28);
            this.numberOfDrawers.TabIndex = 12;
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceMaterial.Location = new System.Drawing.Point(219, 268);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(121, 28);
            this.surfaceMaterial.TabIndex = 13;
            // 
            // rushOrder
            // 
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.rushOrder.Location = new System.Drawing.Point(249, 326);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(121, 28);
            this.rushOrder.TabIndex = 14;
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(163, 392);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(207, 46);
            this.btnGetQuote.TabIndex = 15;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Location = new System.Drawing.Point(472, 371);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(209, 54);
            this.btnBackToMainMenu.TabIndex = 16;
            this.btnBackToMainMenu.Text = "Back To Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.numberOfDrawers);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.ComboBox numberOfDrawers;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.ComboBox rushOrder;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Button btnBackToMainMenu;
    }
}